@echo off

:: Build dll
rm bin/ obj/ -rf
dotnet publish -c Release

:: Generate Key
cd ./bin/Release/net48/
sn -k key.snk

:: ReCompile
ildasm FileTimePropPage.dll /OUTPUT=FileTimePropPage.il
ilasm FileTimePropPage.il /DLL /OUTPUT=FileTimePropPage.dll /KEY=key.snk

:: Register
cp ./publish/SharpShell.dll ../../../build/SharpShell.dll
cp ./FileTimePropPage.dll ../../../build/FileTimePropPage.dll
cd ../../..
regasm /codebase ./build/FileTimePropPage.dll

:: regasm /u ./build/FileTimePropPage.dll

@echo on