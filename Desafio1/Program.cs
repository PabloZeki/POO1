using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

//1.Crear un proyecto de consola .Net Framework.
//2.Crear la clase Telefono (recordemos que una clase va en un archivo nuevo; 
//click derecho en el proyecto, agregar, class).
//3.Agregale los siguientes atributos:
  //1.Modelo string.
  //2.Marca string.
  //3.NumeroTelefonico string.
  //4.CodigoOperador int (1, 2 o 3).
//4.Agregale las propiedades correspondientes. Podés hacer el formato largo o el corto.
  //1.Modelo: solo lectura. Es decir, solo get.
  //2.Marca: solo lectura.
  //3.NumeroTelefonico: lectura y escritura.
//5.CodigoOperador: lectura y escritura. Validar escritura que solo admita 1, 2 o 3, caso 
    //contrario escribir un cero.
//6.Agregar Constructor que reciba Modelo y Marca.
//7.Crear algunos objetos en el main de Program y probar escribirle datos y mostrar en 
    //pantalla el estado del Telefono.
//8.Agregar método Llamar() sin parámetros que devuelva un string con la leyenda
  //  "Realizando llamada...".
//9.Sobrecargar el método Llamar(string contacto) para que reciba un contacto y 
    //devuelva un string con la leyenda "Llamando a " + contacto
//10.Probar métodos en el main mostrando en pantalla el comportamiento de los objetos.

namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefono t1 = new Telefono("Galaxy S20","Samsung");

            Console.WriteLine("La marca del celular que me gusta es..." + t1.Marca + "El modelo..." + t1.Modelo);

           
            Console.WriteLine("Ingrese numero telefonico por favor: ");
            t1.NumeroTelefonico = Console.ReadLine();

            Console.WriteLine("Ingrese codigo de operador por favor (1 a 3): ");
            t1.CodigoOperador = int.Parse(Console.ReadLine());

            Console.WriteLine("El numero de telefono ingresado es: " + t1.NumeroTelefonico);
            Console.WriteLine("El codigo de operador ingresado fue el: " + t1.CodigoOperador);

            Console.WriteLine(t1.llamar("Andruu"));
            Console.WriteLine(t1.llamar());
           


            Console.ReadKey();
        }
    }
}
