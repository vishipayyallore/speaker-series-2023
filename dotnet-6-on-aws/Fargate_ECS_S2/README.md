# .NET 6 on AWS - Creating Docker Images, Deploying to ECS using Fargate

## Date Time: 12-Feb-2023 at 09:00 AM IST

## Event URL: [https://www.meetup.com/dot-net-learners-house-hyderabad/events/291262858](https://www.meetup.com/dot-net-learners-house-hyderabad/events/291262858)

## YouTube URL: [https://www.youtube.com/watch?v=2QUHjKsFhYA](https://www.youtube.com/watch?v=2QUHjKsFhYA)

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

> 1. .NET 6/7, AWS

## Information

![Information | 100x100](./Documentation/Images/Information.PNG)

## What are we doing today?

> 1. Quick Recap of the [previous session](https://www.youtube.com/watch?v=Ydd8FQvHr3Q)
> 1. Hands-on with Dockerize Static Web Site
>    - Build and Push the Docker Image to Docker Hub
>    - Execute Docker Image from Docker Hub on Local Machine
> 1. Hands-on with Fargate/ECS using Static Web Site Docker Image on AWS Console
> 1. SUMMARY / RECAP / Q&A
> 1. What is next ?

### Please refer to the [**Source Code**](https://github.com/vishipayyallore/speaker-series-2023/tree/main/dotnet-6-on-aws/Fargate_ECS_S1) of today's session for more details

---

![Information | 100x100](./Documentation/Images/SeatBelt.PNG)

---

## 1. Quick Recap of the [previous session](https://www.youtube.com/watch?v=Ydd8FQvHr3Q)

> 1. Discussion and Demo

## 2. Hands-on with Dockerize Static Web Site

> 1. Discussion and Demo

**Reference(s):**

> 1. [https://www.nginx.com/resources/wiki/start/topics/examples/full/](https://www.nginx.com/resources/wiki/start/topics/examples/full/)

### 2.1. Build and Push the Docker Image to Docker Hub

```dockercmd
TAG=latest
VERSION_TAG=$(git log -1 --pretty=format:%h)
echo "version tag: $VERSION_TAG"

REPOSITORY=vishipayyallore/static-website

docker login

docker build -t $REPOSITORY:$TAG -t $REPOSITORY:$VERSION_TAG .

docker push $REPOSITORY:$TAG
docker push $REPOSITORY:$VERSION_TAG
```

![Build And Push Static Web Site | 100x100](./Documentation/Images/BuildAndPushStaticWebSite.PNG)

### 2.2. Execute Docker Image from Docker Hub on Local Machine

```dockercmd
docker run -d --rm --name static-website-12feb -p 8009:80 vishipayyallore/static-website:latest
```

![Static Web Site in local docker | 100x100](./Documentation/Images/BuildAndPushStaticWebSite_1.PNG)

## 3. Hands-on with Fargate/ECS using Static Web Site Docker Image on AWS Console

> 1. Discussion and Demo

![Static Web Site in AWS ECS | 100x100](./Documentation/Images/BuildAndPushStaticWebSite_2.PNG)

## 4. Hands-on with Dockerize Angular 15 Single Page Application

> 1. Discussion and Demo

## 5. Hands-on with Fargate/ECS using Angular 15 SPA Docker Image on AWS Console

> 1. Discussion and Demo

## 6. Hands-on with Dockerize .NET 7 Minimal API

> 1. Discussion and Demo

**Path:** [C:\LordKrishna\GitHub\services-school](C:\LordKrishna\GitHub\services-school)

### 6.1. Build and Push the Docker Image to Docker Hub

```dockercmd
TAG=latest
VERSION_TAG=$(git log -1 --pretty=format:%h)
echo "version tag: $VERSION_TAG"

# The name of the repository on Docker Hub should be in lowercase
REPOSITORY=vishipayyallore/school-api

docker login

docker build -t $REPOSITORY:$TAG -t $REPOSITORY:$VERSION_TAG -f Source/School.Api/Dockerfile .

docker push $REPOSITORY:$TAG
docker push $REPOSITORY:$VERSION_TAG
```

![Build And Push .NET 7 Minimal API | 100x100](./Documentation/Images/BuildAndPush_NET7MinimalAPI.PNG)

### 6.2. Execute Docker Image from Docker Hub on Local Machine

```dockercmd
docker run -d --rm --name School-Api-12feb -p 8010:80 vishipayyallore/school-api:latest
```

![Execute .NET 7 Minimal API Docker Image| 100x100](./Documentation/Images/BuildAndPush_NET7MinimalAPI_1.PNG)

## 7. Hands-on with Fargate/ECS using Static Web Site Docker Image on AWS Console

> 1. Discussion and Demo

---

## SUMMARY / RECAP / Q&A

> 1. SUMMARY / RECAP / Q&A
> 2. Any open queries, I will get back through meetup chat/twitter.

---

## What is Next? session?

> 1. Creating our own Docker Image
> 1. Pushing it to Docker Hub
> 1. Working with FarGate and ECS
