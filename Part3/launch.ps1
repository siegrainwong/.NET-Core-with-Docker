docker-compose up -d

docker run --rm -it `
	-v F:\Projects\docker-netcore\Part3:/app/ `
	-v F:\Projects\docker-netcore\Part3\Core.API\appsettings.docker.json:/app/Core.API/appsettings.Development.json:ro `
	-p 5000:5000 `
	--link sw-oap `
	--link sqlserver `
	--name coreapi_dev `
	--network part3_default `
	--env ASPNETCORE_HOSTINGSTARTUPASSEMBLIES=SkyAPM.Agent.AspNetCore `
	--env SKYWALKING__SERVICENAME=coreapi `
 	-w /app/Core.API mcr.microsoft.com/dotnet/core/sdk:2.2-stretch dotnet watch run