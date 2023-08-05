# Azure OpenAI - Mini Project - Python, Postman, .NET 7 Minimal API, Azure SQL, Blazor and Angular

## Date Time: 07-Aug-2023 at 09:00 AM IST

## Event URL: [https://www.meetup.com/dot-net-learners-house-hyderabad/events/294280219](https://www.meetup.com/dot-net-learners-house-hyderabad/events/294280219)

## YouTube URL: [https://www.youtube.com/watch?v=ppcS_V3rFkg](https://www.youtube.com/watch?v=ppcS_V3rFkg)

![Viswanatha Swamy P K |150x150](./Documentation/Images/ViswanathaSwamyPK.PNG)

---

### Software/Tools

> 1. OS: Windows 10 x64
> 1. Python / .NET 7
> 1. Visual Studio 2022
> 1. Visual Studio Code

### Prior Knowledge

> 1. Programming knowledge in C# / Python
> 1. Azure

## Technology Stack

> 1. .NET 7, Azure, OpenAI

## Information

![Information | 100x100](./Documentation/Images/Information.PNG)

## What are we doing today?

> 1. To be decided
> 1. SUMMARY / RECAP / Q&A
> 1. What is next ?

### Please refer to the [**Source Code**](https://github.com/vishipayyallore/speaker-series-2023/tree/main/AzureOpenAI) of today's session for more details

---

![Information | 100x100](./Documentation/Images/SeatBelt.PNG)

---

## 1. Setting up Azure SQL Database, Tables and Stored Procedures

> 1. Discussion on Azure SQL Database, Tables and Stored Procedures

### 1.1. Table Creation

```sql
CREATE TABLE CountriesInfo (
    [CountryId] INT IDENTITY (1, 1) NOT NULL PRIMARY KEY,
    [CountryName] NVARCHAR(100),
    [CapitalState] NVARCHAR(100),
    [NationalBird] NVARCHAR(100),
    [CountryPopulation] BIGINT
);
```

### 1.2. Stored Procedure Creation

```sql
CREATE PROCEDURE [dbo].[usp_insert_country_info]
    @CountryName NVARCHAR(100),
    @CapitalState NVARCHAR(100),
    @NationalBird NVARCHAR(100),
    @CountryPopulation BIGINT,
    @CountryId INT OUTPUT
AS
BEGIN
    
    SET NOCOUNT ON;

    INSERT INTO CountriesInfo 
        (CountryName, CapitalState, NationalBird, CountryPopulation)
    VALUES 
        (@CountryName, @CapitalState, @NationalBird, @CountryPopulation);

    SET @CountryId = SCOPE_IDENTITY();

    SELECT @CountryId AS CountryId;
    
END;
```

![Azure SQL Assets | 100x100](./Documentation/Images/Azure_Sql_Assets.PNG)

## X. To be decided

### How to execute the Python Flask API?

```python
flask --app app run

python .\app.py
```

![Execute Python Flask API | 100x100](./Documentation/Images/Executing_Flask_App.PNG)

---

## SUMMARY / RECAP / Q&A

> 1. SUMMARY / RECAP / Q&A
> 2. Any open queries, I will get back through meetup chat/twitter.

---

## What is Next? session?

> 1. To be decided
