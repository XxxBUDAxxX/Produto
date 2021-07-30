using System;
using System.IO;
using ProdutoV2.utilidade;
namespace ProdutoV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Como serar salvo o Arquivo? ");
            Console.Write("txt ou csv: ");
            string tipo = Console.ReadLine().Trim();
            Arquivo arquivo = new Arquivo(tipo);
            
            arquivo.CriarArquivo();
            arquivo.LerArquivo();


        }
    }
}
