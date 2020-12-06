namespace Response_Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_New_Model_for_Data : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DataDetailModels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Round = c.Int(nullable: false),
                        Item_One = c.Int(nullable: false),
                        Item_Two = c.Int(nullable: false),
                        Item_Three = c.Int(nullable: false),
                        Item_Four = c.Int(nullable: false),
                        Item_Five = c.Int(nullable: false),
                        Item_Six = c.Int(nullable: false),
                        Item_Seven = c.Int(nullable: false),
                        Item_Eight = c.Int(nullable: false),
                        Item_Nine = c.Int(nullable: false),
                        Item_Ten = c.Int(nullable: false),
                        Item_Eleven = c.Int(nullable: false),
                        Item_Twelve = c.Int(nullable: false),
                        Item_Thirteen = c.Int(nullable: false),
                        Item_Fourteen = c.Int(nullable: false),
                        Item_Fifteen = c.Int(nullable: false),
                        Item_Sixteen = c.Int(nullable: false),
                        Item_Seventeen = c.Int(nullable: false),
                        Item_Eighteen = c.Int(nullable: false),
                        Item_Nineteen = c.Int(nullable: false),
                        Item_Twenty = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DataDetailModels");
        }
    }
}
