@echo off
rem Removes the "downloaded from the internet" mark from every file in this folder.
powershell -NoProfile -ExecutionPolicy Bypass -Command "Get-ChildItem -LiteralPath '%~dp0' -Recurse -Force | Unblock-File"
echo Done. Now open HotelSystem.csproj in Visual Studio.
pause
