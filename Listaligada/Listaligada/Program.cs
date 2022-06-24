using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listaligada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CListaLigada miLista = new CListaLigada();

            miLista.Adicionar(3);
            miLista.Adicionar(4);
            miLista.Adicionar(5);
            miLista.Adicionar(6);
            miLista.Adicionar(7);

            miLista.Transversa();
            Console.WriteLine(miLista.EstaVacia()); 

            //miLista.Vaciar();
            //Console.WriteLine(miLista.EstaVacia());

            //miLista.Transversa();
            CNodo e = miLista.Buscar(3);
            Console.WriteLine(miLista.BuscarIndice(3));
            Console.WriteLine(e); 
            Console.ReadKey();
        }
    }
}
