FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS publish
WORKDIR /src
COPY . .
RUN dotnet restore "Core.API/Core.API.csproj"
COPY . .
WORKDIR /src/Core.API
RUN dotnet publish "Core.API.csproj" -c Release -o /app

FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim
EXPOSE 5000
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Core.API.dll"]