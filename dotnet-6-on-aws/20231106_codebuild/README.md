# Hands-on with AWS - Code Build - .NET 8 / Java Spring Boot

## Date Time: 06-Nov-2023 at 09:00 AM IST

## Event URL: [https://www.meetup.com/dot-net-learners-house-hyderabad/events/296075156](https://www.meetup.com/dot-net-learners-house-hyderabad/events/296075156)

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

### Please refer to the [**Source Code**](https://github.com/vishipayyallore/learn-aws-in-2024) of today's session for more details

---

![Information | 100x100](./Documentation/Images/SeatBelt.PNG)

---

## Existing AWS Code Commit Repositories

> 1. Discussion and Demo

![AWS Code Commit Repositories | 100x100](./Documentation/Images/AWS_Code_Commit_Repos.PNG)

## 1. What is AWS Code Build?

> 1. Discussion

**Reference(s):**

> 1. <https://docs.aws.amazon.com/codebuild/>
> 1. <https://docs.aws.amazon.com/codebuild/latest/userguide/welcome.html>
> 1. <https://docs.aws.amazon.com/codebuild/latest/userguide/concepts.html>

## 2. Basic Code Build Workflow

> 1. Developer commits the code to AWS Code Commit
> 1. AWS Code Build will build the code
> 1. AWS Code Build will run the tests
> 1. AWS Code Build will publish the artifacts to S3 Bucket

## 3. Create the S3 Bucket

> 1. Discussion and Demo

![S3 Buckets for Build Artifacts | 100x100](./Documentation/Images/S3_Buckets_build_artifacts.PNG)

## 4. Create the Code Build Project

> 1. Discussion and Demo

![AWS Code Build Project | 100x100](./Documentation/Images/AWS_CodeBuildProject.PNG)

## 5. Start the Build in AWS Code Build Project

> 1. Discussion and Demo

![AWS Code Build Execution | 100x100](./Documentation/Images/AWS_CodeBuild_Execution_1.PNG)

## 6. Clean, Build and Test the Spring Boot and .NET 8 Application Locally

> 1. Discussion and Demo

```bash
& "c:\GitHub\learn-aws-in-2024\code-for-cicd\greetings-api\mvnw.cmd" clean -f "c:\GitHub\learn-aws-in-2024\code-for-cicd\greetings-api\pom.xml"

& "c:\GitHub\learn-aws-in-2024\code-for-cicd\greetings-api\mvnw.cmd" validate -f "c:\GitHub\learn-aws-in-2024\code-for-cicd\greetings-api\pom.xml"

& "c:\GitHub\learn-aws-in-2024\code-for-cicd\greetings-api\mvnw.cmd" install -f "c:\GitHub\learn-aws-in-2024\code-for-cicd\greetings-api\pom.xml"
```

![Clean Build Locally | 100x100](./Documentation/Images/Clean_Build_Locally.PNG)

## 7. Few Git Commands

> 1. Discussion and Demo

```bash
git checkout main
git fetch
git pull

git branch

git checkout swamy/05nov-work
git merge main

git status
git diff

git add .
git commit -m "Added the BuildSpec.yml"
```

![Git Commit and Merge | 100x100](./Documentation/Images/Git_Commit_Merge.PNG)

## 6. Create the BuildSpec.yml

> 1. Discussion and Demo

Reference(s):

> 1. <https://aws.amazon.com/blogs/devops/building-net-7-applications-with-aws-codebuild/>

```yml
version: 0.2

phases:
  install:
    runtime-versions:
      java: openjdk17
  pre_build:
    commands:
      - echo Nothing to do in the pre_build phase...
  build:
    commands:
      - echo Build started on `date`
      - mvn install
  post_build:
    commands:
      - echo Build completed on `date`
artifacts:
  files:
    - target/greetings-api.1.0.1.jar
```

## 7. Start the Build

> 1. Discussion and Demo

## 8. View the Build Logs

> 1. Discussion and Demo

## 9. View the Build Artifacts

> 1. Discussion and Demo

## 10. View the Build History

> 1. Discussion and Demo

## Create the Build Notification

> 1. Discussion and Demo

## 11. View the Build Notification

> 1. Discussion and Demo

---

## SUMMARY / RECAP / Q&A

> 1. SUMMARY / RECAP / Q&A
> 2. Any open queries, I will get back through meetup chat/twitter.

---

## What is Next? session?

> 1. To be decided
> 1. SUMMARY / RECAP / Q&A
> 1. Any open queries, I will get back through meetup chat/twitter.
