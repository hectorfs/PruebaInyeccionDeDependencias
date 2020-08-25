using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaInyeccionDeDependencias
{
    class Program
    {
        static void Main(string[] args)
        {
            IMeteoReferencia termometro = new Termometro();
            termometro.Valor = 20;
            EstacioMeteorologica estacion = new EstacioMeteorologica(termometro);
            estacion.MostrarDatos();

            Console.Read();
        }
    }
}
