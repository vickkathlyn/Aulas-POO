using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class Personagem
    {
        public string Nome { get; set; }
        public int Vida { get; set; }

        public Personagem(string nome,int vida)
        {
            Nome = nome;
            Vida = vida;

        }

        public virtual void Atacar(string atacante, string alvo, List<Personagem> personagens)
        {
            var atacantes = personagens.Where(p => p.Nome == atacante && p.Vida>0);
            var alvos = personagens.Where(p => p.Nome == alvo && p.Vida > 0);

            if (!atacantes.Any())
            {
                Console.WriteLine("Personagem atacante não existe ou está sem vida.");
                return;
            }

            if (!alvos.Any())
            {
                Console.WriteLine("Personagem alvo não existe ou está sem vida.");
                return;
            }


            foreach (var p in atacantes)
            {
                Console.WriteLine($"{p.Nome} ataca {alvo}!");
            }
        }


    }
}
