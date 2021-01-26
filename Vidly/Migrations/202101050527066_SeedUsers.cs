namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c3b65742-21f8-4de7-88ee-46a2b9919832', N'guest@vidly.com', 0, N'ALXwjshYocDMCGrbyY35v/Tbzs2Wz+WkWmLMRCnWg9JTIwwSGma++BwOZ7RCdSe7Ng==', N'8ff36f2f-d347-40c1-8340-4fd1c220e8b9', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd90a3be9-3702-43e8-af0c-32faf26dd00a', N'admin@vidly.com', 0, N'AIv0ngn/SGJiFGdOL+jP30faF/CIM5YJCBpQ175RLBhJ8o56XLYgYA1Z4aYnbCa+sw==', N'd907c678-269c-47f2-bdd8-154f49e4512a', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'4a32a3f4-3861-407e-a3a4-a9ddce5ee713', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd90a3be9-3702-43e8-af0c-32faf26dd00a', N'4a32a3f4-3861-407e-a3a4-a9ddce5ee713')
");
        }
        
        public override void Down()
        {
        }
    }
}
