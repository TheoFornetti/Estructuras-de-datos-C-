using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    //Hacemos una impementacion basada en la lista ligada
    internal class CStack
    {
        //Ancla o encabezado del stack 
        private CNodo ancla;

        //Esta variable de referencia nos ayuda a trabajar con el stack 
        private CNodo trabajo;

        public CStack()
        {

            //Instanciamos  el ancla 
            ancla = new CNodo();

            //Al estar vacio el siguiente valor es null
            ancla.Siguiente = null;
        }

        //Push 

        public void Push(int pDato)
        {

            //Creamos el nodo temporal 
            CNodo temp = new CNodo();
            temp.Dato = pDato;

            //Conectamos el nodo temporal a la lista 
            temp.Siguiente = ancla.Siguiente;

            //Conectamos el ancla al temporal
            ancla.Siguiente = temp;
        }

        //POP
        public int Pop()
        {
            int valor = 0;

            //Se lleva a cabo el trabajo solamente si hay elementos en el stack 
            if (ancla.Siguiente != null)
            {
                //Obtenemos el dato correspondiente 
                trabajo = ancla.Siguiente;
                valor = trabajo.Dato;

                //Lo sacamos dedl Stack 
                ancla.Siguiente = trabajo.Siguiente;
                trabajo.Siguiente = null;
            }
            return valor;
        }

        //Peek 
        public int Peek()
        {
            int valor = 0;

            //Se lleva a cabo el trabajo solamente si hay elementos en el stack 
            if (ancla.Siguiente != null)
            {
                //Obtenemos el dato correspondiente 
                trabajo = ancla.Siguiente;
                valor = trabajo.Dato;

            }
            return valor;


        }

        //Transversa 
        public void Transversa() {

            //Trabajo al inicio 
            trabajo = ancla;

            //recorremos hasta encontrar el final 

            while (trabajo.Siguiente != null) {
                //Avanzamos trabajo
                trabajo = trabajo.Siguiente;

                //Obtenemos le dato y lo mmostramos 
                int d = trabajo.Dato;
                Console.WriteLine("[{0}]", d);
            }
        }
    }
}
