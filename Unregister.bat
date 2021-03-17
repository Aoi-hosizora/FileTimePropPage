@echo off

:: Unregister
cd FileTimePropPage.Extension\build
regasm /u FileTimePropPage.Extension.dll
cd ..\..

@echo on
