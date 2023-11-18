#!/usr/bin/env bash

scriptPath="$( cd "$(dirname "$0")" ; pwd -P )"
_CMakeBuildType=Debug
_CMakeArgs=
_CMakeToolchain=
_CMakeIOSPlatform=
_CMakeEnableBitcode=
_CMakeOsxArchitectures=
_CMakeGenerator=
_Submodule=
_CombinedStatic=

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
        ios)
            _CMakeToolchain=-DCMAKE_TOOLCHAIN_FILE=$scriptPath/ios/ios.toolchain.cmake
            _CMakePlatform=-DPLATFORM=OS64COMBINED
            _CMakeEnableBitcode=-DENABLE_BITCODE=0
            _CMakeGenerator="-G Xcode -T buildsystem=1"
            ;;
        --osx-archs)
            _CMakeOsxArchitectures=$2
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
cmake ../../submodules/$_Submodule -DCMAKE_BUILD_TYPE=$_CMakeBuildType $_CMakeArgs $_CMakeGenerator $_CMakeToolchain $_CMakePlatform $_CMakeEnableBitcode -DPYTHON_EXECUTABLE=$_PythonExePath -DCMAKE_OSX_ARCHITECTURES="$_CMakeOsxArchitectures"
cmake --build . --config $_CMakeBuildType
popd

if [[ $_CombinedStatic != "" ]]; then
    _CombineStaticSources=$(find $_CombinedStatic -maxdepth 1 -type f -name *.a | tr '\n' ' ')
    libtool -static -o $_CombinedStatic/$(_Submodule)_combined.a $_CombineStaticSources
fi
