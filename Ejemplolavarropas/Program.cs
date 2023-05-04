using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplolavarropas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lavarropas l1 = new Lavarropas("Blanco","Samsung","Si");

            Console.WriteLine("Ingrese el tipo de lavarropas que posee: ");
            l1.tipo = Console.ReadLine();
            Console.WriteLine("Ingrese la capacidad de lavarropas en kg:");
            l1.Capacidad = int.Parse(Console.ReadLine());


            Console.WriteLine("El lavarropas eleguido por usted es de color: " + l1.Color + " Marca " + l1.Marca + " Conectividad wifi " + l1.Conectividadwifi);
            Console.WriteLine("El tipo de lavarropas eleguido es: " + l1.tipo);
            Console.WriteLine("La capacidad del lavarropas es: " + l1.Capacidad);
            Console.WriteLine(l1.lavar());
            Console.WriteLine(l1.lavar("Eco lavado 30 min"));
            Console.ReadKey();

        }
    }
}
