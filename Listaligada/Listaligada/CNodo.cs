using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listaligada
{
    internal class CNodo
    {
        //Aqui colocamos el dato o datos que guarda el nodo
        private int dato;

        //Esta variable de referencia es usada para apuntar al siguiente nodo 
        private CNodo siguiente = null;

        //Propiedades que usaremos 
        public int Dato { get => dato; set => dato = value; }
        internal CNodo Siguiente { get => siguiente; set => siguiente = value; }
        
        //Para facilitar la impresion
        public override string ToString()
        {
            return String.Format("[{0}]", dato);
        }
    }
}
