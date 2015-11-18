REM %1 is the location to nuget.exe
setlocal
set nugetpath=%1
shift
set file=%1

%nugetpath% pack %file% -BasePath ..\bin\release 

endlocal