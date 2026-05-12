# CliniDesk

User authentication and management system for psychological practices developed with .NET 8 and ASP.NET Core Web API, applying layered architecture, JWT authentication, authorization via tokens, Entity Framework Core, SQL Server, dependency injection, secure password hashing with BCrypt, global middleware for centralized exception handling and endpoint documentation using Swagger/OpenAPI.

## Technologies used
- .NET 8
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- JWT Authentication
- BCrypt Password Hashing
- Swagger / OpenAPI
- Dependency Injection

## Architecture
The project is organized using a layered architecture to separate responsibilities:

- CliniDesk.API
- CliniDesk.Business
- CliniDesk.Data
- CliniDesk.Entity
- CliniDesk.Security
- CliniDesk.UI

## Implemented functionalities
- User registration
- Login with JWT authentication
- Token generation and validation
- Endpoint protection using [Authorize]
- Secure password hashing with BCrypt
- Global middleware for centralized exception handling
- Custom HTTP responses
- User persistence in SQL Server
- Decoupled repositories and services using dependency injection
- Endpoint documentation and testing with Swagger

## Project objective
The goal of CliniDesk is to build a solid foundation for a management system geared towards psychological practices, applying good backend practices, security, and professional code organization.
