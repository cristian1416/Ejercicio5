using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5.Clases
{
    public class Rectangulo : Figura
    {
        public double Ancho { get; set; }
        public double Alto { get; set; }

        public override double Area()
        {
            return Ancho * Alto;
        }
    }
}
