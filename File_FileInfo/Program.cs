using System;
using System.IO;
namespace ProdutoV2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamWriter arquivo;
                string destino = @"C:\Produto.csv";
                arquivo = File.CreateText(destino);
                arquivo.Close();

                char resp = 'S';
                while (resp != 'N')
                {
                    Console.Write($"Nome do produto: ");
                    string nome = Console.ReadLine();
                    Console.Write($"Quantidade: ");
                    int quant = int.Parse(Console.ReadLine());
                    Console.Write($"Preço und do {nome}: ");
                    double preco = double.Parse(Console.ReadLine());
                    Console.Write($"Deseja cadastrar mais algum produto ? [S/N]");
                    resp = char.Parse(Console.ReadLine().ToUpper());

                    arquivo = File.AppendText(destino);
                    arquivo.WriteLine($"{nome}, {quant}, {preco}");


                    if (resp == 'N')
                    {
                        resp = 'N';
                    }
                    arquivo.Close();
                }
                arquivo.Close();

            }
            catch (IOException erro)
            {
                Console.Write("Erro na criaçao do arquivo: ");
                Console.WriteLine(erro.Message);
            }
        }
    }
}
