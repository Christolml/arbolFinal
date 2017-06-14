using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace arbolFinal
{
    class Arbol
    {
        public Nodo Raiz { get; set; }

        private Nodo Primero;
        private Nodo Ultimo;


        private Caracter primeroPost;
        private Caracter ultimoPre;

        string mostrarPost2;

        string mostrarPre2;


        /// <Principio>
        /// Lee mi cadena que pido al inicio y los separa por los caracteres que lo componen
        /// </summary>
        /// <param name="entrada"></param>
        /// <returns></returns>
        public string leer(string entrada)
        {
            string formula = entrada, salida="";
            char[] vector = new char[formula.Length];

            using (StringReader sr = new StringReader(formula))
            {
                sr.Read(vector, 0, formula.Length);

                for(int i=0;i<formula.Length;i++)
                {
                    Nodo prueba = new Nodo(vector[i]);
                    salida += vector[i];
                    agregarProducto(prueba);
                }
            }

            return salida;
          }

        /// <Lista_Doble>
        /// Este lo agrega en una lista doble
        /// </summary>
        /// <param name="nuevo"></param>
        public void agregarProducto(Nodo nuevo)
        {
            if (Primero == null)
            {
                Primero = nuevo;
                Ultimo = nuevo;
            }
            else
                agregarProducto(Primero, nuevo);

        }     

        /// <Recursivo>
        /// Recursivo de agregar lista doble
        /// </summary>
        /// <param name="ultimo"></param>
        /// <param name="nuevo"></param>
        private void agregarProducto(Nodo ultimo, Nodo nuevo)
        {
            if (ultimo.Siguiente == null)
            {
                Ultimo = nuevo;
                ultimo.Siguiente = nuevo;
                Ultimo.Anterior = ultimo;
            }
            else
                agregarProducto(ultimo.Siguiente, nuevo);

        }

        /// <Se_agregan_los_hijos_correspondientes>
        /// Hace los recorridos y va checando los caracteres de *,/,+,- y va agregando sus hijos correspondientes por
        /// medio de un switch, hay dos while diferentes y cada uno con un switch de cierta condición para que en la primera 
        /// vuelta detecta la multiplicación(*) y la división(/) y en el segundo while junto con su switch es para detectar
        /// las sumas(+) y las restas(-), en pocas palabras aqui es donde se va asignando los hijos con ayuda de los métodos de
        /// agregarIzquierdo y agregarDerecho que estan abajo
        /// </summary>
        public void recorrido()
        {
            Nodo Actual = Primero;

            while (Actual != null)
            {
                switch(Actual.Dato)
                {
                    case '*':
                        agregarIzquierdo(Actual);
                        agregarDerecho(Actual);
                        Raiz = Actual;
                        break;
                    case '/':
                        agregarIzquierdo(Actual);
                        agregarDerecho(Actual);
                        Raiz = Actual;
                        break;
                }
                Actual = Actual.Siguiente;
            }

            Actual = Primero;
            while (Actual != null)
            {
                switch (Actual.Dato)
                {
                    case '+':
                        agregarIzquierdo(Actual);
                        agregarDerecho(Actual);
                        Raiz = Actual;
                        break;
                    case '-':
                        agregarIzquierdo(Actual);
                        agregarDerecho(Actual);
                        Raiz = Actual;
                        break;

                }
                Actual = Actual.Siguiente;

            }

        }

        /// <Manda_el_hijo_a_la_izquierda>
        /// Con este mando los hijos a la izquierda de su nodo raiz
        /// </summary>
        /// <param name="nuevo"></param>
        public void agregarIzquierdo(Nodo nuevo)
        {
            Nodo atras = nuevo.Anterior;
            nuevo.hijoI = atras;
            atras = atras.Anterior;
            if(atras==null)
            {
                Primero = nuevo;
                Primero.Anterior = null;
                Primero.hijoI.Siguiente = null;
            }
            else
            {
                nuevo.Anterior = atras;
                atras.Siguiente = nuevo;
                nuevo.hijoI.Anterior = null;
                nuevo.hijoI.Siguiente = null;
            }

        }

        /// <Manda_el_hijo_a_la_derecha>
        /// Con este mando los hijos correspondientes a la derecha de su nodo raiz
        /// </summary>
        /// <param name="nuevo"></param>
        public void agregarDerecho(Nodo nuevo)
        {
            Nodo despues = nuevo.Siguiente;
            nuevo.hijoD = despues;

            despues = despues.Siguiente;
            if(despues==null)
            {
                Ultimo=nuevo;
                Ultimo.Siguiente = null;
                Ultimo.hijoD.Anterior = null;
            }
            else
            {
                nuevo.Siguiente = despues;
                despues.Anterior = nuevo;
                nuevo.hijoD.Anterior = null;
                nuevo.hijoD.Siguiente = null;
            }


        }

        /// <Obtener_el_String_PreOrden_del_arbol>
        /// Me saca el orden preOrden
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public string preOrden(Nodo r)
        {
            string mostrarPre = "";
            mostrarPre2 += r.ToString();
            mostrarPre += r.ToString() + ",";
            if (r.hijoI != null)
                mostrarPre += preOrden(r.hijoI);
            if (r.hijoD != null)
                mostrarPre += preOrden(r.hijoD);

            return mostrarPre;
        }

        /// <Obtener_el_PostOrden_del_arbol>
        /// Me saca el postOrden
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public string postOrden(Nodo r)
        {
            string mostrarPost = "";
            if (r.hijoI != null)
                mostrarPost += postOrden(r.hijoI);
            if (r.hijoD != null)
                mostrarPost += postOrden(r.hijoD);
            mostrarPost2 += r.ToString();
            mostrarPost += r.ToString() + ",";
            return mostrarPost;
        }

//*********************************** Calculos//

        public int calculoPreOrden()
        {
            CalculoPre nuevo = new CalculoPre();
            leerPre(mostrarPre2);
            Caracter ultimo = ultimoPre;

            for(int i=0;i<mostrarPre2.Length;i++)
            {
                if(ultimo.Dato != "*" && ultimo.Dato != "/" && ultimo.Dato != "+" && ultimo.Dato != "-")
                { 
                    nuevo.agregarPilaPre(new Caracter(ultimo.Dato));
                    ultimo = ultimo.Anterior;
                }
                else
                    switch (ultimo.Dato)
                    {
                        case "*":
                            string primero = nuevo.verUltimo().Dato;
                            nuevo.sacarUltimo();
                            string segundo = nuevo.verUltimo().Dato;
                            nuevo.sacarUltimo();
                  
                            int ultimoPre = Convert.ToInt16(primero), anteultimoPre= Convert.ToInt16(segundo), multiplicar;
                            multiplicar=ultimoPre*anteultimoPre;
                   
                            string convertido = Convert.ToString(multiplicar);
                            nuevo.agregarPilaPre(new Caracter(convertido));
                            ultimo = ultimo.Anterior;
                            break;
                        case "/":
                            string primero1 = nuevo.verUltimo().Dato;
                            nuevo.sacarUltimo();
                            string segundo1 = nuevo.verUltimo().Dato;
                            nuevo.sacarUltimo();

                            int ultimoPre1 = Convert.ToInt16(primero1), anteultimoPre1 = Convert.ToInt16(segundo1), dividir;
                            dividir = ultimoPre1 / anteultimoPre1;

                            string convertido1 = Convert.ToString(dividir);
                            nuevo.agregarPilaPre(new Caracter(convertido1));
                            ultimo = ultimo.Anterior;
                            break;
                        case "-":
                            string primero2 = nuevo.verUltimo().Dato;
                            nuevo.sacarUltimo();
                            string segundo2 = nuevo.verUltimo().Dato;
                            nuevo.sacarUltimo();

                            int ultimoPre2 = Convert.ToInt16(primero2), anteultimoPre2 = Convert.ToInt16(segundo2), restar;
                            restar = ultimoPre2 - anteultimoPre2;

                            string convertido2 = Convert.ToString(restar);
                            nuevo.agregarPilaPre(new Caracter(convertido2));
                            ultimo = ultimo.Anterior;
                            break;
                        case "+":
                            string primero3 = nuevo.verUltimo().Dato;
                            nuevo.sacarUltimo();
                            string segundo3 = nuevo.verUltimo().Dato;
                            nuevo.sacarUltimo();

                            int ultimoPre3 = Convert.ToInt16(primero3), anteultimoPre3 = Convert.ToInt16(segundo3), sumar;
                            sumar = ultimoPre3 + anteultimoPre3;

                            string convertido3 = Convert.ToString(sumar);
                            nuevo.agregarPilaPre(new Caracter(convertido3));
                            ultimo = ultimo.Anterior;
                            break;
                    }
            }
            int resultado = Convert.ToInt16(nuevo.verUltimo().Dato);
            return resultado;
        }




        /// <Principio>
        /// Lee mi cadena que pido al inicio y los separa por los caracteres que lo componen
        /// </summary>
        /// <param name="entrada"></param>
        /// <returns></returns>
        public void leerPre(string entrada)
        {
            string formula = entrada;
            char[] vector = new char[formula.Length];

            using (StringReader sr = new StringReader(formula))
            {
                sr.Read(vector, 0, formula.Length);

                for (int i = 0; i < formula.Length; i++)
                {
                    Caracter prueba = new Caracter(vector[i].ToString());
                    agregarPre(prueba);
                }
            }

        }

        /// <Lista_Doble>
        /// Este lo agrega en una lista doble
        /// </summary>
        /// <param name="nuevo"></param>
        public void agregarPre(Caracter nuevo)
        {
            if (primeroPost == null)
            {
                primeroPost = nuevo;
                ultimoPre = nuevo;
            }
            else
                agregarPre(primeroPost, nuevo);

        }

        /// <Recursivo>
        /// Recursivo de agregar lista doble
        /// </summary>
        /// <param name="ultimo"></param>
        /// <param name="nuevo"></param>
        private void agregarPre(Caracter ultimo, Caracter nuevo)
        {
            if (ultimo.Siguiente == null)
            {
                ultimoPre = nuevo;
                ultimo.Siguiente = nuevo;
                ultimoPre.Anterior = ultimo;
            }
            else
                agregarPre(ultimo.Siguiente, nuevo);

        }





        public int calculoPostOrden()
        {
            CalculoPre nuevo = new CalculoPre();
            leerPre(mostrarPost2);
            Caracter primero = primeroPost;

            for (int i = 0; i < mostrarPost2.Length; i++)
            {
                if (primero.Dato != "*" && primero.Dato != "/" && primero.Dato != "+" && primero.Dato != "-")
                {
                    nuevo.agregarPilaPre(new Caracter(primero.Dato));
                    primero = primero.Siguiente;
                }
                else
                    switch (primero.Dato)
                    {
                        case "*":
                            string derecha = nuevo.verUltimo().Dato;
                            nuevo.sacarUltimo();
                            string izquierda = nuevo.verUltimo().Dato;
                            nuevo.sacarUltimo();

                            int primeroPost = Convert.ToInt16(izquierda), despPrimeroPost = Convert.ToInt16(derecha), multiplicar;
                            multiplicar = primeroPost * despPrimeroPost;

                            string convertido = Convert.ToString(multiplicar);
                            nuevo.agregarPilaPre(new Caracter(convertido));
                            primero = primero.Siguiente;
                            break;
                        case "/":
                            string derecha1 = nuevo.verUltimo().Dato;
                            nuevo.sacarUltimo();
                            string izquierda1 = nuevo.verUltimo().Dato;
                            nuevo.sacarUltimo();

                            int primeroPost1 = Convert.ToInt16(izquierda1), despPrimeroPost1 = Convert.ToInt16(derecha1), dividir;
                            dividir = primeroPost1 / despPrimeroPost1;

                            string convertido1 = Convert.ToString(dividir);
                            nuevo.agregarPilaPre(new Caracter(convertido1));
                            primero = primero.Siguiente;
                            break;
                        case "-":
                            string derecha2 = nuevo.verUltimo().Dato;
                            nuevo.sacarUltimo();
                            string izquierda2 = nuevo.verUltimo().Dato;
                            nuevo.sacarUltimo();

                            int primeroPost2 = Convert.ToInt16(izquierda2), despPrimeroPost2 = Convert.ToInt16(derecha2), restar;
                            restar = primeroPost2 - despPrimeroPost2;

                            string convertido2 = Convert.ToString(restar);
                            nuevo.agregarPilaPre(new Caracter(convertido2));
                            primero = primero.Siguiente;
                            break;
                        case "+":
                            string derecha3 = nuevo.verUltimo().Dato;
                            nuevo.sacarUltimo();
                            string izquierda3 = nuevo.verUltimo().Dato;
                            nuevo.sacarUltimo();

                            int primeroPost3 = Convert.ToInt16(izquierda3), despPrimeroPost3 = Convert.ToInt16(derecha3), sumar;
                            sumar = primeroPost3 + despPrimeroPost3;

                            string convertido3 = Convert.ToString(sumar);
                            nuevo.agregarPilaPre(new Caracter(convertido3));
                            primero = primero.Siguiente;
                            break;
                    }
            }
            int resultado = Convert.ToInt16(nuevo.verUltimo().Dato);
            return resultado;
        }


    }
}
