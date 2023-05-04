using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Botella
    {
        //capacidad maxima: 100
        //cantidadActual: inicia en 0
        //metodo recarga: carga al 100 y devuelve el costo de recargar. 50$ cada 100

        public Botella(string color, string material) // constructor echo por nosotros para cargar por unica vez el color
        {                                             // y el material,cosas que no cambian en la botella,no hace falta ni get ni set
            this.color = color;
            this.material = material;   // con el this apuntamos a que queremos recibir los parametros de color 
            capacidad = 100;            // y material que recibimos del main es un apuntador el this
            cantidadActual = 0;         // ponemos la capacidad en 100 porque es la capacidad maxima y no la vamos a tocar
        }
        // Sobrecarga de constructor

        public Botella() { }   // Constructor vacio para usar mas adelante pero con distintos parametros

        ~Botella()
        {                   // ejemplo de destructor, se usa poco y nada..lleva ~ de la ñ
            // la logica
        }

        public string Color
        {
            get { return color; }    // para mostrar lo que cargue en el constructor
        }
         public string Material
        {
            get { return material; }   // mostrar el contenido del contructor solo get

        }
        public int Capacidad
        {
            get { return capacidad; }  // mostramos el get o la lectura 
        }
        public int CantidadActual
        {
            get { return cantidadActual; }
        }

        // Botella: Capacidad,Color,Material.
        private int capacidad;
        private string color;
        private string material;
        private int cantidadActual;

        // PROPIEDAD O prop
       // public int Capacidad
        //{
          //  get { return capacidad; }    // esto seria la forma que hicimos con persona pero mas resumido en una sola funcion
            //set { capacidad = value; }
        //}



        // public string Color
       // {
       //     get { return color; }
       //     set { color = value; }
       // }
       // public string Material
       // {
       //     get { return material; }
        //    set { material = value; }
       // }

        // METODOS

       public float recargar()           // metodo o comportamiento de recargar la botella
        {
            if(cantidadActual > 0)
            {
                int dif = capacidad - cantidadActual;
                // 100 50                       // regla de 3 simple
                // dif 
                float monto = dif * 50 / 100;  // en este caso calculamos si la botella tiene algo de liquido se lo descontamos
                cantidadActual+= dif;
                return monto;
            }
            else
            {
                cantidadActual = 100;
                return 50;
            }
            
        } 
        public float recargar(int cantidad)
            {
                cantidadActual += cantidad;   // creamos una sobrecarga por si nos piden cargar una cantidad especifica de la botella

                return cantidad * 50 / 100;  // calculamos cuanto le debemos cobrar por la cantidad que nos ingresa
                // 100  50
                // canti
                

            }

    }
}       
