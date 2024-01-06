
using Spirzza.Interop.SpirvCross;
using Spirzza.Interop.Shaderc;
using static Spirzza.Interop.SpirvCross.SpirvCross;
using static Spirzza.Interop.Shaderc.Shaderc;
using System.Runtime.InteropServices;
using System.Text;
using System.Diagnostics;

namespace Spirzza.Sandbox;

using static spvc_basetype;

public static unsafe partial class Program
{
    public static void Main(string[] args)
    {
        string fileName = "shaders/iching-03.frag";
        string resultName = fileName + ".spv";
        string compiledName = fileName + ".compiled";
        string entryPoint = "main";

        Stopwatch watch = new();

        Console.WriteLine();
        Console.WriteLine("Compiling from Glsl to Spirv");
        Console.WriteLine();

        {
            shaderc_compiler* compiler = shaderc_compiler_initialize();
            shaderc_compile_options* options = shaderc_compile_options_initialize();

            shaderc_compile_options_set_optimization_level(options, shaderc_optimization_level.shaderc_optimization_level_performance);
            shaderc_compile_options_set_source_language(options, shaderc_source_language.shaderc_source_language_glsl);

            for (int i = 0; i < 10; i++)
            {
                watch.Restart();
                string source = File.ReadAllText(fileName);

                sbyte* sourceUtf8 = (sbyte*) Marshal.StringToHGlobalAnsi(source);
                sbyte* fileNameUtf8 = (sbyte*) Marshal.StringToHGlobalAnsi(fileName);
                sbyte* entryPointUtf8 = (sbyte*) Marshal.StringToHGlobalAnsi(entryPoint);
                watch.Stop();
                PrintTime("ReadAllText: ", watch);

                watch.Restart();
                shaderc_compilation_result* result = shaderc_compile_into_spv(
                    compiler,
                    sourceUtf8,
                    (nuint) MemoryMarshal.CreateReadOnlySpanFromNullTerminated((byte*) sourceUtf8).Length,
                    shaderc_shader_kind.shaderc_fragment_shader,
                    fileNameUtf8,
                    entryPointUtf8,
                    options);
                watch.Stop();
                PrintTime("shaderc_compile_into_spv: ", watch);

                Marshal.FreeHGlobal((IntPtr) sourceUtf8);
                Marshal.FreeHGlobal((IntPtr) fileNameUtf8);
                Marshal.FreeHGlobal((IntPtr) entryPointUtf8);

                watch.Restart();
                Console.Write(shaderc_result_get_compilation_status(result) + " -> ");
                Console.WriteLine('"' + Marshal.PtrToStringUTF8((IntPtr) shaderc_result_get_error_message(result)) + '"');

                Span<byte> resultBytes = new(
                    shaderc_result_get_bytes(result),
                    (int) shaderc_result_get_length(result));

                File.WriteAllBytes(resultName, resultBytes.ToArray());
                shaderc_result_release(result);
                watch.Stop();
                PrintTime("WriteAllBytes: ", watch);

                Console.WriteLine();
            }

            shaderc_compile_options_release(options);
            shaderc_compiler_release(compiler);
        }

        Console.WriteLine();
        Console.WriteLine("Compiling from Spirv to Glsl");
        Console.WriteLine();

        {
            spvc_context* context;
            _ = spvc_context_create(&context);

            for (int i = 0; i < 10; i++)
            {
                watch.Restart();
                byte[] spvSource = File.ReadAllBytes(resultName);
                watch.Stop();
                PrintTime("ReadAllBytes: ", watch);

                watch.Restart();
                spvc_parsed_ir* parsedIr;
                spvc_result parseResult;
                fixed (byte* spvSourcePtr = spvSource)
                {
                    parseResult = spvc_context_parse_spirv(
                        context, (SpvId*) spvSourcePtr, (nuint) spvSource.Length / (nuint) sizeof(SpvId), &parsedIr);
                }
                watch.Stop();
                PrintTime($"spvc_context_parse_spirv -> {parseResult}: ", watch);

                watch.Restart();
                spvc_compiler* compiler;
                spvc_result createResult = spvc_context_create_compiler(
                    context, spvc_backend.SPVC_BACKEND_GLSL, parsedIr, spvc_capture_mode.SPVC_CAPTURE_MODE_TAKE_OWNERSHIP, &compiler);

                sbyte* compiledSource;
                spvc_result compileResult = spvc_compiler_compile(compiler, &compiledSource);
                PrintTime("spvc_compiler_compile: ", watch);
                watch.Stop();

                watch.Restart();
                ReadOnlySpan<byte> compiledBytes = MemoryMarshal.CreateReadOnlySpanFromNullTerminated((byte*) compiledSource);

                File.WriteAllBytes(compiledName, compiledBytes.ToArray());
                PrintTime("WriteAllBytes: ", watch);
                watch.Stop();

                Console.WriteLine();
            }

            spvc_context_release_allocations(context);

            spvc_context_destroy(context);
        }

        static void PrintTime(string prefix, Stopwatch watch)
        {
            Console.WriteLine(prefix + watch.Elapsed.TotalMilliseconds.ToString("0.0") + "ms");
        }
    }
}