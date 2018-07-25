@echo off
if [%1]==[] (goto :defineparams) else (set id="%1")

:main
git add .
git commit -am "%id%"
git push origin master
goto :eof


:defineparams
set /p id="Nhap thong tin update git: "
goto :main