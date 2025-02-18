# FROM mcr.microsoft.com/dotnet/sdk:8.0.406 AS build
# WORKDIR /app

# COPY *.csproj ./
# RUN dotnet restore

# COPY . ./
# RUN dotnet publish -c Release -o out

# FROM mcr.microsoft.com/dotnet/aspnet:8.0
# WORKDIR /app
# COPY --from=build-env /app/out .
# ENTRYPOINT [ "dotnet", "PlatformService.dll" ]

FROM mcr.microsoft.com/dotnet/sdk:8.0.406 AS build
WORKDIR /app

COPY ["PlatformService.csproj", "."]
RUN dotnet restore "PlatformService.csproj"

COPY . .
WORKDIR /app

# RUN dotnet publish "PlatformService.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "PlatformService.csproj" -c Release -o /app

FROM build AS final
WORKDIR /app
COPY --from=publish /app .
ENV ASPNETCORE_URLS=http://+:80
ENV ASPNETCORE_ENVIRONMENT=Production
EXPOSE 80
ENTRYPOINT ["dotnet", "PlatformService.dll"]
