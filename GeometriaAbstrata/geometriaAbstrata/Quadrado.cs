using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometriaAbstrata
{
    public class Quadrado : FormaGeometrica
    {
        int Lado1 { get; set; }

        public Quadrado(int lados,int lado1) :base(lados)
        {
            this.Lado1 = lado1;
        }
    
        public override void CalcularArea()
        {
            Console.WriteLine($"A area do quadrado é: {Lado1 * Lado1}");   

        }
    }

}
