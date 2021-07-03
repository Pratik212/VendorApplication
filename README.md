## VendorApplication

### Tech

* Asp.NET Core Mvc
* SQL Server

### Create Forms

* Vendor Detail Form
* Bank Detail Form

### Entity framework Commands

```sh
$ dotnet-ef migrations add InitialCreate
$ dotnet-ef database update
$ dotnet-ef migrations remove  // this will remove last successfull migration from project
$ dotnet-ef migrations remove --force  // this will remove last successfull migration from project and from database as well
```

### Packages 

```sh
$ dotnet add package Microsoft.EntityFrameworkCore
$ dotnet add package Microsoft.EntityFrameworkCore.Design
$ dotnet add package Microsoft.EntityFrameworkCore.SqlServer
$ dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
```

### Complete Task

* All fields are mandatory 
*	Validate data on save and submit button click
* On save button user can save part of that form

### Pending Task

* On submit form all data should get saved.
