## ASPMYSQL

Demo how to use dotnetcore WebApi and Connect to Mysql, and trying some migrations.


## Requirements
* Dotnet core 3.1
* Database up and running, you can use mysql8 container `container-helpers`
* `dotnet tool install --global dotnet-ef`
* `dotnet add package Microsoft.EntityFrameworkCore.Design`

## Connections string
Modify `appsettings.json`
```
...
"ConnectionStrings": {
    "DefaultConnection": "server=localhost;port=3306;database=db;user=userName;password=password"
  }
...
```

## Migrations
`dotnet ef database update`


## Links used

* [docs.microsoft.cli/dotnet](https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/dotnet)

* [medium.com/use-ef-core-in-asp-net-core-with-mysql](https://medium.com/@stas_khavruk/how-to-properly-use-ef-core-in-asp-net-core-with-mysql-database-a75f56c97318)


* (dev.mysql.comcore-example) [https://dev.mysql.com/doc/connector-net/en/connector-net-entityframework-core-example.html]

* (tutorials/first-web-api)[https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-3.1&tabs=visual-studio-code]


### Snippets

```
dotnet add package MySql.Data.EntityFrameworkCore --version 8.0.20
dotnet add package Pomelo.EntityFrameworkCore.MySql --version 3.2.2
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 3.1.8

dotnet restore

dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design
 
dotnet restore


## Migrations
dotnet ef dbcontext list
dotnet ef migrations add  DbInit
dotnet ef database update
## Migrations


## Generate code
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet tool install --global dotnet-aspnet-codegenerator
dotnet tool update -g Dotnet-aspnet-codegenerator
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
```
