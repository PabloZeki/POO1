using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Telefono
    {
        public Telefono(string modelo,string marca) 
        {
            this.modelo = modelo;
            this.marca = marca;                  // constructor

        }



        private string modelo;
        private string marca;
        private int codigoOperador;    // definimos las propiedades de la clase
        public string NumeroTelefonico { get; set; }   // forma corta

        public string Modelo
        {
            get { return modelo; }
        }

        public string Marca
        {
            get { return marca; }

        }

        public int CodigoOperador
        {
            get { return codigoOperador; }    // forma larga para validar que admita los numeros del 1 al 3

             set {

                    if (value > 0 && value < 4)
                {
                    codigoOperador = value;
                }
                else
                {
                    codigoOperador = 0;
                }


                }



            }

        public string llamar()
        {
            return "Realizando llamada...";
        }
        public string llamar(string contacto)
        {
            return "Llamando a " + contacto;
        }



  
         }
        
}    
