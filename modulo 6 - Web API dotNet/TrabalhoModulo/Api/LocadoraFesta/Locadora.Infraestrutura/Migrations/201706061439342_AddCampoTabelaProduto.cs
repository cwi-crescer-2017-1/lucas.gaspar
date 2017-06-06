namespace Locadora.Infraestrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCampoTabelaProduto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produto", "Descricao", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Produto", "Descricao");
        }
    }
}
