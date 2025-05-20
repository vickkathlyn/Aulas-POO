using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometriaAbstrata
{
    public class Circulo: FormaGeometrica
    {
        public int Raio { get; set; }
        public Circulo(int lados,int raio) : base(lados)
        {
            this.Raio = raio;
        }

        public override void CalcularArea()
        {
            Console.WriteLine($"A area do circulo é: {Raio * 3.14}");
        }
    }
}
