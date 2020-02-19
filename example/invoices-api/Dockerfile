FROM registry.redhat.io/rhel8/dotnet-21 as build
USER root
WORKDIR /app
COPY . .
RUN dotnet restore
RUN dotnet publish -c Release -o dist

FROM registry.redhat.io/rhel8/dotnet-21-runtime as runtime
WORKDIR /app
COPY --from=build /app/dist ./
ENTRYPOINT ["dotnet", "app.dll"]
