using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    internal class Ventas
    {

        // Segundo lote con las ventas de la semana. Cada venta tiene:
        // - Codigo de articulo
        // - Cantidad                                           // lote de proceso ejemplos 
        // - Codigo cliente ( 1 a 100 )
        // Este lote corta con codigo de cliente 0.

        public int CodigoArticulo { get; set; }
        public int Cantidad { get; set; }
        public int CodigoCliente { get; set; }
    }
}
