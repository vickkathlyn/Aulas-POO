using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogadorInterfaces
{
    public class JogadorBasquete : Jogador, IPassador,IArremessador
    {
        public override void Jogar() 
        {
            PassarBola();
            ArremessarBola();
        }

        public void PassarBola()
        {
            Console.WriteLine("Jogador de Basquete passando a bola");

        }
        public void ArremessarBola()
        {
            Console.WriteLine("JOgador de basquete arremessou a bola");
        }
    }
}
