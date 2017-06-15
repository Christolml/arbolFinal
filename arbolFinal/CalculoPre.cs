using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arbolFinal
{
    class CalculoPre
    {

        private Caracter Primero;
        private Caracter Ultimo;

        public CalculoPre()
        {
            Primero = null;
            Ultimo = null;
        }




        /// <Lista_Doble>
        /// Este lo agrega en una lista doble
        /// </summary>
        /// <param name="nuevo"></param>
        public void agregarPilaPre(Caracter nuevo)
        {
            if (Primero == null)
            {
                Primero = nuevo;
                Ultimo = nuevo;
            }
            else
                agregarPilaPre(Primero, nuevo);

        }

        /// <Recursivo>
        /// Recursivo de agregar lista doble
        /// </summary>
        /// <param name="ultimo"></param>
        /// <param name="nuevo"></param>
        private void agregarPilaPre(Caracter padre, Caracter nuevo)
        {
            if (padre.Siguiente == null)
            {
                Ultimo = nuevo;
                padre.Siguiente = nuevo;
                Ultimo.Anterior = padre;
            }
            else
                agregarPilaPre(padre.Siguiente, nuevo);
        }

        public Caracter verUltimo()
        {
            return Ultimo;
        }


        public void sacarUltimo()
        {
            try
            {
                Ultimo = Ultimo.Anterior;
                Ultimo.Siguiente = null;
            }
            catch
            {
                Primero = null;
                Ultimo = null;
            }
        }


    }
}
