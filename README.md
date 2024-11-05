# Tracy-CSharp

![](Header.png)

C# bindings for https://github.com/wolfpld/tracy with native dynamic link libraries based on [`imgui-cs`](https://github.com/bottlenoselabs/imgui-cs).

## How to use

## Get it from [NuGet](https://www.nuget.org/packages/Tracy-CSharp)

```bash
dotnet add package Tracy-CSharp --version 0.11.1-hotfix
```

### From source

## Installing `C2CS`

`C2CS` is distributed as a NuGet tool. To get started, the .NET 7 software development kit (SDK) is required.

### Latest release of `C2CS`

```bash
dotnet tool install bottlenoselabs.c2cs.tool --global
```

1. Download and install [.NET 7](https://dotnet.microsoft.com/download).
2. Fork the repository using GitHub or clone the repository manually with submodules: `git clone --recurse-submodules https://github.com/clibequilibrium/Tracy-CSharp`.
3. Build the native library by running `library.sh`. To execute `.sh` scripts on Windows, use Git Bash which can be installed with Git itself: https://git-scm.com/download/win. The `library.sh` script requires that CMake is installed and in your path.
4. Install `C2CS` and `CAstFfi` from dotnet CLI
```
dotnet tool install --global bottlenoselabs.C2CS.Tool
dotnet tool install --global bottlenoselabs.CAstFfi.Tool
dotnet tool install --global bottlenoselabs.c2ffi.tool
```
5. Configure Tracy's macros, extract Tracy AST, and regenerate C# bindings.
```bash
cd bindgen
./extract.sh
./merge.sh
./generate.sh
``` 
6. Locate the sample of the C# project: `./src/cs/samples/HelloWorld/HelloWorld.csproj`.

## Developers: Documentation

For more information on how C# bindings work, see [`C2CS`](https://github.com/lithiumtoast/c2cs), the tool that generates the bindings for `Tracy` and other C libraries.

To learn how to use `Tracy`, check out the [official readme](https://github.com/wolfpld/tracy).

To build tracy-profiler
```
cd ext/Tracy
cmake -B profiler/build -S profiler -DCMAKE_BUILD_TYPE=Release -DTRACY_FIBERS=ON
cmake --build profiler/build --parallel --config Release
```

## License

`Tracy-CSharp` is licensed under the MIT License (`MIT`) - see the [LICENSE file](LICENSE) for details.

`Tracy` itself is licensed under BSD license (`BSD`) - see https://github.com/wolfpld/tracy/blob/master/LICENSE for more details.
