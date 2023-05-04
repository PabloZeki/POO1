using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplolavarropas
{
    internal class Lavarropas
    {

        public Lavarropas(string color,string marca,string conectividadwifi)
        {
            this.color = color;
            this.marca = marca;
            this.conectividadwifi = conectividadwifi;

        }


        private string color;
        private string marca;
        public string tipo { get; set; }
        private string conectividadwifi;
        private int capacidad;

        public string Color
        {
            get { return color; }
        }
        public string Marca
        {
            get { return marca; }
        }
        public string Conectividadwifi
        {
            get { return conectividadwifi; }
        }
        public int Capacidad
        {
            get { return capacidad; }
            set
            {
                if (value >= 8  && value < 24)
                {
                    capacidad = value;
                }
                else
                {
                    capacidad = 0;
                }
            }

        }
        public string lavar()
        {
            return "Seleccione el programa de lavado que desee...";
        }
        public string lavar(string rapido)
        {
            return "Programa seleccionado..." + rapido;
        }

    }
}
