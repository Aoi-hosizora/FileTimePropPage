# FileTimePropPage
+ Add file times changer into file's property pages
+ My tool to modify many file's times at the same time: [FileTimeChanger](https://github.com/Aoi-hosizora/FileTimeChanger)

### Environment
+ `.NET Core cli 2.2.401`
+ `.NET Framework 4.8`
+ `VS Code`
+ `Windows 10 Version 1803`

### Path
+ `Program Files\Microsoft SDKs\Windows\vx.xA\bin\NETFX x.x.x Tools` -> `sn.exe` / `ildasm.exe`
+ `Windows\Microsoft.NET\Framework64\vx.x.x` -> `ilasm.exe` / `regasm.exe`

### Depedences
```bash
# Add depedence
dotnet add package SharpShell
dotnet add package System.Windows.Forms
dotnet add package System.Drawing.Common
```

```xml
<PropertyGroup>
    <TargetFramework>net48</TargetFramework>
</PropertyGroup>
```
+ See [FileTimePropPage.csproj](./FileTimePropPage.csproj)

### Build
```bash
# Do this in cmd

# Build dll
rm bin/ obj/ -rf
dotnet publish -c Release

# Generate Key
cd ./bin/Release/net48/
sn -k key.snk

# ReCompile
ildasm FileTimePropPage.dll /OUTPUT=FileTimePropPage.il
ilasm FileTimePropPage.il /DLL /OUTPUT=FileTimePropPage.dll /KEY=key.snk

# Copy to Build (Avoid to delete dll that is using)
cp ./publish/SharpShell.dll ../../../build/SharpShell.dll
cp ./FileTimePropPage.dll ../../../build/FileTimePropPage.dll
cd ../../..

# Register
regasm /codebase ./build/FileTimePropPage.dll
```

### UnRegister
```bash
regasm /u ./build/FileTimePropPage.dll

# Restart explorer.exe
```

### Problem
+ [ ] Apply button could not work well
+ [ ] Could not get administrator authority

### ScreenShot
![PropPage](./assets/PropPage.jpg)

### References
+ [sharpshell](https://github.com/dwmkerr/sharpshell)
+ [propertysheetextension](https://github.com/dwmkerr/sharpshell/blob/master/docs/extensions/propertysheetextension/propertysheetextension.md)