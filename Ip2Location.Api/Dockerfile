FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY Ip2Location.Api/Ip2Location.Api.csproj Ip2Location.Api/
RUN dotnet --version
RUN dotnet restore Ip2Location.Api/Ip2Location.Api.csproj
COPY . .
WORKDIR /src/Ip2Location.Api
RUN dotnet build Ip2Location.Api.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Ip2Location.Api.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
RUN dotnet --info

ENTRYPOINT ["dotnet", "Ip2Location.Api.dll"]
