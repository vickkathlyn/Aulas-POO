using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometriaAbstrata
{
    public abstract class FormaGeometrica
    {
        public int Lados { get; set; } 

        public FormaGeometrica(int lados)
        {
            Lados = lados;
        }

        public abstract void CalcularArea();
    }
}
