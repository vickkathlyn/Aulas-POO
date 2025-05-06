using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogadorInterfaces
{
    public class JogadorBoliche: Jogador, IArremessador
    {
        public override void Jogar() 
        {
            ArremessarBola();
        }

        public void ArremessarBola()
        {
            Console.WriteLine("Jogador de Boliche esta arremessando a bola");
        }
    }
}
