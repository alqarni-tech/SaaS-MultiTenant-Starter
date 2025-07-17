# API Specification

## Tenants
- `GET /api/tenant` — List all tenants
- `GET /api/tenant/{id}` — Get tenant by ID
- `POST /api/tenant` — Create tenant
- `PUT /api/tenant/{id}` — Update tenant
- `DELETE /api/tenant/{id}` — Delete tenant

## Users
- `GET /api/user/tenant/{tenantId}` — List users by tenant
- `GET /api/user/{id}` — Get user by ID
- `POST /api/user` — Create user
- `PUT /api/user/{id}` — Update user
- `DELETE /api/user/{id}` — Delete user

## Example Request
```http
POST /api/tenant
Content-Type: application/json
{
  "name": "Acme Inc",
  "connectionString": "Server=...;Database=...;..."
}
``` 