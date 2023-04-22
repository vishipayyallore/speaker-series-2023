# .NET 7 on AWS - Dockerfile Deep Dive, and Containerize .NET 7 and Angular 15 App

## Date Time: 23-Aar-2023 at 09:00 AM IST

## Event URL: [https://www.meetup.com/dot-net-learners-house-hyderabad/events/292399294](https://www.meetup.com/dot-net-learners-house-hyderabad/events/292399294)

## YouTube URL: [https://www.youtube.com/watch?v=85my3e6IxRU](https://www.youtube.com/watch?v=85my3e6IxRU)

![Viswanatha Swamy P K |150x150](./Documentation/Images/ViswanathaSwamyPK.PNG)

---

### Software/Tools

> 1. OS: Windows 10 x64
> 1. .NET 7
> 1. Visual Studio 2022
> 1. Visual Studio Code

### Prior Knowledge

> 1. Programming knowledge in C#
> 1. Azure / AWS
> 1. Angular 15
> 1. .NET Razor/Blazor WASM

## Technology Stack

> 1. .NET 7, AWS

## Information

![Information | 100x100](./Documentation/Images/Information.PNG)

## What are we doing today?

> 1. Quick Recap of the `previous sessions`
>    - [https://www.youtube.com/watch?v=Ydd8FQvHr3Q](https://www.youtube.com/watch?v=Ydd8FQvHr3Q)
>    - [https://www.youtube.com/watch?v=2QUHjKsFhYA](https://www.youtube.com/watch?v=2QUHjKsFhYA)
>    - [https://www.youtube.com/watch?v=a8GdSOASGps](https://www.youtube.com/watch?v=a8GdSOASGps)
> 1. Dockerfile Deep Dive
>    - Simple Dockerfile
>    - Multi Stage Dockerfile
> 1. Tools to create Dockerfile
>    - Manual
>    - VS Code Extension
>    - VS 2022
> 1. Dockerizing .NET Web API
> 1. Dockerizing Angular 15 SPA
> 1. Deploying Angular 15 SPA to AWS ECS using Fargate
> 1. SUMMARY / RECAP / Q&A
> 1. What is next ?

### Please refer to the [**Source Code**](https://github.com/vishipayyallore/speaker-series-2023/tree/main/dotnet-6-on-aws/Fargate_ECS_S4) of today's session for more details

---

![Information | 100x100](./Documentation/Images/SeatBelt.PNG)

---

## 1. Quick Recap of the `previous sessions`

> 1. [https://www.youtube.com/watch?v=Ydd8FQvHr3Q](https://www.youtube.com/watch?v=Ydd8FQvHr3Q)
> 1. [https://www.youtube.com/watch?v=2QUHjKsFhYA](https://www.youtube.com/watch?v=2QUHjKsFhYA)
> 1. [https://www.youtube.com/watch?v=a8GdSOASGps](https://www.youtube.com/watch?v=a8GdSOASGps)

**Hint:**

> 1. Volume Mount Path [\\wsl$\docker-desktop-data\data\docker\volumes](\\wsl$\docker-desktop-data\data\docker\volumes)

## 2. Dockerfile Deep Dive

> 1. Demo and Hands-on

### Simple Dockerfile

```dockerfile
# Use an official NGINX image as the base image
FROM nginx

# Copy the static files into the NGINX image
COPY ./www /usr/share/nginx/html

# Copy the NGINX configuration file into the NGINX image
COPY ./nginx.conf /etc/nginx/nginx.conf

# Expose port 80 for incoming traffic
EXPOSE 80

# Start NGINX when the container is run
CMD ["nginx", "-g", "daemon off;"]
```

### Multi Stage Dockerfile

```dockerfile
### STAGE 1: Build ###
FROM node:lts-alpine AS build
WORKDIR /usr/src/app
COPY package.json package-lock.json ./
RUN npm cache clean --force
RUN npm install
COPY . .
RUN npm run build

### STAGE 2: Run ###
FROM nginx:alpine
# Copy the NGINX configuration file into the NGINX image
COPY ./nginx.conf /etc/nginx/nginx.conf
# Expose port 80 for incoming traffic
EXPOSE 80
COPY --from=build /usr/src/app/dist/products-web /usr/share/nginx/html
```

> 1. Tools to create Dockerfile
>    - Manual
>    - VS Code Extension
>    - VS 2022
> 1. Dockerizing .NET Web API
> 1. Dockerizing Angular 15 SPA
> 1. Deploying Angular 15 SPA to AWS ECS using Fargate

## 3. Deploying MS SQL Server on AWS ECS using Fargate

> 1. Demo and Hands-on

### Create Container, Task Definition, and Service on AWS ECS using AWS Console

> 1. Demo and Hands-on

![Container, Task Definition, and Service on AWS ECS | 100x100](./Documentation/Images/AWS_ECS_Cluster.PNG)

### Connecting to MS SQL Server 2022 hosted on AWS ECS using Azure Data Studio

> 1. Demo and Hands-on

```bash
Server=YourIPAddress;Database=master;User Id=sa;Password=YourStrongPassword;Encrypt=True;TrustServerCertificate=True;
```

![Connecting To MS SQL Server On AWS ECS | 100x100](./Documentation/Images/ConnectingToMSSQLServerOn_AWS_ECS.PNG)

### Creating Database, Table, and Data on MS SQL Server 2022 using Azure Data Studio

> 1. Demo and Hands-on

```sql
CREATE DATABASE School
GO

SELECT Name FROM sys.databases
GO

USE School
GO

CREATE TABLE Students (ID INT, DOJ DATETIME2, Name VARCHAR(100));
GO

SELECT * FROM Students
GO

INSERT INTO Students VALUES (1, DATEADD(hh, -1, GETDATE()), 'Sri Varu');
INSERT INTO Students VALUES (2, DATEADD(hh, -2, GETDATE()), 'AAA');
GO

SELECT * FROM Students
GO
```

![Creating Database, Table, and Data on MS SQL Server 2022 | 100x100](./Documentation/Images/CreateDatabaseTableData_DataStudio.PNG)

### Accessing MS SQL Server 2022 from AWS ECS

![Accessing MS SQL Server 2022 from AWS ECS | 100x100](./Documentation/Images/MSSQLServer_2022_On_AWS_ECS.PNG)

---

## SUMMARY / RECAP / Q&A

> 1. SUMMARY / RECAP / Q&A
> 2. Any open queries, I will get back through meetup chat/twitter.

---

## What is Next? session?

> 1. Deep dive into Dockerfile
> 1. Hands-on with Dockerize Angular 15 Single Page Application
> 1. Pushing it to Docker Hub
> 1. Hands-on with Fargate/ECS using Angular 15 SPA Docker Image on AWS Console
> 1. Working with Multi Container in ECS using Fargate (`Microservices`)
