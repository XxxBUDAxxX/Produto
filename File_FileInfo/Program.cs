using System;
using System.IO;
using ProdutoV2.utilidade;
namespace ProdutoV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Arquivo ar = new Arquivo();
            ar.CriarArquivo();
        }
    }
}
