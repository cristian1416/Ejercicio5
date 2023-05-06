using Ejercicio5.Clases;
using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            GrupoDeFiguras grupo1 = new GrupoDeFiguras();
            grupo1.AgregarFigura(new Circulo() { Radio = 5 });
            grupo1.AgregarFigura(new Rectangulo() { Ancho = 10, Alto = 5 });

            GrupoDeFiguras grupo2 = new GrupoDeFiguras();
            grupo2.AgregarFigura(new Circulo() { Radio = 3 });
            grupo2.AgregarFigura(new Rectangulo() { Ancho = 8, Alto = 4 });

            GrupoDeFiguras grupoTotal = new GrupoDeFiguras();
            grupoTotal.AgregarFigura(grupo1);
            grupoTotal.AgregarFigura(grupo2);

            double areaTotal = grupoTotal.Area(); // Obtener el área total de todas las figuras
        }
    }
}
