using System;
using System.Collections.Generic;
using System.IO;

namespace ProdutoV2.utilidade
{
    class Arquivo
    {
        public string Tipo { get; set; }


        public Arquivo()
        {
            Tipo = "txt";
        }

        public Arquivo(string tipo)
        {
            if (tipo == null || tipo != "txt" || tipo != "csv")
            {
                Tipo = "txt";
            }
            else
            {
                Tipo = tipo;
            }
        }
        
        /*private string GerarArquivo()
        {
            
            StreamWriter arquivo;
            string destino = @"C:\Produto." + Tipo;
            bool existe = File.Exists(destino);
            if (existe == true)
                return "";
            arquivo = File.CreateText(destino);
            arquivo.Close();
            return "";
        }*/


        
        public string  CriarArquivo()
        {
            StreamWriter arquivo;
            string destino = @"C:\Produto." + Tipo;

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
            
            return "";
        }



        public string LerArquivo()
        {
            string destino = @"C:\Produto."+Tipo;
            StreamReader ler;
            string caminho = $"{destino}";
            ler = File.OpenText(caminho);
            while (ler.EndOfStream != true)
            {
                string linha = ler.ReadLine();
                Console.WriteLine(linha);
            }
            ler.Close();
            return "";
        }

        /*public string SalvarArquivo()
        {

        }*/


    }
}
