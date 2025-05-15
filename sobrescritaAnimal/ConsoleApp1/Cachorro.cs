using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Cachorro : Animal
    {
        public Cachorro(string nome, string sexo, string raca) : base(nome, sexo, raca)
        {

        }

        public override void EmitirSom()
        {
            Console.WriteLine("Cachorro: au au ");
        }
    }
}
