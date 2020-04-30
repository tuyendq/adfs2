```
dotnet aspnet-codegenerator identity -dc adfs2IdentityDbContext --files "Account.Register;Account.Login;Account.Logout"

dotnet ef migrations add CreateIdentitySchema --context adfs2IdentityDbContext

dotnet ef database update --context adfs2IdentityDbContext

```



```
dotnet add package Microsoft.AspNetCore.Authentication.WsFederation
dotnet list package
```
