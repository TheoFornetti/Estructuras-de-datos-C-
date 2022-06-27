using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class CNodo
    {
        //En esta variable colocamos los datos que guarda el nodo 
        private int dato;

        //Esta variable de referencia es utilizada para apuntar al nodo siguiente 
        private CNodo siguiente = null;

        //Propiedades 
        public int Dato { get => dato; set => dato = value; }
        internal CNodo Siguiente { get => siguiente; set => siguiente = value; }

        //Para su facil Impresion 
        public override string ToString()
        {
            return String.Format("[{0}]", dato); 
        }
    }
}
