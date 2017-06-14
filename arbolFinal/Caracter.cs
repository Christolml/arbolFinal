using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arbolFinal
{
    class Caracter
    {
        public Caracter Siguiente { get; set; }
        public Caracter Anterior { get; set; }

        public string Dato { get; set; }


        public Caracter(string dato)
        {
            this.Dato = dato;
        }

        public override string ToString()
        {
            return Dato.ToString();
        }






    }
}
