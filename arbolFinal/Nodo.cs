using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arbolFinal
{
    class Nodo
    {
        public Nodo Siguiente { get; set; }
        public Nodo Anterior { get; set; }


        public Nodo hijoI { get; set; }
        public Nodo hijoD { get; set; }

        public char Dato { get; set; }


        public Nodo(char dato)
        {
            this.Dato = dato;
        }



        public override string ToString()
        {
            return Dato.ToString();
        }


    }
}
