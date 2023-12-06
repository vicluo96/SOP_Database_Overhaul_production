# SOP-Database-Overhaul
This is a .NET Web API app in C# that revolutionizes how UCI students apply for scholarships and how staff manage these applications. This empowers scholarship management staff with the ability to modify records easily and independently.
The frontend was developed with React and node.js supported by an MVC controller. The SQL schema is designed according to BCNF, ENGINE = InnoDB, DEFAULT CHARACTER SET = utf8mb4.

## In SOP-Database-Overhaul

### Run the backend server
 `dotnet run --project api/api.csproj`

### Migration
 `dotnet ef migrations add schl --project persistence --startup-project API --context dataContext`

### Update the database after migration
 `dotnet ef database update --project api/api.csproj`