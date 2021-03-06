using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_tipo_pila
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

        //Metodo para ver si el stack esta vacio
        public bool Vacio() { 
            if (ancla.Siguiente == null)
            {
                return true;
            }
            else
            {
                return false;
            }
                
        }

        //Push 

        public void Push(char pDato)
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
        public char Pop()
        {
            char valor = ' ';

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
        public char Peek()
        {
            char valor = ' ';

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
        public void Transversa()
        {

            //Trabajo al inicio 
            trabajo = ancla;

            //recorremos hasta encontrar el final 

            while (trabajo.Siguiente != null)
            {
                //Avanzamos trabajo
                trabajo = trabajo.Siguiente;

                //Obtenemos le dato y lo mmostramos 
                int d = trabajo.Dato;
                Console.WriteLine("[{0}]", d);
            }
        }
    }
}
