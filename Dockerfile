# ---- Build-Stufe (NET 8.0 Preview) ----
FROM mcr.microsoft.com/dotnet/sdk:8.0-preview AS build-env
WORKDIR /app

# 1) Projektdatei kopieren und NuGet-Pakete wiederherstellen
COPY ["ToDo-App M324/ToDo-App M324.csproj", "ToDo-App M324/"]
RUN dotnet restore "ToDo-App M324/ToDo-App M324.csproj"

# 2) Restlichen Code kopieren und publishen
COPY . .
RUN dotnet publish "ToDo-App M324/ToDo-App M324.csproj" -c Release -o /app/publish

# ---- Runtime-Stufe (NET 8.0 Preview) ----
FROM mcr.microsoft.com/dotnet/runtime:8.0-preview
WORKDIR /app
COPY --from=build-env /app/publish .
ENTRYPOINT ["dotnet", "ToDo-App M324.dll"]
