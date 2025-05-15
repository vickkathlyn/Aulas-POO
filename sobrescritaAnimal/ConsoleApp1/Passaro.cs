using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Passaro:Animal 
    {
        public Passaro(string nome,string sexo,string raca) : base(nome, sexo, raca) 
        {
        }

        public override void EmitirSom()
        {
            Console.WriteLine("Passaro: piu piu");
        }
    }
}
