# .NET 7 - Minimal API with Model Binding, Entity, DI, EF Core, and Seed Data

## Date Time: 05-Feb-2023 at 09:00 AM IST

## Event URL: [https://www.meetup.com/dot-net-learners-house-hyderabad/events/290692815](https://www.meetup.com/dot-net-learners-house-hyderabad/events/290692815)

## YouTube URL: [https://www.youtube.com/watch?v=GxIuDp0d1uE](https://www.youtube.com/watch?v=GxIuDp0d1uE)

![Viswanatha Swamy P K |150x150](./Documentation/Images/ViswanathaSwamyPK.PNG)

---

### Software/Tools

> 1. OS: Windows 10 x64
> 1. .NET 7
> 1. Visual Studio 2022
> 1. Visual Studio Code

### Prior Knowledge

> 1. Programming knowledge in C#
> 1. Azure
> 1. Angular 15
> 1. .NET Razor/Blazor WASM

## Technology Stack

> 1. .NET 7, Azure

## Information

![Information | 100x100](./Documentation/Images/Information.PNG)

## What are we doing today?

> 1. Tour of .NET 7 Minimal API Project (Web API, and Web App Empty Template)
> 1. Dependency Injection
>    - Web App Empty
>    - Web API with Uncheck Controllers
>    - Web API with Controllers
> 1. Comparision on Services & Request Pipeline
> 1. Model Binding
>    - From Query | From Route | From Body
> 1. Base Entity
> 1. Student Entity inheriting Base Entity
> 1. Entity Framework Core (In Memory)
> 1. Dependency Injection of DbContext
> 1. GetAllStudents() API Endpoint
> 1. Seed Data
> 1. Update Postman Collections to test the API (Environment Variables, and Collections)

### Please refer to the [**Source Code**](https://github.com/vishipayyallore/learn-azure-in-2022) of today's session for more details

---

![Information | 100x100](./Documentation/Images/SeatBelt.PNG)

---

## 1. 30,000 foot view of HTTP, and REST

> 1. Discussion and Demo

**References:**

> 1. [https://rapidapi.com/blog/rest-api-vs-web-api](https://rapidapi.com/blog/rest-api-vs-web-api)
> 1. [https://www.guru99.com/api-vs-web-service-difference.html#:~:text=Web%20service%20is%20used%20for,APIs%20are%20not%20web%20services.](https://www.guru99.com/api-vs-web-service-difference.html#:~:text=Web%20service%20is%20used%20for,APIs%20are%20not%20web%20services.)
> 1. [https://developer.mozilla.org/en-US/docs/Web/HTTP/Methods](https://developer.mozilla.org/en-US/docs/Web/HTTP/Methods)
> 1. [https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/200](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/200)
> 1. [https://developer.mozilla.org/en-US/docs/Web/HTTP/Methods/PUT](https://developer.mozilla.org/en-US/docs/Web/HTTP/Methods/PUT)

### HTTP Methods

> 1. Discussion and Demo

### HTTP Responses

> 1. Discussion and Demo

### What should I send as Response

> 1. Discussion and Demo

### REST (Uniform, Stateless, Cacheable, Layered, Resources, and Self-Descriptive)

> 1. Discussion and Demo

**References:**

> 1. [https://en.wikipedia.org/wiki/Representational_state_transfer](https://en.wikipedia.org/wiki/Representational_state_transfer)

## 2. Introduction to .NET Minimal API

> 1. Discussion and Demo

**References:**

> 1. [https://learn.microsoft.com/en-us/aspnet/core/fundamentals/minimal-apis/overview?view=aspnetcore-7.0](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/minimal-apis/overview?view=aspnetcore-7.0)

## 3. Creating Minimal API using dotnet CLI

> 1. Discussion and Demo

```dotnetcli
dotnet new list
```

![Dotnet New List | 100x100](./Documentation/Images/DotnetNewList.PNG)

### Create Minimal API using `dotnet new web`

> 1. Discussion and Demo
> 1. Executing it using dotnet CLI / VS Code
> 1. Debugging in VS Code

```dotnetcli
dotnet new web -o firstsample --dry-run
dotnet run -lp https
```

![Dotnet New Web | 100x100](./Documentation/Images/DotNetNew_CLI_1.PNG)

### Create Minimal API using `dotnet new webapi -minimal`

> 1. Discussion and Demo
> 1. Executing it using dotnet CLI / VS Code
> 1. Debugging in VS Code

```dotnetcli
dotnet new webapi -minimal -o secondsample --dry-run
dotnet run -lp https
```

![Dotnet New WebApi | 100x100](./Documentation/Images/DotNetNew_CLI_2.PNG)

## 4. Create Minimal API using `VS 2022` - Web API Template - UnCheck Controllers

> 1. Discussion and Demo

### Executing it using IIS Express / Kestrel Server

> 1. Discussion and Demo

### Exploring Swagger

> 1. Discussion and Demo.

![Web Api Template | 100x100](./Documentation/Images/WebAPITemplate.PNG)

## 5. Create Minimal API using `VS 2022` - Web App Empty Template

> 1. Discussion and Demo

### Executing it using IIS Express, and Kestrel Server (http, https)

> 1. Discussion and Demo.

![Web App Empty Template | 100x100](./Documentation/Images/WebAppEmptyTemplate.PNG)

## 6. Exposing `4 Basic` API Endpoints

> 1. Discussion and Demo

## 7. Using Postman to test the API (Environment Variables, and Collections)

> 1. Discussion and Demo

## 8. Layered Architecture

> 1. Discussion and Demo

## 9. Creating Unified Response Dto, and Constants

> 1. Discussion and Demo

## 10. Testing using - Swagger, Postman, and Browser Dev Tools

> 1. Discussion and Demo

---

## SUMMARY / RECAP / Q&A

> 1. SUMMARY / RECAP / Q&A
> 2. Any open queries, I will get back through meetup chat/twitter.

---

## What is Next? session `2` of `9` Sessions on 05 Feb, 2023

> 1. Tour of .NET 7 Minimal API Project (Web API, and Web App Empty Template)
> 1. Dependency Injection
>    - Web App Empty
>    - Web API with UnCheck Controllers
>    - Web API with Controllers
> 1. Logging using Serilog
> 1. Base Entity, and Inherit other Entities
> 1. Student Entity
> 1. Entity Framework Core (In Memory)
> 1. Dependency Injection of DbContext
> 1. GetAllStudents(), AddStudent() API Endpoints
> 1. Update Postman Collections to test the API (Environment Variables, and Collections)
