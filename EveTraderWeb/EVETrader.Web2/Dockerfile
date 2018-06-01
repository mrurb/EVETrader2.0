FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-1709 AS base
WORKDIR /app
EXPOSE 59082
EXPOSE 44380

FROM microsoft/dotnet:2.1-sdk-nanoserver-1709 AS build
WORKDIR /src
COPY EVETrader.Web2/EVETrader.Web2.csproj EVETrader.Web2/
RUN dotnet restore EVETrader.Web2/EVETrader.Web2.csproj
COPY . .
WORKDIR /src/EVETrader.Web2
RUN dotnet build EVETrader.Web2.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish EVETrader.Web2.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "EVETrader.Web2.dll"]
