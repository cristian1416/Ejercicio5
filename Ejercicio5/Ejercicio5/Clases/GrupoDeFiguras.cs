using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5.Clases
{
    public class GrupoDeFiguras : Figura
    {
        public List<Figura> Figuras { get; set; }

        // Implementación de métodos para agregar o remover figuras
        public void AgregarFigura(Figura figura)
        {
            Figuras.Add(figura);
        }

        public void RemoverFigura(Figura figura)
        {
            Figuras.Remove(figura);
        }

        public override double Area()
        {
            double areaTotal = 0;

            foreach (Figura figura in Figuras)
            {
                areaTotal += figura.Area();
            }

            return areaTotal;
        }
    }
}
