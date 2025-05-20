using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometriaAbstrata
{
    class Triangulo: FormaGeometrica
    {
        int BaseTriangulo { get; set; }
        int Lado2 { get; set; }
        int Lado3 { get; set; }
        public Triangulo(int lados, int baseTriangulo, int lado2, int lado3) : base(lados)
        {
            this.BaseTriangulo = baseTriangulo;
            this.Lado3 = lado3;
            this.Lado2 = lado2;
        }

        public override void CalcularArea()
        {
            Console.WriteLine($"A área do Triângulo é: {Math.Sqrt(((BaseTriangulo + Lado2 + Lado3) / 2.0) * (((BaseTriangulo + Lado2 + Lado3) / 2.0) - BaseTriangulo) * (((BaseTriangulo + Lado2 + Lado3) / 2.0) - Lado2) * (((BaseTriangulo + Lado2 + Lado3) / 2.0) - Lado3)):0.00}");

        }
    }
}
