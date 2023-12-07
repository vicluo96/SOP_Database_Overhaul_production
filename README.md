# SOP-Database-Overhaul
The front end was developed using Node.js and React, supported by an MVC controller, while the back end showcases a .NET Web API application, meticulously crafted in C# and rooted in the principles of clean architecture. It is accompanied by a scalable SQL schema, ingeniously designed to facilitate the future updating of scholarships and dynamic questions.

## In SOP-Database-Overhaul

### Run the backend server
 `dotnet run --project api/api.csproj`

### Migration
 `dotnet ef migrations add schl --project persistence --startup-project API --context dataContext`

### Update the database after migration
 `dotnet ef database update --project api/api.csproj`
