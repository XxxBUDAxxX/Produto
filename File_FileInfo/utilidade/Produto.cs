namespace ProdutoV2.utilidades
{
    class Produto
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double ValorUnd { get; set; }

        public Produto(string nome, int quantidade, double valorUnd)
        {
            Nome = nome;
            Quantidade = quantidade;
            ValorUnd = valorUnd;
        }

        public double ValorTotal()
        {
            return Quantidade * ValorUnd;
        }
    }
}
