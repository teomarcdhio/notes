# notes
A basic notes app 
Built using .net 5

From CLI to create the new .net app
dotnet new webapi -n notes

Add the relevant packages
dotnet add package Microsoft.EntityFrameworkCore --version 5.0.0

dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design

dotnet add package Microsoft.EntityFrameworkCore.Design

dotnet add package MySql.EntityFrameworkCore --version 5.0.0

And the following for Migrations and controller generators
dotnet add package Microsoft.EntityFrameworkCore.SqlServer

Create a Data folder where to store the Context files that will define the DB connection

Create a model for the relevant objects

Create a controller for the relevant objects ( can scaffold with the aspnet codegenrator )

dotnet tool install -g dotnet-aspnet-codegenerator

dotnet aspnet-codegenerator controller -name NotesController -api -m Note -dc NotesContext -outDir Controllers

Create migrations
dotnet ef migrations add NotesController

And create the DB
dotnet ef database update

Start the app
dotnet run
