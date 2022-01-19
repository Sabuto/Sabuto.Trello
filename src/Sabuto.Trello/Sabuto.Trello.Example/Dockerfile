FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Sabuto.Trello.Example/Sabuto.Trello.Example.csproj", "Sabuto.Trello.Example/"]
RUN dotnet restore "Sabuto.Trello.Example/Sabuto.Trello.Example.csproj"
COPY . .
WORKDIR "/src/Sabuto.Trello.Example"
RUN dotnet build "Sabuto.Trello.Example.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Sabuto.Trello.Example.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Sabuto.Trello.Example.dll"]
