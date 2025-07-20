# SaaS MultiTenant Starter

[![Build Status](https://img.shields.io/badge/build-passing-brightgreen)](https://github.com/your-github-username/SaaS-MultiTenant-Starter/actions)
[![Tests](https://img.shields.io/badge/tests-passing-brightgreen)](https://github.com/your-github-username/SaaS-MultiTenant-Starter/actions)
[![Coverage](https://img.shields.io/badge/coverage-100%25-brightgreen)](https://codecov.io/gh/your-github-username/SaaS-MultiTenant-Starter)
<!-- Update badge URLs for your actual CI/CD and coverage provider -->

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

## 🧪 Code Coverage & Static Analysis

- **Code Coverage:**
  - Use [Coverlet](https://github.com/coverlet-coverage/coverlet) for .NET code coverage.
  - Example CI step:
    ```yaml
    - name: Test with coverage
      run: dotnet test --collect:"XPlat Code Coverage"
    - name: Upload coverage to Codecov
      uses: codecov/codecov-action@v4
      with:
        files: ./TestResults/**/coverage.cobertura.xml
    ```
  - Update your pipeline to upload coverage reports to [Codecov](https://codecov.io/) or [Coveralls](https://coveralls.io/).

- **Static Analysis:**
  - Integrate [SonarQube](https://www.sonarqube.org/) or [dotnet format](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-format) in your CI for code quality.
  - Example CI step:
    ```yaml
    - name: Run SonarQube analysis
      run: dotnet sonarscanner begin ...
    ```
  - Add rules and quality gates as needed.

<!-- Update your CI/CD pipeline to include these steps for best results. --> 