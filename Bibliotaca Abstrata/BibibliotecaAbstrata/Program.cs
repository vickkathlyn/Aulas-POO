using System;

namespace BibibliotecaAbstrata
{
    class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();

            biblioteca.Livros.Add(new LivroInfantil("O Pequeno Príncipe", "Antoine de Saint-Exupéry", 8));
            biblioteca.Livros.Add(new LivroInfantil("Turma da Mônica", "Mauricio de Sousa", 5));
            biblioteca.Livros.Add(new LivroAcademico("Estruturas de Dados", "Nicolau", "1234-5678-9012"));
            biblioteca.Livros.Add(new LivroAcademico("Inteligência Artificial", "Alan Turing", "9999-8888-7777"));
            

            Console.WriteLine("Livros infantis para idade mínima 6:");
            biblioteca.ProcurarLivro(6);

            Console.WriteLine("\nProcurando livro com código ORCID '1234-5678-9012':");
            biblioteca.ProcurarLivro("1234-5678-9012");
        }
    }
}
