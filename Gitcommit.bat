@ECHO OFF
:start
cls
echo ------------
echo  init   1
echo  commit 2 
echo  update 3 
echo ------------
set /p "set=What do you want to do(input the corrisponding number)?"
if %set%== 2 (goto commit)
if %set%== 1 (goto init)
if %set%== 3 (goto fetch)
pause
goto end

:commit
cls
set /p "reason=Enter your reason for this commit:"
git add .
git commit -m "%reason%"
git push origin master
pause
goto end

:init
set /p "origin=What is your origin?"
git init
git remote add origin %origin%
git add .
git commit -m "first commit"
git push -u origin master
echo finished setup
pause
goto end

:fetch
git pull origin master
echo finished updating local repository
pause
goto end

:end 
cls
set /p "stop=Do you want to stop this commit(n for no. if yes input anything else)?"
if %stop% == n (goto start) else (stop)