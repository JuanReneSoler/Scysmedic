dotnet ef dbcontext scaffold "Server=.;Database=ScysmedicDB;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -o Models -c ScysmedicDbContext --project .\Persistence\Persistence.csproj
dotnet ef migrations add IdentityScysmedicMigration --project Persistence --context IdentityScysmedicDbContext
dotnet ef database update --project Persistence --context IdentityScysmedicDbContext