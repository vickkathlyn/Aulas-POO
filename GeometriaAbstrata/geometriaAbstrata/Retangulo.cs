using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometriaAbstrata
{
    public class Retangulo: FormaGeometrica
    {
        int Lado1 { get; set; }
        int Lado2 { get; set; }
        public Retangulo(int lados, int lado1, int lado2) : base(lados)
        {
            this.Lado1 = lado1;
            this.Lado2 = lado2;
        }

        public override void CalcularArea()
        {
            Console.WriteLine($"A area do Retangulo é: {Lado1 * Lado2}");

        }
    }
}
