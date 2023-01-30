# Register
This is built with ASP.NET Core and a code first database that writes to a SQL instance, incorporating LINQ queries.
The C# code can create a SQL instance on your local machine, as well as populate the database.
You can pass in values from the front-end, or update it from workbench/SSMS
You can create instances of teachers, students, and courses that only allow you to enter valid information and available courses.
The numeric ID of each category will be automatically incremented when a new instance is created from the front end.

When creating a new teacher, the dropdown only allows you to choose from existing course, to avoid any typos that would cause an error in the database, or losing track of any new users.
You can update the database from the front-end, and there is client-side validation done
with TypeScript so nothing that will throw an error can be passed to the database.
UI is implemented using bootstrap.


