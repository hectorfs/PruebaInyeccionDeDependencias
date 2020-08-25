using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaInyeccionDeDependencias
{
    public class EstacioMeteorologica
    {
        private IMeteoReferencia termometro;

        public EstacioMeteorologica(IMeteoReferencia termometro)
        {
            this.termometro = termometro;
        }

        public void MostrarDatos()
        {
            Console.WriteLine(
            string.Format("Datos a {0}", DateTime.Now));
            Console.WriteLine(termometro.Mostrar());
        }
    }
}