#!/usr/bin/env bash

scriptPath="$( cd "$(dirname "$0")" ; pwd -P )"
_CMakeBuildType=Debug
_CMakeArgs=
_CMakeToolchain=
_CMakeEnableBitcode=
_CMakeOsxArchitectures=
_CMakeGenerator=
_CMakeIosPlatform=
_Submodule=
_ArtifactName=
_OutDir=
_CombinedStatic=
_CMakeSystemProcessor=
_CMakeCCompiler=
_CMakeCxxCompiler=
_CMakeFindRootPathMode=

while :; do
    if [ $# -le 0 ]; then
        break
    fi

    lowerI="$(echo $1 | awk '{print tolower($0)}')"
    case $lowerI in
        --build-type)
            _CMakeBuildType=$2
            shift
            ;;
		--cmake-args)
            _CMakeArgs=$(echo $2 | tr -d \")
            shift
            ;;
		--submodule)
            _Submodule=$2
            shift
            ;;
		--artifact-name)
            _ArtifactName=$2
            shift
            ;;
		--out-dir)
            _OutDir=$2
            shift
            ;;
        --ios)
            _CMakeToolchain=-DCMAKE_TOOLCHAIN_FILE=$scriptPath/toolchains/ios.toolchain.cmake
            _CMakeEnableBitcode=-DENABLE_BITCODE=0
            _CMakeGenerator="-G Xcode"
            _CMakeIosPlatform=-DPLATFORM=$2
            ;;
        --osx)
            _CMakeOsxArchitectures=-DCMAKE_OSX_ARCHITECTURES="$2"
            shift
            ;;
        --linux)
            _CMakeToolchain=-DCMAKE_TOOLCHAIN_FILE=$scriptPath/toolchains/aarch64-linux-gnu.toolchain.cmake
            shift
            ;;
        --combined-static)
            _CombinedStatic=$2
            shift
            ;;
        *)
            __UnprocessedBuildArgs="$__UnprocessedBuildArgs $1"
    esac

    shift
done

_OutputPath=$scriptPath/build/$_Submodule

_PythonExePath=$(which python3)
if [[ $_PythonExePath == "" ]]; then
    echo Build failed: could not locate python executable.
    exit 1
fi

mkdir -p $_OutputPath
pushd $_OutputPath
cmake ../../submodules/$_Submodule -DCMAKE_BUILD_TYPE=$_CMakeBuildType $_CMakeArgs $_CMakeGenerator $_CMakeToolchain $_CMakeIosPlatform $_CMakeEnableBitcode -DPYTHON_EXECUTABLE=$_PythonExePath $_CMakeOsxArchitectures $_CMakeSystemProcessor $_CMakeCCompiler $_CMakeCxxCompiler $_CMakeFindRootPathMode
cmake --build . --config $_CMakeBuildType
popd

if [[ $_CombinedStatic != "" ]]; then
    _CombineStaticSources=$(find $_CombinedStatic -maxdepth 1 -type f -name *.a | tr '\n' ' ')
    libtool -static -o $_ArtifactName $_CombineStaticSources
fi

cp -v $_ArtifactName $_OutDir