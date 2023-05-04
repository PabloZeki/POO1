using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Persona
    {

        //Persona: Edad,Sueldo,Nombre.
        // ATRIBUTOS O MIEMBROS.

        private int edad;
        private float sueldo;       //modificadores de visibilidad (public o private)
        private string nombre;
        public void setEdad(int e)
        {

            edad = e;    //con esta funcion la variable e desde afuera desde el main me va a cargar la edad en mi atributo edad
        }
        public int getEdad()
        {
            return edad;        // para obtener o leer lo que tiene la variable edad
        }

        public float Sueldo
        {
            get { return sueldo; }
            set { sueldo = value; }
        }

       public Persona(string nombre)
        {
            this.nombre = nombre;     // pedimos el nombre por primera ves pero esta privado 
        }

        public string saludar()            // metodo o comportamiento en este caso la persona saluda
        {
            return "Hola soy... " + nombre;
        }
        // SOBRECARGA DE METODO
        public string saludar(string nombre)
        {
            return "Hola" + nombre + " soy..." + this.nombre; // con el this nos referimos el nombre de la clase persona
                                                               // el otro nombre que pedimos por parametro es el de la sobrecarga en este caso
        } // para saludar especificamente a alguien o tmb lo podemos a cmabiar a otro nombre personaje por ejemplo y ahi sacamos el this
        public string hablar()              // otro metodo hablar
        {
            return "Como te encuentras el dia de hoy??";
        }
    }
   

}
