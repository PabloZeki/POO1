using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Pablo";
          //nombre =  Console.ReadLine(); // aca no hay que hacer la conversion a int . parse,puedo guardar simbolos, caracteres,numeros
            nombre = "Hola como estas..." + nombre;  // al ser una cadena de caracteres le puedo escribir directamente

            int cant = nombre.Length; // lenght es una propiedad de string que nos permite en este caso saber cuantas letras o numeros
                                       // tiene la variable nombre.

            nombre = nombre.ToUpper(); // esto usamos si quermos pasar todo a mayuscula,todo el contenido de nombre

            nombre = nombre.ToLower(); // esto usamos para pasar todo a minuscula.

            nombre = nombre.Replace('a', 'e'); // para hacer reemplazo de un caracter viejo por uno nuevo

            nombre = nombre.Replace("hola", "chau"); // esto para reemplazar palabras completas por otras en este caso el hola por el chau


            Console.WriteLine(nombre + cant);  
            Console.ReadKey();
        }
    }
}
