echo on
call "C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin\MSBuild.exe" ..\..\LoggerMonitor.sln -property:Configuration=Release > LoggerMonitor-Release.log
echo off
