namespace Locadora.Infraestrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataEntregaRealPodeSerNula : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Locacao", "DataEntregaReal", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Locacao", "DataEntregaReal", c => c.DateTime(nullable: false));
        }
    }
}
