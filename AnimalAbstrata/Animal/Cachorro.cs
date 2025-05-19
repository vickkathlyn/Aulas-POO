﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalPOO
{
    public class Cachorro: Animal
    {
        public Cachorro(string nome, int idade) : base(nome, idade)
        {
        }

        public override void EmitirSom()
        {
            Console.WriteLine("Cachorro: Au Au");
        }
    }
}
