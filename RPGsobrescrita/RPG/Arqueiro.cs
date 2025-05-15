using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class Arqueiro: Personagem
    {
        public int Flechas { get; set; }
        public Arqueiro(string nome, int vida, int flechas) : base(nome, vida)
        {
            Flechas = flechas;
        }
    }
}
