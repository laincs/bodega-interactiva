# bodega-interactiva

dotnet restore
dotnet run

dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet tool install --global dotnet-ef

dotnet ef database update

# In case of failure

dotnet nuget add source https://api.nuget.org/v3/index.json -n nuget.org
> dotnet nuget list source

# Migration

dotnet ef migrations add InitialCreate