# dotnet-cmder

[![AppVeyor build status][appveyor-badge]](https://ci.appveyor.com/project/EifelMono/dotnet-cmder/branch/master)

[![NuGet][main-nuget-badge]][main-nuget]

[main-nuget]: https://www.nuget.org/packages/dotnet-cmder/
[main-nuget-badge]: https://img.shields.io/nuget/v/dotnet-cmder.svg?style=flat-square&label=nuget

dotnet-cmder starts cmder in the current folder.

This tool inculdes Cmder Mini 1.3.5 from http://cmder.net/

This tool works only on windows

On Windows you can insert dotnet-cmder also in the address line.

## In action

### dotnet-cmder in address line
![](https://github.com/EifelMono/dotnet-cmder/blob/master/media/dotnet-cmder.gif)

## Install
```
dotnet tool install dotnet-cmder -g
```

## Requirements

[2.1.300-preview2](https://www.microsoft.com/net/download/dotnet-core/sdk-2.1.300-preview2) .NET Core SDK or newer
Section "Global Tools"

How to check the installed dotnet version
```
dotnet --version
```

## Install .........

### from NuGet.org

```
dotnet tool install dotnet-cmder -g
```
This downloads dotnet-cmder from NuGet.org

### local after the build

You can also clone the repo and run the cakebuiild build.ps1 or build.sh batch file.<br>
This will install the dotnet-cmder from the new build without NuGet.org.

## Uninstall

Goto your personal folder

* Windows
```
cd %userprofile%
```
* Mac and Linux
```
cd ~
``` 
Then goto the folder .dotnet/tools

```
cd .dotnet/tools
```
Here you find the program starter which you can delete.

```
cd .dotnet/tools/.storage
```
Here you find the real program which you can delete.

Or use the dotnet uninstall programm
```
dotnet tool uninstall dotnet-cmder -g
```

Or use the cakebuild batch file build.sh or build.ps1 with the target uninstall
```
./build.ps1 -target=uninstall
or
./build.sh -target=uninstall
```

