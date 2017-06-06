namespace Locadora.Infraestrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriacaoTabelaLocacaoEItem : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Item",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Descricao = c.String(),
                        Preco = c.Double(nullable: false),
                        Quantidade = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Locacao",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdProduto = c.Int(nullable: false),
                        IdPacote = c.Int(nullable: false),
                        IdCliente = c.Int(nullable: false),
                        DataLocacao = c.DateTime(nullable: false),
                        DataEntregaPrevista = c.DateTime(nullable: false),
                        DataEntregaReal = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cliente", t => t.IdCliente, cascadeDelete: true)
                .ForeignKey("dbo.Pacote", t => t.IdPacote, cascadeDelete: true)
                .ForeignKey("dbo.Produto", t => t.IdProduto, cascadeDelete: true)
                .Index(t => t.IdProduto)
                .Index(t => t.IdPacote)
                .Index(t => t.IdCliente);
            
            CreateTable(
                "dbo.ItemLocacao",
                c => new
                    {
                        IdLocacao = c.Int(nullable: false),
                        IdItem = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.IdLocacao, t.IdItem })
                .ForeignKey("dbo.Locacao", t => t.IdLocacao, cascadeDelete: true)
                .ForeignKey("dbo.Item", t => t.IdItem, cascadeDelete: true)
                .Index(t => t.IdLocacao)
                .Index(t => t.IdItem);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Locacao", "IdProduto", "dbo.Produto");
            DropForeignKey("dbo.Locacao", "IdPacote", "dbo.Pacote");
            DropForeignKey("dbo.ItemLocacao", "IdItem", "dbo.Item");
            DropForeignKey("dbo.ItemLocacao", "IdLocacao", "dbo.Locacao");
            DropForeignKey("dbo.Locacao", "IdCliente", "dbo.Cliente");
            DropIndex("dbo.ItemLocacao", new[] { "IdItem" });
            DropIndex("dbo.ItemLocacao", new[] { "IdLocacao" });
            DropIndex("dbo.Locacao", new[] { "IdCliente" });
            DropIndex("dbo.Locacao", new[] { "IdPacote" });
            DropIndex("dbo.Locacao", new[] { "IdProduto" });
            DropTable("dbo.ItemLocacao");
            DropTable("dbo.Locacao");
            DropTable("dbo.Item");
        }
    }
}
