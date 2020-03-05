FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 5000

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["Cityton.Ui/Cityton.Ui.csproj", "Cityton.Ui/"]
COPY ["Cityton.Service/Cityton.Service.csproj", "Cityton.Service/"]
COPY ["Cityton.Repository/Cityton.Repository.csproj", "Cityton.Repository/"]
COPY ["Cityton.Data/Cityton.Data.csproj", "Cityton.Data/"]
RUN dotnet restore "Cityton.Ui/Cityton.Ui.csproj"
RUN dotnet restore "Cityton.Service/Cityton.Service.csproj"
RUN dotnet restore "Cityton.Repository/Cityton.Repository.csproj"
RUN dotnet restore "Cityton.Data/Cityton.Data.csproj"
COPY . .
WORKDIR "/src/Cityton.Ui"
RUN dotnet build "Cityton.Ui.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Cityton.Ui.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Cityton.Ui.dll"]
