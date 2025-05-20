using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibibliotecaAbstrata
{
    public class LivroAcademico: Livro
    {
        public string CodOrcid { get; set; }

        public LivroAcademico(string nome, string autor, string codOrcid): base(nome,autor)
        {
            CodOrcid = codOrcid;
        }
    }
}
