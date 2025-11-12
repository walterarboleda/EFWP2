# EFWP2

# Creating an MVC Web App using Entity Framework Code First
## By Walter Hugo Arboleda Mazo


## 1. Install the following namespaces using PM or NuGet
 
 Install-Package Microsoft.EntityFrameworkCore.SqlServer
 
 Install-Package Microsoft.EntityFrameworkCore.Design
 
 Install-Package Microsoft.EntityFrameworkCore.Tools


## 2. Use the following commands on PM after creating the DBContext and Models>

dotnet build

dotnet ef migrations add InitialCreate

dotnet ef database update 

<img width="1608" height="670" alt="image" src="https://github.com/user-attachments/assets/bfe0a9fb-ec74-440a-8ac5-68555604696a" />



## Reference:

https://nipuanandawansha.medium.com/code-first-approach-in-entity-framework-with-asp-net-core-c5f4e7fe7906

