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

        public int Ataque { get; set; }

        public Personagem(string nome,int vida, int ataque)
        {
            Nome = nome;
            Vida = vida;
            Ataque = ataque;
        }

        public virtual void Atacar(string nomeAtacante, string nomeAlvo, List<Personagem> personagens)
        {
            Personagem atacante = personagens.FirstOrDefault(p => p.Nome == nomeAtacante && p.Vida > 0);
            Personagem alvo = personagens.FirstOrDefault(p => p.Nome == nomeAlvo && p.Vida > 0);

            if (atacante == null)
            {
                Console.WriteLine("Personagem atacante não existe ou está sem vida.");
                return;
            }

            if (alvo == null)
            {
                Console.WriteLine("Personagem alvo não existe ou está sem vida.");
                return;
            }




            

            if (atacante != null && alvo != null && alvo.Vida >= 0)
            {
                // Reduz a vida do alvo pelo valor do ataque do atacante
                alvo.Vida -= atacante.Ataque;


                // Evita que a vida fique negativa
                if (alvo.Vida < 0)
                    alvo.Vida = 0;

                Console.WriteLine($"{atacante.Nome} causou {atacante.Ataque} de dano em {alvo.Nome}, fazendo ficar com {alvo.Vida} de vida");

                if (alvo.Vida == 0)
                    Console.WriteLine($"{alvo.Nome} morreu.");
            }

        }

        public static void AtacarPersonagem(string nomeAtacante, string nomeAlvo, List<Personagem> personagens)
        {
            Personagem atacante = personagens.FirstOrDefault(p => p.Nome == nomeAtacante && p.Vida > 0);
            if (atacante == null)
            {
                Console.WriteLine("Atacante não encontrado ou está sem vida.");
                return;
            }

            // Agora chama o método de instância (polimórfico)
            atacante.Atacar(nomeAtacante, nomeAlvo, personagens);
        }

    }


    
}
