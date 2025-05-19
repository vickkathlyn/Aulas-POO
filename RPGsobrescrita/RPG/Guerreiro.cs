using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class Guerreiro: Personagem
    {
        public Guerreiro(string Nome, int Vida, int Ataque): base(Nome,Vida,Ataque)
        {

        }

        public override void Atacar(string atacante, string alvo, List<Personagem> personagens)
        {
            Random sorteio = new Random();
            base.Atacar(atacante, alvo, personagens);

            int n = sorteio.Next(1, 10);

            // Busca o personagem atacante e o alvo na lista
            Personagem pAtacante = personagens.Find(p => p.Nome == atacante);
            Personagem pAlvo = personagens.Find(p => p.Nome == alvo);

            

            if (n % 3 == 0)
            {
                Personagem personagemAtacante = personagens.Find(p => p.Nome == atacante);

                if (personagemAtacante is Guerreiro guerreiro)
                {
                    guerreiro.Atacar(atacante, alvo, personagens);
                }
            }

        }


    }
}
