FROM mcr.microsoft.com/dotnet/sdk:5.0.406 AS build
WORKDIR /app
COPY RestApi/*.csproj ./RestApi/
COPY Contracts/*.csproj ./Contracts/
COPY Entities/*.csproj ./Entities/
COPY LoggerService/*.csproj ./LoggerService/
COPY Repository/*.csproj ./Repository/
COPY Service/*.csproj ./Service/

WORKDIR /app/RestApi
RUN dotnet restore
WORKDIR /app

COPY RestApi/. ./RestApi/
COPY Contracts/. ./Contracts/
COPY Entities/. ./Entities/ 
COPY LoggerService/. ./LoggerService/
COPY Repository/. ./Repository/ 
COPY Service/. ./Service/ 

#
WORKDIR /app/RestApi
RUN dotnet publish -c Release -o out 
#
FROM mcr.microsoft.com/dotnet/aspnet:5.0.15 AS runtime
WORKDIR /app 
# RUN mkdir Resources
COPY --from=build /app/RestApi/Resources/. ./Resources
#
COPY --from=build /app/RestApi/out ./
ENTRYPOINT ["dotnet", "RestApi.dll"]