#Build Stage
FROM mcr.microsoft.com/dotnet/sdk:8.0-jammy AS build
WORKDIR /source
COPY . .
RUN dotnet restore "./CloudCustomers.API/CloudCustomers.API.csproj" --disable-parallel
RUN dotnet publish "./CloudCustomers.API/CloudCustomers.API.csproj" -c release -o /app --no-restore

#Serve Stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0-jammy-chiseled
WORKDIR /app
COPY --from=build /app ./

EXPOSE 5000

ENTRYPOINT ["dotnet", "CloudCustomers.API.dll"]