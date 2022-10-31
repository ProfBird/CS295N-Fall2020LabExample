# CS295N-Fall2020LabExample

This Book Review web site provides examples of how to implement the types of features that students will need to implement in their weekly lab assignments. 

## Branches

The branches of the repository are named according to the labs. Each branch of the repository contains code that reflects what students will do in that lab assignment.

### lab01

Skeletal web site

### lab02

Navigation links

### lab03

Data entry form in a view

### lab04

- Bootstrap
- Publishing to Azure

### lab05

Unit tests

### lab06

Entity Framework and a database

We added this to the web app:

- NuGet packages:
  - Microsoft.EntityFrameworkCore
    Entity Framework Core itself
  - Microsoft.EntityFrameworkCore.SqlServer
    The database provider for SQL Server
- ID properties on the domain models
  - Review
  - User
- BookReviewContext class which is a sub-class of DbContext
  - DbSet<Review>
  - DbSet<User>
- Connection string in appsettings.json
- In the Startup class, in the ConfigureServices method
  - services.AddDbContext<BookReviewContext> method call with parameters for
    - Database provider
    - Connection string



