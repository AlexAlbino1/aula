using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Livro
    {
        public String nome;
        public String resumo;
        public Double valor;
        public int paginas;
        public String autor;
        

        public void exibirDados()
        {
            string titulo = "detalhes do livro";
            Console.WriteLine(titulo);
            Console.WriteLine("nome" + nome);
            Console.WriteLine("resumo" + resumo);
            Console.WriteLine("valor" + valor);
            Console.WriteLine("paginas" +  paginas);
            Console.WriteLine("autor" +  autor);

            
        }
    }
}
