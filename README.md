Tip Of The Day Web Site Prototype
By Brian Bird, 2025  
This is example code for courses I teach at Lane Community College  

This is a prototype of an ASP.NET Core MVC web site for crowd sourcing and sharing programming tips.
The point of this prototype was to test the many-to-many Tip-to-Tag relationship in the domain model. This is tested with simple web pages that allow creating Tips and Tags and putting Tags on Tips.

There are a UML class diagram and an ERD diagram in the docs directory.

In program.cs there are preprossing directives that allow you to choose whether to use SQLite, MS SQL Server, or MySQL.

This project was forked from [a version using .NET 6](https://github.com/ProfBird/TipOfTheDay-AspNet6) and migrated to .NET 8   
An older version of the code with scaffolding and unit tests is here: https://github.com/ProfBird/TipOfTheDay-AspNetCore3  
An even older version using .net 4.5 is here: https://github.com/LCC-CIT/CS296N-TipOfTheDay  
