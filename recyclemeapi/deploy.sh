dotnet publish -c Release

cp dockerfile ./bin/release/netcoreapp2.1/publish

docker build -t recyclemeimage ./bin/release/netcoreapp2.1/publish

docker tag recyclemeimage  registry.heroku.com/recyclemepinellas/web

docker push registry.heroku.com/recyclemepinellas/web

heroku container:release web -a recyclemepinellas