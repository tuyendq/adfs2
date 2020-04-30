```
dotnet aspnet-codegenerator identity --useDefaultUI

dotnet ef migrations add CreateIdentitySchema --context adfs2IdentityDbContext

dotnet ef database update --context adfs2IdentityDbContext

```
