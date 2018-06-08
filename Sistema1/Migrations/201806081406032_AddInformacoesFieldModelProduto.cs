namespace Sistema1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddInformacoesFieldModelProduto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produtoes", "Informacoes", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Produtoes", "Informacoes");
        }
    }
}
