FROM mcr.microsoft.com/dotnet/sdk:8.0.406 AS build
WORKDIR /app

COPY ["CommandsService.csproj", "."]
RUN dotnet restore "CommandsService.csproj"

COPY . .
WORKDIR /app

FROM build AS publish
RUN dotnet publish "CommandsService.csproj" -c Release -o /app

FROM build AS final
WORKDIR /app
COPY --from=publish /app .
ENV ASPNETCORE_URLS=http://+:80
ENV ASPNETCORE_ENVIRONMENT=Development
EXPOSE 80
ENTRYPOINT ["dotnet", "CommandsService.dll"]