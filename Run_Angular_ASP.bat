cd Cityton.Ui/ClientApp
start "ng serve" ng serve --watch=true

cd ..
start "dotnet watch run" dotnet watch run

start chrome http://localhost:5000