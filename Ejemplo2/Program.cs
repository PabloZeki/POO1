using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Primer lote con 10 registros de productos, cada producto tiene:
            // - Codigo de articulo ( 3 digitos no correlativos )
            // - Precio                                            // lote de carga ejemplos 
            // - Codigo de marca ( 1 a 10 )

            Articulo[] articulos = new Articulo[10]; // un vector de articulos con mi clase Articulo donde tengo todos los atributos 
                                                       // ya cargados de cod art,precio,cod marca.solo basta con crear un solo vector
            for (int i = 0; i < 10; i++)
            {
                articulos[i] = new Articulo();
                Console.WriteLine("Ingrese los datos del producto...");

                Console.WriteLine("Ingrese codigo de articulo: ");
                articulos[i].CodigoArticulo = int.Parse(Console.ReadLine());  // carga del vector con 10 articulos 3 vectores en 1
                Console.WriteLine("Ingrese precio: ");
                articulos[i].Precio = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese codigo de marca: ");
                articulos[i].CodigoMarca = int.Parse(Console.ReadLine());

            }


          // Segundo lote con las ventas de la semana. Cada venta tiene:
            // - Codigo de articulo
            // - Cantidad                                           // lote de proceso ejemplos 
            // - Codigo cliente ( 1 a 100 )
          // Este lote corta con codigo de cliente 0.

            Ventas v1  = new Ventas();   // creo una venta no hace falta crear un vector porque se va pisando
            Console.WriteLine("Ingrese las ventas de la semana...");


            Console.WriteLine("Ingrese codigo de articulo: ");
            v1.CodigoArticulo = int.Parse(Console.ReadLine());

            while(v1.CodigoCliente != 0)
            {
                Console.WriteLine("Ingrese codigo de articulo: ");
                v1.CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese cantidad por favor: ");
                v1.Cantidad = int.Parse(Console.ReadLine());

                // procesamos


                Console.WriteLine("Ingrese codigo de articulo: ");
                v1.CodigoArticulo = int.Parse(Console.ReadLine());
            }
        }
    }
}
