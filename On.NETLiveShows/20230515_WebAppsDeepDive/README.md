# Deep Dive into Azure Web Apps with .NET 7 and Angular in On .NET Live

## Date Time: 15-May-2023 at 09:30 PM IST

## YouTube URL: [https://www.youtube.com/watch?v=RF63hmk1pw8](https://www.youtube.com/watch?v=RF63hmk1pw8)

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

> 1. Empty Web App and hosting html
> 1. App Service plan, Wild card
> 1. Static Site
> 1. Minimal API
> 1. Angular 15 (SPA with Standalone components) integration with Minimal API Only GetAllCourses() Local API Endpoint
> 1. .NET Web API with SQL Server
> 1. Deployments to Azure Web App
>    1. Couple of the Manual Deployment Options
>        1. Visual Studio Code
>        1. Visual Studio 2022
>    1. Couple of the Automated Deployment Options
>        1. GitHub Actions
>        1. Azure DevOps
> 1. CI/CD feature of Web Application
> 1. GitHub Actions to build API

### Please refer to the [**Source Code**](https://github.com/Microservices-for-Small-School-App/services-school) of today's session for more details

---

![Information | 100x100](./Documentation/Images/SeatBelt.PNG)

---

## 1. Create a static HTML web app by using Azure Cloud Shell / Terminal

> 1. Discussion and Demo
> 1. Walk through of the Html App
> 1. Login using `az login`
> 1. Verify the account `az account show -o table`
> 1. Execute the `az webapp up`

URL: [https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest#az_webapp_up](https://docs.microsoft.com/en-us/cli/azure/webapp?view=azure-cli-latest#az_webapp_up)

```bash
az login

az account show -o table

az webapp list-runtimes

az appservice plan create --name plan-simplesite15may2023 --resource-group rg-on-dotnet-dev-001 --location eastus --sku F1
az webapp up --location eastus --name app-simplesite15may2023 --resource-group rg-on-dotnet-dev-001 --plan plan-simplesite15may2023 --html

az webapp up --location EastUs --resource-group rg-on-dotnet-dev-001 --html
az webapp up --location EastUs --name app-hellohtml03102022 --resource-group rg-on-dotnet-dev-001 --runtime "dotnet:6"
```

## 2. Deploy .NET 6 Web API with SQL Server, Redis Cache and Azure Key Vault

> 1. Discussion and Demo
> 1. Cache Aside Pattern
> 1. Azure Key Vault
> 1. Azure SQL Server
> 1. Azure Redis Cache
> 1. Application Insights
> 1. Debugging Logs / Event Viewer

## 3. Deploy .NET 7 Minimal API

> 1. Discussion and Demo

## 4. Deploy Angular 15 Application

> 1. Discussion and Demo

## 5. Deploying Multi Containers in App Service using Docker Compose

> 1. Discussion and Demo
> 1. .NET 6 Web API
> 1. MongoDB
> 1. Containerize the .NET 6 Web API
> 1. Deploy using Docker Compose

---

## SUMMARY / RECAP / Q&A

> 1. SUMMARY / RECAP / Q&A
> 2. Any open queries, I will get back through meetup chat/twitter.

---
