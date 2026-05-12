# CliniDesk

User authentication and management system for psychological practices developed with .NET 8 and ASP.NET Core Web API, applying layered architecture, JWT authentication, authorization via tokens, Entity Framework Core, SQL Server, dependency injection, secure password hashing with BCrypt, global middleware for centralized exception handling and endpoint documentation using Swagger/OpenAPI.

## Tecnologías utilizadas
- .NET 8
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- JWT Authentication
- BCrypt Password Hashing
- Swagger / OpenAPI
- Dependency Injection

## Arquitectura
El proyecto está organizado utilizando arquitectura en capas para separar responsabilidades:

- CliniDesk.API
- CliniDesk.Business
- CliniDesk.Data
- CliniDesk.Entity
- CliniDesk.Security
- CliniDesk.UI

## Funcionalidades implementadas
- Registro de usuarios
- Login con autenticación JWT
- Generación y validación de tokens
- Protección de endpoints mediante [Authorize]
- Hash seguro de contraseñas con BCrypt
- Middleware global para manejo centralizado de excepciones
- Respuestas HTTP personalizadas
- Persistencia de usuarios en SQL Server
- Repositorios y servicios desacoplados mediante inyección de dependencias
- Documentación y pruebas de endpoints con Swagger

## Objetivo del proyecto

El objetivo de CliniDesk es construir una base sólida para un sistema de gestión orientado a consultorios psicológicos, aplicando buenas prácticas de backend, seguridad y organización profesional del código.
