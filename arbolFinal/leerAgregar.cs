using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace arbolFinal
{
    class leerAgregar
    {
        public Caracter Primero { get; set; }
        public Caracter Ultimo { get; set; }



        /// <Principio>
        /// Lee mi cadena que pido al inicio y los separa por los caracteres que lo componen
        /// </summary>
        /// <param name="entrada"></param>
        /// <returns></returns>
        public void leer(string entrada)
        {
            string formula = entrada;
            char[] vector = new char[formula.Length];

            using (StringReader sr = new StringReader(formula))
            {
                sr.Read(vector, 0, formula.Length);

                for (int i = 0; i < formula.Length; i++)
                {
                    Caracter prueba = new Caracter(vector[i].ToString());
                    agregar(prueba);
                }
            }

        }

        /// <Lista_Doble>
        /// Este lo agrega en una lista doble
        /// </summary>
        /// <param name="nuevo"></param>
        public void agregar(Caracter nuevo)
        {
            if (Primero == null)
            {
                Primero = nuevo;
                Ultimo = nuevo;
            }
            else
                agregar(Primero, nuevo);

        }

        /// <Recursivo>
        /// Recursivo de agregar lista doble
        /// </summary>
        /// <param name="ultimo"></param>
        /// <param name="nuevo"></param>
        private void agregar(Caracter ultimo, Caracter nuevo)
        {
            if (ultimo.Siguiente == null)
            {
                Ultimo = nuevo;
                ultimo.Siguiente = nuevo;
                Ultimo.Anterior = ultimo;
            }
            else
                agregar(ultimo.Siguiente, nuevo);

        }





    }
}