namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3451bb36-e1bd-461d-ab70-e69f4a1ec339', N'guest@vidly.com', 0, N'AEHTLVYvJO4zfhO043GN4LZl4ebGLYC59/L4ZlxXRb1g0BJLS1ky8S/ArjnnLRvywA==', N'ef67b443-724b-4f46-ae6f-f57d5abd88ea', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'72aa8df4-0626-4a68-8417-9f6d8dd76764', N'admin@vidly.com', 0, N'AEC/mzUcWG+IIPIflqmwEkbUSnOd1r9Qt5ti6jQbKv27QWqmtiDsQaPjaWBf9kYHJw==', N'1a84ce2f-5529-44bb-8af5-2809d64d384a', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'aaacc7f9-56c1-4540-a186-ccd197be06c6', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'72aa8df4-0626-4a68-8417-9f6d8dd76764', N'aaacc7f9-56c1-4540-a186-ccd197be06c6')
");
        }

        public override void Down()
        {
        }
    }
}
