echo on
call "C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\MSBuild.exe" ..\..\LoggerMonitor.sln -property:Configuration=Release > LoggerMonitor-Release.log
echo off
