using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Editora
    {
        private string nome;
        private string site;
        private string telephone;
        static void Main(string[] args)
        {
            
            Editora edit = new Editora();
            edit.nome = ("nome do autor");
            edit.site = ("site do autor");
            edit.telephone = ("telefone do autor");

            

        }
        private void exibirDados()
        {
            Console.WriteLine("editora" + nome);

            Livro livro = new Livro();
            livro.autor = ("nome do autor");
            livro.valor = (-100);
            livro.resumo = ("resumo do livro");
            livro.paginas = (99);
            livro.resumo = ("resumo do livro");
            livro.nome = ("nome do livro");

            livro.exibirDados();
            Console.WriteLine(exibirDados);
            
            
        }
    }
}
