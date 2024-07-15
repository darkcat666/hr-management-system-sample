FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["HRManagementSystem.csproj", "./"]
RUN dotnet restore "HRManagementSystem.csproj"
COPY . .
RUN dotnet build "HRManagementSystem.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HRManagementSystem.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HRManagementSystem.dll"]