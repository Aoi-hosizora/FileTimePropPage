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
cp ./publish/SharpShell.dll ./SharpShell.dll
regasm /codebase FileTimePropPage.dll

:: regasm /u FileTimePropPage.dll

@echo on