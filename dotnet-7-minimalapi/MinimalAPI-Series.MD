# A Microservices Series - Minimal API in .NET 7

This is a series of video course on the Minimal API in .NET 7. The series is divided into **`18 sessions`**.

---

Season 1

---

## Session 1 - Hands on Minimal API with Static data in .NET 7

> 1. 30,000 foot view of REST, and HTTP
>    - HTTP Methods
>    - HTTP Responses
>    - What should I send as Response
>    - REST (Uniform, Stateless, Cacheable, Layered, Resources, and Self-Descriptive)
> 1. Introduction to .NET Minimal API
> 1. Creating Minimal API using dotnet CLI
>    - `dotnet new list`
>    - Create Minimal API using `dotnet new web`
>    - Create Minimal API using `dotnet new webapi -minimal`
> 1. Create Minimal API using `VS 2022` - Web API Templated - Uncheck Controllers
>    - Executing it using IIS Express / Kestrel Server
>    - Exploring Swagger
> 1. Create Minimal API using `VS 2022` - Web App Empty Template
>    - Executing it using IIS Express / Kestrel Server
> 1. Exposing 4 `Hello World` API Endpoints
> 1. Using Postman to test the API (Environment Variables, and Collections)
> 1. Layered Architecture
> 1. Creating Unified Response Dto, and Constants
> 1. Testing using
>    - Swagger | Postman | Browser Dev Tools

## Session 2 - Hands on to Minimal API with Dynamic data in .NET 7

> 1. Tour of .NET 7 Minimal API Project (Web API, and Web App Empty Template)
> 1. Dependency Injection, and Comparision of Service Collections
>    - Web App Empty
>    - Web API with Uncheck Controllers
>    - Web API with Controllers
> 1. Comparison of HTTP Request Pipeline
> 1. Parameter Binding
>    - From Query | From Route | From Body | From Services
> 1. Base Entity
> 1. Course Entity inheriting Base Entity
> 1. Just enough `Entity Framework` Core (In Memory)
> 1. Dependency Injection of DbContext
> 1. GetAllCourses() API Endpoint
> 1. Seed Data
> 1. Update Postman Collections to test the API (Environment Variables, and Collections)

## Session 3 - .NET 7 Minimal API DI, IOC, record, DTOs, AutoMapper, and Extension Methods

> 1. Create responses in Minimal API
> 1. Dependency Injection and Inversion of Control - Deep Dive
> 1. Enhancing GetAllCourses() API Endpoint to return Unified Response
> 1. Move the Hello World Endpoints into an Extension Class
> 1. Move the User Endpoints into an Extension Class
> 1. Move the Course Endpoints into an Extension Class
> 1. Creating Course Dtos using record
> 1. Auto Mapper Configuration
> 1. Dependency Injection of Auto Mapper
> 1. Enhancing GetAllCourses() API Endpoint to return Course Dtos
> 1. Update Postman Collections to test the API (Environment Variables, and Collections)

## Session 4 - .NET 7 Minimal API Swagger, Repository, Business Layer, and GitHub Actions

> 1. Adding Swagger Dependencies
> 1. WithTags().WithName().Produces(200).ProducesProblem(500);
> 1. Creating Repository Layer
> 1. Creating Business Layer
> 1. Dependency Injection of Swagger, Repository Layer, Business Layer
> 1. Move Service Dependencies into a Extension Class
> 1. Move Http Request Pipeline Dependencies into a Extension Class
> 1. Update Postman Collections to test the API (Environment Variables, and Collections)
> 1. GitHub Actions to build API

## Session 5 - .NET 7 Minimal API Serilog, CORS, Angular 15, and Azure App Service

> 1. Logging using Serilog
> 1. Dependency Injection of CORS
> 1. Angular 15 (SPA with Standalone components) integration with Minimal API Only GetAllCourses() Local API Endpoint
> 1. Deploy Minimal API to Azure App Service using VS 2022
> 1. Angular 15 (SPA with Standalone components) integration with Minimal API Only GetAllCourses() Azure Hosted API Endpoint

---

Season 2

---

## Session 6 - Minimal API in .NET 7

> 1. Adding new GetCourseById() API Endpoint
> 1. Adding New Endpoint AddCourse()
> 1. Docker, Docker Compo
> 1. Terraform IaC
> 1. Web App in Azure (App Service & Docker)
> 1. GitHub Actions

## Session 7 - Minimal API in .NET 7

> 1. To be done

## Session 8 - Authentication and Authorization

> 1. Authentication

## Session 9 - Deploying the entire Microservices solution to Kubernetes

> 1. Moving the Logic into separate Library Project - Sepration of Concerns
> 1. K8s

## Future Sessions

> 1. React 18 SPA integration with Minimal API
> 1. Continer App
> 1. API Gateway using Ocelot
> 1. Client (SPAs) Application Integrations Blazor / Angular 15 / Reactjs
> 1. Blazor WASM  integration with Minimal API
