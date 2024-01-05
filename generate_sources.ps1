dotnet tool update --global ClangSharpPInvokeGenerator --version 17.0.0

ClangSharpPInvokeGenerator --file-directory submodules/shaderc/libshaderc/include --include-directory submodules/shaderc/libshaderc/include "@scripts/GenerateShaderc.rsp"
ClangSharpPInvokeGenerator --file-directory submodules/SPIRV-Cross --include-directory submodules/SPIRV-Cross "@scripts/GenerateSpirvCross.rsp"