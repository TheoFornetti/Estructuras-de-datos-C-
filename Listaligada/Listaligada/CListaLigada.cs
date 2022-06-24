using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listaligada
{
    internal class CListaLigada
    {
        //Es el ancla o encabezado de la lista
        //Indica el inicio de la lista ligada 
        //Se pueded usar para guardar informacion, pero no es recomendable
        private CNodo ancla;

        //Esta variable de referencia nos ayuda a trabajar con la lista 
        //Sirev para indicar el nodo en el cual estamos trabajando en ese momento
        private CNodo trabajo;

        //Esta variable de referencia apoya en ciertas operaciones de la lista
        private CNodo trabajo2;

        public CListaLigada()
        {
            //Instasnciamos el ancla
            ancla = new CNodo();

            //Como es una lista vacia su siguiente es null
            ancla.Siguiente = null;
        }

        //Recorre todoa la lista 
        public void Transversa()
        {
            //Trabajo al inicio 
            trabajo = ancla;

            //Recorremos hasta encontrar el final 
            while(trabajo.Siguiente != null)
            {
                //Avanzamos trabajo 
                trabajo = trabajo.Siguiente;

                //Obtenemos el dato y lo mostramos
                int d = trabajo.Dato;

                Console.Write( d + " ,");
            }
            Console.WriteLine();
        }

        //Adicion de un nuevo elemnto 
        //La adicion siempre va al final 
        public void Adicionar(int pDato)
        {
            //trabajo al inicio 
            trabajo = ancla;

            //Recorremos hasta encontrar el final 
            while(trabajo.Siguiente != null)
            {
                //Avanzamos en trabajo, osea en cada nodo de la lista
                trabajo = trabajo.Siguiente;
            }

            //Creamos un nuevo nodo
            CNodo temp = new CNodo();

            //Insertamos el Dato
            temp.Dato = pDato;

            //Finalizamos correctamente
            temp.Siguiente = null;

            //ligamos el ultimo nodo encontrado con el recien creado 
            trabajo.Siguiente = temp;
        }

        //Vaciar la lista
        public void Vaciar()
        {
            ancla.Siguiente = null;

            //En lengiajes no administrados tenemos que liberar la memoria adecuadamente 
            // En c# se aprovecha el recolector de basura 
        }

        //Indica si la lista esta vacia o no
        public bool EstaVacia()
        {
            if (ancla.Siguiente == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Este metodo regresa el nodo con la primera ocurrencia del dato
        public CNodo Buscar(int pDato)
        {
            if (EstaVacia() == true)
            {
                return null;
            }
            trabajo2 = ancla;

            //Recorremos para ver si encontramos el dato
            while (trabajo2.Siguiente != null)
            {
                trabajo2 = trabajo2.Siguiente;

                //Al encontrarlo lo regresamos 
                if (trabajo2.Dato == pDato)
                {
                    return trabajo2;
                }

            
            }
            //No se encontro, regresamos null
            return null;
        }

        //Busca el indice donde se encuentra la primera ocurrencia del dato 
        public int BuscarIndice (int pDato)
        {
            int n = -1;
            trabajo = ancla;
            while (trabajo.Siguiente != null) {
                trabajo = trabajo.Siguiente;
                n++;
                if(trabajo.Dato == pDato)
                {
                    return n;
                }
            }

            return -1;

        }

        //Encuentra el nodo anterior 
        //Si esta en el primer nodo se regresa el ancla 
        //Si el dato no existe se regresa el ultimo nodo 
        public CNodo BuscarAnterior(int pDato) {
            trabajo2 = ancla;

            while (trabajo2.Siguiente != null && trabajo2.Siguiente.Dato != pDato)
            {
                trabajo2 = trabajo2.Siguiente;
            }
            return trabajo2;
        }

        //Borrar la primera ocurrencia de la lista ligada 
        public void Borrar(int pDato) {

            //Verificamos que se tengan datos
            if (EstaVacia() == true)
            {
                return;
            }

            //Buscamos los nodos con los que trabajemos
            CNodo anterior = BuscarAnterior(pDato); 

            CNodo encontrado = Buscar(pDato);

            //Si no hay nodo a borrar, salimos
            if (encontrado == null) {
                return;
            }

            //Saltamos el nodo
            anterior.Siguiente = encontrado.Siguiente;

            // Quitamos el actual de la lista
            encontrado.Siguiente = null;
        }

        //Insertar el dato pValor despues la primera ocurrecncia del dato pasado a pdonde
        public void Insertar(int pDonde, int pValor) {

            //Encontramos la posicion 
            trabajo = Buscar(pDonde);

            //Verificamos que exista donde vamos a insertar
            if (trabajo == null) {
                return;
            }

            //Creamos el nodo temporal a insertar 
            CNodo temp = new CNodo();
            temp.Dato = pValor;

            //Conectamos el temporal a la lista 
            temp.Siguiente = trabajo.Siguiente;

            //Conectamos trabajo a temporal 
            trabajo.Siguiente = temp;
        }

        //Insertar un dato al inicio 
        public void InsertarInicio(int pDato)
        {
            //Creamos el nodo temporal 
            CNodo temp = new CNodo();
            temp.Dato = pDato;

            //Conectamos temporal a la lista
            temp.Siguiente = ancla.Siguiente;

            //Conectamos el ancla al temporal
            ancla.Siguiente = temp;

            
        }

        //Obtenemos la referencia del nodo dado el indice 
        public CNodo ObtenPorIndice(int pIndice) { 
            CNodo trabajo2 = null;
            int indice = -1;

            trabajo = ancla;

            while (trabajo.Siguiente != null) {
                trabajo = trabajo.Siguiente;
                indice++;

                if (indice == pIndice) {
                    trabajo2 = trabajo;
                }
                
            }
            return trabajo2;
        }

        //Creamos un indexer 
        public int this[int pIndice]
        {
            get {
                //Esto puede crear una exepcion si trabajo es igual a null 
                //Colocar codigo de seguridad o usara int?
                trabajo = ObtenPorIndice(pIndice);
                return trabajo.Dato;
            }

            set {
                trabajo = ObtenPorIndice(pIndice);
                if (trabajo != null) { 
                    trabajo.Dato = value;  
                }
            }
        }


    }
}
