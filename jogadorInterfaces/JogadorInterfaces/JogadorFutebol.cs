using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogadorInterfaces
{
    public class JogadorFutebol : Jogador, IChutador, IPassador
    {
        public override void Jogar()
        {
            ChutarBola();
            PassarBola();
        }
        public void ChutarBola()
        {
            Console.WriteLine("Jogador de Futebol chutando a bola!");
        }

        public void PassarBola()
        {
            Console.WriteLine("Jogador de Futebol passando a bola!");
        }
    }
}
