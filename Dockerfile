#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
ENV ASPNETCORE_ENVIRONMENT=Development

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /app
COPY hogwarts-api/hogwarts-api.csproj hogwarts-api/
COPY hogwarts-bll/hogwarts-bll.csproj hogwarts-bll/
COPY hogwarts-repository/hogwarts-repository.csproj hogwarts-repository/
RUN dotnet restore "hogwarts-api/hogwarts-api.csproj"
COPY . .
WORKDIR "/app/hogwarts-api"
RUN dotnet build "hogwarts-api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "hogwarts-api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "hogwarts-api.dll"]