namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'43e14cc6-4352-47ed-9f94-714e2a6f5727', N'admin@vidly.com', 0, N'AJiO8cdPOgmeo1Q4rKHG9/emHET+vUGTeulzlUwcXCbn6O3FNaYxUvBiKvJ1HMZ1uQ==', N'd189d351-74f8-47b1-bfd5-f2e8917c4163', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'4c62a113-ab4a-473c-be66-30992d968fb5', N'guest@vidly.com', 0, N'AHNj8+cXzfAn+hfhK/Bb4xezQ9X9/RHXqA1sYw5xI4PfRPfcTlMe2rwiohJQ3Zoeaw==', N'332bc4d9-457e-4bce-b8f9-e423398af6f8', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'6d678c85-030b-42e7-ac2d-b6923e1e6952', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'43e14cc6-4352-47ed-9f94-714e2a6f5727', N'6d678c85-030b-42e7-ac2d-b6923e1e6952')

");
        }
        
        public override void Down()
        {
        }
    }
}
