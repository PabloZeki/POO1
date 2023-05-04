using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Perro
    {
        public Perro(string nombreperro,string color)   // usamos nuevamente el constructor 
        {
            this.nombreperro = nombreperro;
            this.color = color; 
        }
        private string nombreperro;
        private string color;
        public string Origen { get; set; }   // usamos prop para cargar facil set y get

        public string Nombreperro
        {
            get { return nombreperro;}   // si quiero devolver el nombre del perrro o el color le meto un get asi
        }
        public string Color
        {
            get { return color; } // aca lo mimso solo get de lectura no se puede setear o modificar
        }


    }
   
    
}
