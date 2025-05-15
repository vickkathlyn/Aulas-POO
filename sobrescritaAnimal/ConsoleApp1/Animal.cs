using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Animal
    {
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public string Raca { get; set; }

        public Animal(string nome, string sexo, string raca)
        {
            Nome = nome;
            Sexo = sexo;
            Raca = raca;
        }

        public virtual void EmitirSom() 
        {
            Console.WriteLine("Animal emitiu Som");

        }
    }
}

