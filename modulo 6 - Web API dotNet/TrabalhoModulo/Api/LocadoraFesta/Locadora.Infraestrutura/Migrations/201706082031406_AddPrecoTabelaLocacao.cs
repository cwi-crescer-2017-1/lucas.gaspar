namespace Locadora.Infraestrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPrecoTabelaLocacao : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Locacao", "PrecoTotal", c => c.Double(nullable: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Locacao", "PrecoTotal");
        }
    }
}
