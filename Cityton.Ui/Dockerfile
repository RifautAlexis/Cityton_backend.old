FROM mcr.microsoft.com/dotnet/core/aspnet:3.0 AS runtime

WORKDIR /app

COPY ./publish .

ENTRYPOINT ["dotnet", "Cityton.Ui.dll"]