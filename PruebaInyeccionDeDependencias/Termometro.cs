using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaInyeccionDeDependencias
{
    public class Termometro : IMeteoReferencia
    {
        public int Valor { get; set; }

        public string Mostrar()
        {
            return string.Format("Temperatura:{0} º", Valor);
        }
    }
}
