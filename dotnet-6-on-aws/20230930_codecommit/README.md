# Hands-on with AWS - Code Commit - .NET 8 / Java Spring Boot

## Date Time: 30-Sep-2023 at 09:00 AM IST

## Event URL: [https://www.meetup.com/dot-net-learners-house-hyderabad/events/295456967](https://www.meetup.com/dot-net-learners-house-hyderabad/events/295456967)

## YouTube URL: [https://www.youtube.com/watch?v=h6l1GoE8qfw](https://www.youtube.com/watch?v=h6l1GoE8qfw)

![Viswanatha Swamy P K |150x150](./Documentation/Images/ViswanathaSwamyPK.PNG)

---

### Software/Tools

> 1. OS: Windows 10 x64
> 1. .NET 8
> 1. Visual Studio 2022
> 1. Visual Studio Code

### Prior Knowledge

> 1. AWS
> 1. Basic Programming knowledge in C#
> 1. Basic Programming knowledge in Java
> 1. Basic Programming knowledge in Java Spring Boot

## Technology Stack

> 1. .NET 8, AWS

## Information

![Information | 100x100](./Documentation/Images/Information.PNG)

## What are we doing today?

> 1. To be decided
> 1. SUMMARY / RECAP / Q&A
> 1. What is next ?

### Please refer to the [**Source Code**](https://github.com/vishipayyallore/speaker-series-2023/tree/main/dotnet-6-on-aws/20230930_codecommit) of today's session for more details

---

![Information | 100x100](./Documentation/Images/SeatBelt.PNG)

---

## 1. Generate Git Credentials for AWS Code Commit

> 1. Discussion and Demo
> 1. These credentials are required to clone the repositories from AWS Code Commit to local machine

![AWS Code Commit GIT Credentials | 100x100](./Documentation/Images/AWSCC_GitCredentials_1.PNG)

![AWS Code Commit GIT Credentials | 100x100](./Documentation/Images/AWSCC_GitCredentials_2.PNG)

## 2. Create two repositories in AWS Code Commit

> 1. Discussion and Demo
> 1. One repository for Java Spring Boot
> 1. One repository for .NET 8

![AWS Code Commit Repository | 100x100](./Documentation/Images/AWSCC_Repository_1.PNG)

![AWS Code Commit Repository | 100x100](./Documentation/Images/AWSCC_Repository_2.PNG)

## 3. Clone the repositories to local machine

> 1. Clone the repositories to local machine
> 1. You **need to use the GIT credentials generated in the previous step** to clone the repositories

```bash
git clone https://git-codecommit.us-west-2.amazonaws.com/v1/repos/shirtsshop-api

git clone https://git-codecommit.us-west-2.amazonaws.com/v1/repos/greetings-api
```

![AWS Code Commit Repository | 100x100](./Documentation/Images/AWSCC_Repository_3.PNG)

## 4. Creating simple Web Api using Java Spring Boot

> 1. Discussion and Demo
> 1. Navigate to [https://start.spring.io](https://start.spring.io)
> 1. Select the following options shown in the image below and click on **Generate**
> 1. This will download a zip file to your local machine

![Java Spring Boot Web API | 100x100](./Documentation/Images/JavaSpringBoot_WebAPI_1.PNG)

> 1. Extract the zip file to a folder where the repository is cloned
> 1. Open the folder in Visual Studio Code
> 1. Open the **pom.xml** file and add the following dependency for [lombok](https://projectlombok.org/setup/maven)

```xml
<dependency>
    <groupId>org.projectlombok</groupId>
    <artifactId>lombok</artifactId>
    <version>1.18.30</version>
    <scope>provided</scope>
</dependency>
```

> 1. Update the application.properties file with the following content

```properties
logging.level.org.springframework.web.*=TRACE

server.port=8083
```

> 1. Execute the Application class to start the application

![Java Spring Boot Web API | 100x100](./Documentation/Images/JavaSpringBoot_WebAPI_2.PNG)

> 1. Periodically push the changes to the repository

```bash
git status
git add .
git commit -am "Message"
git push
```

![Java Spring Boot Web API | 100x100](./Documentation/Images/JavaSpringBoot_WebAPI_3.PNG)

## 5. Added a greeting controller and DTO

> 1. Discussion and Demo
> 1. Create a `GreetingsResponseDto` DTO, and `GreetingsController` controller

![Java Spring Boot Web API | 100x100](./Documentation/Images/JavaSpringBoot_WebAPI_4.PNG)

> 1. Execute the Application class to start the application
> 1. Verify the application is running by navigating to [http://localhost:8083/api/v1/greetings](http://localhost:8083/api/v1/greetings)

![Java Spring Boot Web API | 100x100](./Documentation/Images/JavaSpringBoot_WebAPI_5.PNG)

## 6. View Commit History in AWS Code Commit

> 1. Discussion and Demo

![Java Spring Boot Web API | 100x100](./Documentation/Images/Commit_History.PNG)

## 7. Create a Branch in AWS Code Commit

> 1. Discussion and Demo

![Java Spring Boot Web API | 100x100](./Documentation/Images/NewBranch_1.PNG)

![Java Spring Boot Web API | 100x100](./Documentation/Images/NewBranch_2.PNG)

## 8. Create a Pull Request in AWS Code Commit

> 1. Discussion and Demo

![Java Spring Boot Web API | 100x100](./Documentation/Images/PullRequest_1.PNG)

## 9. Merge the Pull Request in AWS Code Commit

> 1. Discussion and Demo

![Java Spring Boot Web API | 100x100](./Documentation/Images/MergePullRequest_1.PNG)

---

## SUMMARY / RECAP / Q&A

> 1. SUMMARY / RECAP / Q&A
> 2. Any open queries, I will get back through meetup chat/twitter.

---

## What is Next? session?

> 1. To be decided
> 1. SUMMARY / RECAP / Q&A
> 1. Any open queries, I will get back through meetup chat/twitter.
