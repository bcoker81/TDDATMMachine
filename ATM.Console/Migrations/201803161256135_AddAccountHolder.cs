namespace ATM.Console.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAccountHolder : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Accounts", "AccountHolder", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Accounts", "AccountHolder");
        }
    }
}
