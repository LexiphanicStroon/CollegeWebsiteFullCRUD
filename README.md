# Register
This is built with ASP.NET Core and a code first database that writes to a sql instance, incorporating LINQ queries.
The C# code can create a SQL instance on your local machine, as well as populate the database.
You can pass in values from the front-end, or update it from workbench/SSMS
You can create instances of teachers, students, and courses that only allow you to enter valid information and available courses.
When creating a new teacher, the dropdown only allows you to choose from existing course, and there is also a C# method in the DB models
that automatically increment the Primary ID number of whatever is being created so the user doesn't have to worry about it.
You can update the database from the front-end, and there is client-side validation done
with TypeScript so nothing that will throw an error can be passed to the database.
UI is done with bootstrap. 
Some custom javascript functions
