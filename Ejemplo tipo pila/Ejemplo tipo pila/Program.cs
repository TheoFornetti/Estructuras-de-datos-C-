using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_tipo_pila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string expresion = "";
            char s = ' ';
            CStack pila = new CStack();

            //Pedimos la expresion a evaluar 
            Console.WriteLine("Dame la expresion a evaluar");
            expresion=Console.ReadLine();

            foreach (char c in expresion) { 
                 
                //Verificamos que sea simbolo de apertura 
                if (c=='('  || c=='{' || c == '[')
                {
                    pila.Push(c);
                }

                //verificamos que sea simbolo de cierre
                if (c == ')' || c == '}' || c == ']')
                {
                    if (pila.Vacio())
                    {
                        Console.WriteLine("Exceso de simbolos de cierre");
                    }
                    else {
                        //Obtenemos el caracter correspondiente 
                        s = pila.Pop();

                        if (s == '(' && c != ')') {
                            Console.WriteLine("Se esperaba )");
                        }
                        if (s == '[' && c != ']')
                        {
                            Console.WriteLine("Se esperaba ]");
                        }
                        if (s == '{' && c != '}')
                        {
                            Console.WriteLine("Se esperaba }");
                        }
                    }
                }

            }
            if (pila.Vacio() == false) {
                Console.WriteLine("Exceso de simbolos de apertura");
            }

            Console.ReadKey();
        }
    }
}
