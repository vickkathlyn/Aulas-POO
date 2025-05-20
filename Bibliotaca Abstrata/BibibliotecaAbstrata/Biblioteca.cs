using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibibliotecaAbstrata
{
    class Biblioteca
    {
        public List<Livro> Livros { get; set; } = new List<Livro>();

        public void ProcurarLivro(int idadeMinima)
        {
            foreach(LivroInfantil livro in Livros.OfType<LivroInfantil>())
            {
                if(livro.IdadeMinima <= idadeMinima)
                {
                    Console.WriteLine($"Título: {livro.Titulo}, Idade mínima: {livro.IdadeMinima}");
                }
            }
        }
        public void ProcurarLivro(string codOrcid)
        {
            foreach(LivroAcademico livro in Livros.OfType<LivroAcademico>())
            {
                if(livro.CodOrcid == codOrcid)
                {
                    Console.WriteLine($"Título: {livro.Titulo}, Codigo Orcid: {livro.CodOrcid}");
                }
            }
        }
    }
}
