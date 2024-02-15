@echo off 

rem A batch file for hello.cs 
rem which captures the apps return value 

dotnet run 
@if "%ERRORLEVEL%" == "0" goto success 

:fail
	echo This application has failed 
	echo return value = %ERRORLEVEL%
	goto end 

:success
	echo this application has succeeded 
	echo return value = %ERRORLEVEL%
	goto end 

:end 
echo all done 