cd Cityton.Web
start "ng serve" ng serve --watch=true

cd ..\Cityton.Ui
start "dotnet watch run" dotnet watch run

start chrome http://localhost:4200