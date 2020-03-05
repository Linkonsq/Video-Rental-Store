namespace VideoRentalStore.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'4021d782-60a0-4f73-91c9-f06a0baa5313', N'guest@vrs.com', 0, N'AL4Pf3mrv51mcYfro/VMb4x4R+sPhqxhVvShWNs76nwrzSDTOI8yWQkZRTfGYk6AdQ==', N'e8dbd164-e06a-44fe-87fd-7e69bfec0515', NULL, 0, 0, NULL, 1, 0, N'guest@vrs.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'6251d872-7e19-45e3-88ce-68e3554c2ed7', N'admin@vrs.com', 0, N'ADaXnJJRLyhvrNykxZJPjIZRBMsUW+keFrnjxoI2H1GudojQrzftJgxsxZjFw9T2Dg==', N'9c2a651d-58ec-46f5-8678-9c0cd75604b4', NULL, 0, 0, NULL, 1, 0, N'admin@vrs.com')
            
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'dfad3de7-c8b3-4719-b833-639abe109603', N'CanManageMovies')
            
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'6251d872-7e19-45e3-88ce-68e3554c2ed7', N'dfad3de7-c8b3-4719-b833-639abe109603')
            ");
        }

        public override void Down()
        {
        }
    }
}
