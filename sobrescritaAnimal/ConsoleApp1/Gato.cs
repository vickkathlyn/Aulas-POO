using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Gato : Animal
    {
        public Gato(string nome, string sexo, string raca) : base(nome, sexo, raca)
        {
        }

        public override void EmitirSom() 
        {
            Console.WriteLine("Gato: Miauu");
        }
    }
}
