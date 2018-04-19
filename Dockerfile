FROM microsoft/dotnet:2.0-sdk
WORKDIR /app

COPY *.csproj ./
RUN dotnet restore

COPY . ./

EXPOSE 5000

RUN dotnet publish -c Release -o out
ENTRYPOINT [ "dotnet", "out/dotnetcore-docker-sample.dll" ]
