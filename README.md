# Tip Of The Day Web Site Prototype  
**By Brian Bird, 2025**  
This is example code for courses I teach at Lane Community College.

- This is a "throwaway" prototype of an ASP.NET Core MVC web site for crowd sourcing and sharing programming tips.
- The point of this prototype was to test the many-to-many `Tip` to `Tag` relationship in the domain model. 
- There is a UML class diagram and an ERD diagram of the model in the docs directory.
- This many-to-many relationship is tested with simple scaffolding for the `Tip` and `Tag` models. The only thing modified in the scaffolding was the page for editing tips to add or remove tags. This was sufficient to demonstrate that the many-to-many relationship of tips to tags was working. This is what was modified:
  - `TipsController`, GET `Edit` method
    -   .Include was added to get `Tag` objects for the`Tip`
    - A `foreach` loop was added to show which tags are on the tip
  - `Edit.cshtml` for tips was modified to allow selection of tags for a tip.

## Database Configuration
### Database Choices
In program.cs there are preprossing directives that allow you to choose whether to use SQLite, MS SQL Server, or MySQL.
#### SQLite is the Default
- Since this is a prototype and doesn't use any DB features that aren't supported by SQLite, it is the default.
- The migrations in this project are for SQLite.
- The project uses the [Microsoft.EntityFrameworkCore.Sqlite](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Sqlite/8.0.13) NuGet package which includes the SQLite database engine so you don't need to have it installed on the machine running this app.
- There are also NuGet packages in this project to support MS SQL Server and MySQL.

### Automatic Database Creation and Migration
When the app starts, it will check to see if there is a DB and if not will create it and apply migrations. The code for this is in program.cs.
## Related Repositories
- This project was forked from [a version using .NET 6](https://github.com/ProfBird/TipOfTheDay-AspNet6) and migrated to .NET 8
- An older version of the code with scaffolding and unit tests is here: https://github.com/ProfBird/TipOfTheDay-AspNetCore3
- An even older version using .net 4.5 is here: https://github.com/LCC-CIT/CS296N-TipOfTheDay  
