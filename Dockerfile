# FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
# RUN apt-get update -yq \
#     && apt-get install curl gnupg -yq \
#     && curl -sL https://deb.nodesource.com/setup_10.x | bash \
#     && apt-get install nodejs -yq
# WORKDIR /app
# EXPOSE 80

# FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
# RUN apt-get update -yq \
#     && apt-get install curl gnupg -yq \
#     && curl -sL https://deb.nodesource.com/setup_10.x | bash \
#     && apt-get install nodejs -yq
# WORKDIR /src
# COPY ["Cityton.Ui/Cityton.Ui.csproj", "Cityton.Ui/"]
# COPY ["Cityton.Service/Cityton.Service.csproj", "Cityton.Service/"]
# COPY ["Cityton.Repository/Cityton.Repository.csproj", "Cityton.Repository/"]
# COPY ["Cityton.Data/Cityton.Data.csproj", "Cityton.Data/"]
# RUN dotnet restore "Cityton.Ui/Cityton.Ui.csproj"
# COPY . .
# WORKDIR "/src/Cityton.Ui"
# RUN dotnet build "Cityton.Ui.csproj" -c Release -o /app/build

# FROM build AS publish
# RUN dotnet publish "Cityton.Ui.csproj" -c Release -o /app/publish

# FROM base AS final
# WORKDIR /app
# COPY --from=publish /app/publish .
# ENTRYPOINT ["dotnet", "Cityton.Ui.dll"]





# FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS build
# WORKDIR /app

# # copy csproj and restore as distinct layers
# COPY *.sln .
# COPY Cityton.Ui/*.csproj ./cityton/
# RUN dotnet restore

# # copy everything else and build app
# COPY Cityton.Ui/. ./cityton/
# WORKDIR /app/cityton
# RUN dotnet publish -c Release -o publish


# FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS runtime
# WORKDIR /app
# COPY --from=build /app/cityton/publish ./
# ENTRYPOINT ["dotnet", "Cityton.Ui.dll"]


# FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
# RUN apt-get update -yq \
#     && apt-get install curl gnupg -yq \
#     && curl -sL https://deb.nodesource.com/setup_10.x | bash \
#     && apt-get install nodejs -yq
# WORKDIR /app
# EXPOSE 80
# EXPOSE 443

# FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
# WORKDIR /src
# RUN apt-get update -yq \
#     && apt-get install curl gnupg -yq \
#     && curl -sL https://deb.nodesource.com/setup_10.x | bash \
#     && apt-get install nodejs -yq
# COPY ["Cityton.Ui/Cityton.Ui.csproj", "Cityton.Ui/"]
# COPY ["Cityton.Service/Cityton.Service.csproj", "Cityton.Service/"]
# COPY ["Cityton.Repository/Cityton.Repository.csproj", "Cityton.Repository/"]
# COPY ["Cityton.Data/Cityton.Data.csproj", "Cityton.Data/"]
# RUN dotnet restore "Cityton.Ui/Cityton.Ui.csproj"
# COPY . .
# WORKDIR "/src/Cityton.Ui"
# RUN dotnet build "Cityton.Ui.csproj" -c Release -o /app/build

# FROM build AS publish
# RUN dotnet publish "Cityton.Ui.csproj" -c Release -o /app/publish

# FROM base AS final
# WORKDIR /app
# COPY --from=publish /app/publish .
# ENTRYPOINT ["dotnet", "Cityton.Ui.dll"]

FROM mcr.microsoft.com/dotnet/core/aspnet:3.0 AS runtime

WORKDIR /app

COPY ./publish .

ENTRYPOINT ["dotnet", "Cityton.Ui.dll"]