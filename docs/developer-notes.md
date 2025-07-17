# Developer Notes

## Local Development
- Uses EF Core InMemory by default for fast prototyping.
- To use SQL Server, update `AppDbContext` and connection string in `Program.cs`.

## Extending
- Add new entities to Core/Entities, update DbContext, and create new repositories/services as needed.
- Use dependency injection for all services and repositories.

## Testing
- Add xUnit tests in `tests/`.
- Mock repositories for unit tests or use InMemory provider for integration tests. 