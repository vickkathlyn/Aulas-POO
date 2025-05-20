using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibibliotecaAbstrata
{
    class LivroInfantil: Livro
    {
        public int IdadeMinima { get; set; }

        public LivroInfantil(string nome, string autor,int idadeMinima) : base(nome,autor)
        {
            IdadeMinima = idadeMinima;
        }
    }
}
