using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Pila ini = new Pila("ini");
            Pila aux = new Pila("fin");
            Pila fin = new Pila("aux");

           

            // Keep the console window open in debug mode.
            Console.WriteLine("Escribe la cantidad de discos.");
            String s = Console.ReadLine();

            if(Int32.TryParse(s, out n)&&n!=0)
            {
                for(int i = n; i>0;i--)
                {
                    Disco d = new Disco();
                    d.valor = i;
                    ini.push(d);
                  
                }
                Hanoi h = new Hanoi();
                int movesI = h.iterativo(n,ini,aux,fin);
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Total en Iterativo : " + movesI);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
                int movesR = h.recursivo(n,ini,aux,fin);
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("Total en Recursivo : " + movesR);
                Console.BackgroundColor = ConsoleColor.Black;
                
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Valor no valido, pot favor introduzca un número entero diferente a 0, pulsa cualquier tecla para salir");
                Console.ReadKey();
            }
           
      
            
        }
    }
}
