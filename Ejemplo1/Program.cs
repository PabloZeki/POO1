using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
     class Program          // una clase puede tener muchas funciones
    {
        static void Main(string[] args)
        {
            // Persona: Edad,Sueldo,Nombre.
            int Edad;
            float Sueldo;
            string Nombre;
            int[] edades = new int[10];        // si quisiera guardar 10 edades
            float[] sueldos = new float[10];     // si quisiera guardar 10 sueldos
            string[] nombres = new string[10];     // si quisiera guardar 10 nombres

            Persona p1 = new Persona("Pablo"); // estoy usando el tipo de dato Persona que cree o la clase
            p1.setEdad(20);            // aca le mando el int de la edad (20) a la funcion void de la clase persona
           // p1.Nombre = "Pablin";
            p1.Sueldo = 180000;
            Console.WriteLine(p1.saludar());  // mostrar los metodos o comportamientos saludo general con mi nombre

            Console.WriteLine(p1.saludar(" Ezequiel ")); // sobrecarga para saludar con nombre especifico

            Console.WriteLine(p1.hablar()); // mostrar los metodos o comportamientos

            Console.WriteLine("La edad de la persona es: " + p1.getEdad());  // si quiero leer o motrar lo que tiene edad



            Botella b1 = new Botella("Rojo","Plastico"); // aca mandamos los parametros al constructor del color y material de la clase

            Botella b2 = new Botella(); // Sobrecarga de constructor con parametros vacios.

          //  Console.WriteLine("Ingrese la capacidad de la botella: "); // pedir datos al usuario
           // b1.Capacidad = 200;

          //  b1.Color = "Rojo";
          // b1.Material = "Plastico"; 
            
            Console.WriteLine(" La capacidad de la botella es: " + b1.Capacidad+ " Y su color es: " + b1.Color + " Su material es: " + b1.Material); // se lee como una variable comun
            Console.WriteLine("La cantidad actual de la botella es : " + b1.CantidadActual);

            b1.recargar(30);      // invocamos la funcion o metodo recargar pero con sobrecarga en este caso cantidad
            Console.WriteLine("Luego de recargar la cantidad de la botella es: " + b1.CantidadActual);

            b1.recargar();      // invocamos la funcion o metodo recargar
            Console.WriteLine("Luego de recargar la cantidad de la botella es: " + b1.CantidadActual);
           
          

            Perro f1 = new Perro("Firulais","Amarillo Patito");      // aca seleccionamos por ejemplo perro 1 o firu 1 de la clase Perro

           // f1.NombrePerro = "Firulais";
            f1.Origen = "Salchipapas";
           // f1.Color = "Amarillo Patito";

            Console.WriteLine(" Los atributos del perro son..." + f1.Color + " El nombre es..." + f1.Nombreperro+ " El origen es..." + f1.Origen);


            Console.ReadKey();
        }
        
    }
}
