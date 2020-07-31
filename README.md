# ASP.NET Core Versioning Demo

This simple demo shows using `Microsoft.AspNetCore.Mvc.Versioning` ([tutorial](https://github.com/Microsoft/aspnet-api-versioning/wiki/New-Services-Quick-Start)) with ASP.NET Core to support multiple versions of an API.

## Swagger
It also uses [Swashbuckle](https://github.com/domaindrivendev/Swashbuckle.AspNetCore) (following [this tutorial](https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-3.1&tabs=netcore-cli)) to provide documentation, which is accessible at `https://localhost:5001/swagger`

Ensuring that the swagger documentation correctly integrates with the versioning is a little more complex. This example follows the approach of [this sample app](https://github.com/microsoft/aspnet-api-versioning/tree/master/samples/aspnetcore/SwaggerSample) and docs [here](https://github.com/Microsoft/aspnet-api-versioning/wiki/Swashbuckle-Integration).

## Building and running
Build and run with `dotnet run`. Access v1 endpoint at `https://localhost:5001/weatherforecast`, and v2 at `https://localhost:5001/weatherforecast?api-version=2.0`