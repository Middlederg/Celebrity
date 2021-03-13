# Celebrity

**Time's Up" party card game like project**

[About the game](About.md)

---

### Database migrations

````
dotnet ef migrations add "nombremigracion" --project .\src\Celebrity.Data\Celebrity.Data.csproj --startup-project .\src\Celebrity.Blazor\Celebrity.Blazor.csproj -v
dotnet ef database update --project .\src\Celebrity.Data\Celebrity.Data.csproj --startup-project .\src\Celebrity.Blazor\Celebrity.Blazor.csproj
````


### Generate script

````
dotnet ef migrations script --project .\src\Celebrity.Data\Celebrity.Data.csproj --startup-project .\src\Celebrity.Blazor\Celebrity.Blazor.csproj -o ./script.sql nombreMigracionAnterior
````

