#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
USER app
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Ls.cli/Ls.cli.csproj", "Ls.cli/"]
COPY ["МРПЗ Лаб.№3/L3.Domain.csproj", "МРПЗ Лаб.№3/"]
RUN dotnet restore "./Ls.cli/./Ls.cli.csproj"
COPY . .
WORKDIR "/src/Ls.cli"
RUN dotnet build "./Ls.cli.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Ls.cli.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Ls.cli.dll"]