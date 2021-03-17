@echo off

:: Generate Key
cd FileTimePropPage.Extension\bin\x64\Release
if not exist "key.snk" sn -k key.snk

:: Recompile
ildasm FileTimePropPage.Extension.dll /OUTPUT=FileTimePropPage.Extension.il
ilasm FileTimePropPage.Extension.il /DLL /OUTPUT=FileTimePropPage.Extension.dll /KEY=key.snk

:: Backup dll
if not exist "..\..\..\build" mkdir ..\..\..\build
cp *.dll ..\..\..\build
cd ..\..\..\build

:: Register
regasm /codebase FileTimePropPage.Extension.dll

:: Back to solution folder
cd ..\..

@echo on
