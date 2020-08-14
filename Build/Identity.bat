dotnet ef migrations add IdentityScysmedicMigration --project Persistence --context IdentityScysmedicDbContext
dotnet ef database update --project Persistence --context IdentityScysmedicDbContext