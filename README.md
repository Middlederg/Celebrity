# Celebrity

**Time's Up" party card game like project**

[About the game](About.md)

---

### Database migrations

````
dotnet ef migrations add "Initial" --project .\src\Celebrity.Data\Celebrity.Data.csproj --startup-project .\src\Celebrity.Host\Celebrity.Host.csproj -v
dotnet ef database update --project .\src\Celebrity.Data\Celebrity.Data.csproj --startup-project .\src\Celebrity.Host\Celebrity.Host.csproj
````


### Generate script

````
dotnet ef migrations script --project .\src\Celebrity.Data\Celebrity.Data.csproj --startup-project .\src\Celebrity.Blazor\Celebrity.Blazor.csproj -o ./script.sql nombreMigracionAnterior
````

