FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Tema1/Tema1.csproj", "Tema1/"]
RUN dotnet restore "Tema1/Tema1.csproj"
COPY . .
WORKDIR "/src/Tema1"
RUN dotnet build "Tema1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Tema1.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Tema1.dll"]
