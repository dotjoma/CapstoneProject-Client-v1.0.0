@echo off
echo.
echo === Preparing to push to remote repository ===

echo.
echo Adding all files to Git...
git add .

set /p commit_message=Enter your commit message: 

echo.
echo Making initial commit...
git commit -m "%commit_message%"

echo.
echo Pushing to remote repository...
git push -u origin main

echo.
echo Push to remote repository completed successfully!
pause
