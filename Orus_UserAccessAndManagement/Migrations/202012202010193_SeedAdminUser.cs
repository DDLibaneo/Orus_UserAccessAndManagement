namespace Orus_UserAccessAndManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedAdminUser : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) 
                VALUES(N'd3073608-1d9d-4dd2-be06-4c47199aef08', N'admin@gmail.com', 0, N'AMbXQg69Cd6vu19KJcp4877INlkn2IDsRmua6Ts0h0JoXkcRau5u4BWvQiD03S0W8g==', N'f63e6788-c72d-41a9-a37c-eafe36b105ba', NULL, 0, 0, NULL, 1, 0, N'admin@gmail.com')"
            );
        }
        
        public override void Down()
        {
        }
    }
}
