*CliniDesk*

Sistema de autenticación y gestión de usuarios para consultorios psicológicos desarrollado con .NET 8, ASP.NET Core Web API y arquitectura en capas.

*Tecnologías utilizadas*
- .NET 8
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- JWT Authentication
- BCrypt Password Hashing
- Swagger / OpenAPI
- Dependency Injection

*Arquitectura*
El proyecto está organizado utilizando arquitectura en capas para separar responsabilidades:

- CliniDesk.API
- CliniDesk.Business
- CliniDesk.Data
- CliniDesk.Entity
- CliniDesk.Security
- CliniDesk.UI

*Funcionalidades implementadas*
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

*Objetivo del proyecto*

El objetivo de CliniDesk es construir una base sólida para un sistema de gestión orientado a consultorios psicológicos, aplicando buenas prácticas de backend, seguridad y organización profesional del código.
