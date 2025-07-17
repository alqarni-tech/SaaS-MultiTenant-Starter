# SaaS MultiTenant Starter

## Project Overview
A production-ready multi-tenant SaaS starter kit built with ASP.NET Core 8, Clean Architecture, and Entity Framework Core. Supports tenant onboarding, user management, and is ready for cloud deployment.

## Features
- Multi-tenant support (schema-per-tenant or shared DB)
- Tenant onboarding API
- User management API
- Clean architecture layering
- Swagger/OpenAPI documentation
- JWT authentication-ready
- SOLID principles

## Technologies Used
- ASP.NET Core 8
- Entity Framework Core 8 (InMemory/SQL ready)
- Clean Architecture
- xUnit (for tests)
- Swagger/OpenAPI

## Setup Instructions
```sh
cd SaaS-Starter-Solutions/SaaS-MultiTenant-Starter
# Build
 dotnet build SaaS-MultiTenant-Starter.sln
# Run API
 dotnet run --project src/SaaS.MultiTenant.API/SaaS.MultiTenant.API.csproj
```

## API Documentation
Swagger UI: `/swagger`

## CI/CD
See `ci/` folder for GitHub Actions pipeline.

## Documentation
- [Architecture](docs/architecture.md)
- [API Spec](docs/api-spec.md)
- [Developer Notes](docs/developer-notes.md) 

## Health Checks
- `/health` returns 200 OK if the service is healthy.

## Docker
```sh
docker build -t saas-multitenant-api .
docker run -p 5292:80 saas-multitenant-api
```

## Exception Handling
- All unhandled exceptions return a ProblemDetails response at `/error`. 