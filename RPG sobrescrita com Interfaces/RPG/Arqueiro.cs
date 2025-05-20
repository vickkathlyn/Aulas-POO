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
        public Arqueiro(string nome, int vida,int ataque, int flechas) : base(nome, vida,ataque)
        {
            Flechas = flechas;
        }

        public override void Atacar(string nomeAtacante, string nomeAlvo, List<Personagem> personagens) 
        {
            Arqueiro atacante = (Arqueiro)personagens.FirstOrDefault(p => p.Nome == nomeAtacante && p.Vida > 0) as Arqueiro;
            Personagem alvo = personagens.FirstOrDefault(p => p.Nome == nomeAlvo && p.Vida > 0);

            if (atacante.Flechas > 0)
            {
                base.Atacar(nomeAtacante, nomeAlvo, personagens);
                atacante.Flechas--;
            }
            else
            {
                Console.WriteLine("o atacante não tem Flechas");
            }
        }
    }
}
