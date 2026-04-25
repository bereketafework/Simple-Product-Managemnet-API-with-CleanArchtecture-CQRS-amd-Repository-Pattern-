# Simple Product Management API

A simple Product Management API implemented in C# using Clean Architecture, CQRS, Repository Pattern, MediatR and AutoMapper for clean code and maintainable structure.

> Simple Product Management API with Clean Architecture, CQRS and Repository Pattern. Uses MediatR and AutoMapper libraries.

## Features

- CRUD for Products (Create, Read, Update, Delete)
- Clean Architecture separation (API / Application / Domain / Infrastructure)
- CQRS (Commands and Queries) with MediatR
- Repository Pattern for data access
- AutoMapper for DTO <-> Domain mapping

## Technologies

- C# / .NET (project targets .NET - replace with your target framework if different)
- MediatR
- AutoMapper
- (Optional) Entity Framework Core or any other persistence library

## Project Structure

A recommended structure for this solution (may vary slightly in the repository):

- src/
  - Api/                # Web API project (controllers, startup)
  - Application/        # Use cases, commands, queries, DTOs, interfaces
  - Domain/             # Entities, value objects, domain interfaces
  - Infrastructure/     # Data access, repository implementations, EF Core context
  - Common/             # Shared utilities, exceptions, constants

## Getting Started

Prerequisites

- .NET SDK (6.0, 7.0 or later) installed. Check your project file for exact target.
- (Optional) SQL Server, PostgreSQL, or SQLite if using EF Core

Run locally

1. Clone the repository

   git clone https://github.com/bereketafework/Simple-Product-Managemnet-API-with-CleanArchtecture-CQRS-amd-Repository-Pattern-.git
   cd Simple-Product-Managemnet-API-with-CleanArchtecture-CQRS-amd-Repository-Pattern-

2. Restore dependencies and build

   dotnet restore
   dotnet build

3. Run the API

   dotnet run --project src/Api

4. API will be available at https://localhost:5001 or http://localhost:5000 (depending on Kestrel settings)


## Example Endpoints

- GET /api/products          - Get all products
- GET /api/products/{id}     - Get a product by id
- POST /api/products         - Create a new product
- PUT /api/products/{id}     - Update a product
- DELETE /api/products/{id}  - Delete a product

Adjust routes based on controller attributes.

## Architecture Notes

- Commands (write operations) and Queries (read operations) are separated using MediatR. Each command/query has a handler in the Application layer.
- Repositories provide an abstraction over data access and are implemented in the Infrastructure layer.
- AutoMapper is used to map between Domain models and DTOs in the Application layer.

## Tests

If there are test projects, run them with:

   dotnet test

## Contribution

Contributions, issues and feature requests are welcome. Feel free to open a pull request.

## License

This project does not include a license file. Add a license (for example, MIT) if you want to allow others to use your code.

## Contact

Created by bereketafework — feel free to open issues or PRs on GitHub.
