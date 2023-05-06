using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5.Clases
{
    public class Circulo : Figura
    {
        public double Radio { get; set; }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }
    }
}
