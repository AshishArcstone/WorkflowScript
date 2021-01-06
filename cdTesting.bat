@echo on
set from=%~dp0
echo %from%
cd %from%packages\NUnit.ConsoleRunner.3.11.1\tools
nunit3-console.exe %from%bin\Debug\WorkflowScript.dll

pause