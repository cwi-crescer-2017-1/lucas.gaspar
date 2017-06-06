namespace Locadora.Infraestrutura.Entidades
{
    public class Item
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        protected Item() { }

        public Item(string nome, string descricao, double preco, int quantidade)
        {

            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            Quantidade = quantidade;
        }
    }
}