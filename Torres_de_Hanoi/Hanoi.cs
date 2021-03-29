using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        /*TODO: Implementar métodos*/
        public void mover_disco(Pila a, Pila b)
        {
                Disco aux;
                aux = a.pop();
                b.push(aux);
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            int movimientos = 0;
            if (n % 2 != 0)
            {
                while (!comprobar(fin, n))
                {
                    if (ini.Top!=0 && (fin.Top > ini.Top || fin.Top == 0))
                        {
                         mover_disco(ini,fin);
                         Console.WriteLine("Mover disco " + ini.Top + " de la pila INI a la FIN"); 
                         movimientos++;
                        }
                    else if(fin.Top!=0 && (fin.Top < ini.Top || ini.Top ==0))
                        {
                            mover_disco(fin,ini);
                            Console.WriteLine("Mover disco " + fin.Top + " de la pila FIN a la INI"); 
                            movimientos++;
                        }
                    


                    if(!comprobar(fin, n))
                    {
                        if (ini.Top!=0 && (aux.Top > ini.Top || aux.Top == 0))
                        {
                            mover_disco(ini,aux);
                            Console.WriteLine("Mover disco " + ini.Top + " de la pila INI a la AUX"); 
                            movimientos++;
                
                        }else if(aux.Top!=0 && (aux.Top < ini.Top || ini.Top ==0))
                        {
                            mover_disco(aux,ini);
                            Console.WriteLine("Mover disco " + aux.Top + " de la pila AUX a la INI"); 
                            movimientos++;
                        }
                        
                    }


                    if(!comprobar(fin, n))
                    {
                        if (ini.Top!=0 && (fin.Top > aux.Top || fin.Top == 0))
                        {
                            mover_disco(aux,fin);
                            Console.WriteLine("Mover disco " + aux.Top + " de la pila AUX a la FIN"); 
                            movimientos++;
                
                        }else if(aux.Top!=0 && (fin.Top < aux.Top || aux.Top ==0))
                        {
                            mover_disco(fin,aux);
                            Console.WriteLine("Mover disco " + aux.Top + " de la pila FIN a la AUX"); 
                            movimientos++;
                        }
                        
                    }
                }
            }
            else
            {
                while (!comprobar(fin, n))
                {
                    if (ini.Top!=0 && (aux.Top > ini.Top || aux.Top == 0))
                        {
                            mover_disco(ini,aux);
                            Console.WriteLine("Mover disco " + ini.Top + " de la pila INI a la AUX");
                            movimientos++;
                        }
                    else if(aux.Top!=0 && (aux.Top < ini.Top || ini.Top ==0))
                        {
                            mover_disco(aux,ini);
                            Console.WriteLine("Mover disco " + aux.Top + " de la pila AUX a la INI");
                            movimientos++;
                        }


                    if(!comprobar(fin, n))
                    {
                           if (ini.Top!=0 && (fin.Top > ini.Top || fin.Top == 0))
                            {
                             mover_disco(ini,fin);
                             Console.WriteLine("Mover disco " + ini.Top + " de la pila INI a la FIN"); 
                             movimientos++;
                            }
                        else if(fin.Top!=0 && (fin.Top < ini.Top || ini.Top ==0))
                            {
                                mover_disco(fin,ini);
                                Console.WriteLine("Mover disco " + fin.Top + " de la pila FIN a la INI"); 
                                movimientos++;
                            }
                        
                    }


                    if(!comprobar(fin, n))
                    {
                        if (fin.Top!=0 && (fin.Top > aux.Top || fin.Top == 0))
                        {
                            mover_disco(aux,fin);
                            Console.WriteLine("Mover disco " + aux.Top + " de la pila AUX a la FIN"); 
                            movimientos++;
                
                        }else if(aux.Top!=0 && (fin.Top < aux.Top || aux.Top ==0))
                        {
                            mover_disco(fin,aux);
                            Console.WriteLine("Mover disco " + aux.Top + " de la pila FIN a la AUX"); 
                            movimientos++;
                        }
                    }
                }
            }

            
            return movimientos;
        }

        public bool comprobar(Pila p, int n)
        {

            if (p.Size == n)
            {
                return true;
            }
            return false;
        }

        int movimientos = 0; 
        public int recursivo(int n, Pila ini, Pila fin, Pila aux)
        {
            

            if (n == 1){

                if (ini.Top!=0 && (fin.Top > ini.Top || fin.Top == 0))
                    {
                        mover_disco(ini,fin);
                        Console.WriteLine("Mover disco " + ini.Top + " de la pila INI a la FIN"); 
                        movimientos++;
                    }
                else if(fin.Top!=0 && (fin.Top < ini.Top || ini.Top ==0))
                    {
                        mover_disco(fin,ini);
                        Console.WriteLine("Mover disco " + fin.Top + " de la pila FIN a la INI"); 
                        movimientos++;
                    }
            }
            else{
                recursivo(n-1,ini,aux,fin);

                if (ini.Top!=0 && (fin.Top > ini.Top || fin.Top == 0))
                    {
                        mover_disco(ini,fin);
                        Console.WriteLine("Mover disco " + ini.Top + " de la pila INI a la FIN"); 
                        movimientos++;
                    }
                else if(fin.Top!=0 && (fin.Top < ini.Top || ini.Top ==0))
                    {
                        mover_disco(fin,ini);
                        Console.WriteLine("Mover disco " + fin.Top + " de la pila FIN a la INI"); 
                        movimientos++;
                    }
                
                recursivo(n-1,aux,fin,ini);
            }
            return movimientos;
        }

    }
}
