FROM microsoft/dotnet:2.0-runtime
WORKDIR /app
ENTRYPOINT ["dotnet", "silo.dll"]
COPY . /app