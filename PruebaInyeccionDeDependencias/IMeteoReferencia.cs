using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaInyeccionDeDependencias
{
    public interface IMeteoReferencia
    {
        int Valor { get; set; }
        string Mostrar();
    }
}
