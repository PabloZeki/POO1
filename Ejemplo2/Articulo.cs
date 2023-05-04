using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    internal class Articulo
    {
        // - Codigo de articulo ( 3 digitos no correlativos )
        // - Precio                                            // lote de carga ejemplos 
        // - Codigo de marca ( 1 a 10 )

        public int CodigoArticulo { get; set; }  // aca podemos sacar el set y queda el get para solo lectura
        public float Precio { get; set; }    // manera corta de cargar propiedades de los atributos usando prop y tab x 2

        private int codMarca;   // aca lo hacemos de la forma larga para validar cod marca ( 1 a 10 )

        public int CodigoMarca
        {
            get { return codMarca; }
            set
            {
                if(value > 0 && value < 11)
                {
                    codMarca = value;   // aca validamos para que nos tipee el usuario numeros del 1 al 10 
                }else
                {
                    codMarca = -1;
                }
            }
        }

    }
}
