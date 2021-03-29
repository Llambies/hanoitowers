using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        public int Size { get; set; }

        /* TODO: Elegir tipo de Top
        public int Top { get; set; }
        public String Top { get; set; }        
        */
        public int Top { get; set; }

     
        /* TODO: Elegir tipo de Elementos
        public Disco[] Elementos { get; set; }
        public List<Disco> Elementos { get; set; }
        */
        public List<Disco> Discos;


        /* TODO: Implementar métodos */
        public Pila()
        {
            this.Discos = new List<Disco>();
            this.Size = 0;
        }

        public void push(Disco d)
        {
            Discos.Add(d);
            Top = d.valor;
            this.Size++;
        }

        public Disco pop()
        {
            
            Disco aux;
            aux = this.Discos[this.Size-1];
            this.Discos.RemoveAt(this.Size - 1);
            this.Size--;
            if (Size == 0)
            {
                Top = 0;
            }
            else
            {
                Top = this.Discos[this.Size - 1].valor;

            }
           
            return aux;
            
        }                

        public bool isEmpty()
        {
            if (this.Size==0)
            {
                return true;
            }
            return false;
            
        }

    }
}
