using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPilhaDinamica
{
    internal class PilhaDinamica
    {
        //atributos
        protected NoPilha topo = new NoPilha();


        //metodos
        //construtores
        public PilhaDinamica()
        {
            topo = null;
        }

        public PilhaDinamica(char n)
        {
            topo = new NoPilha(n);
        }


        public bool pilhaVazia()
        {
            if (topo == null)
                return false;
            else
                return true;
        } 
        
        public virtual void push(char n)
        {
            NoPilha novoNo = new NoPilha(n);
            if (topo == null)
            {
                topo = novoNo;
            }
            else
            {
                novoNo.Prox = topo;
                topo = novoNo;
            }
        }

        public virtual void imprime()
        {
            if (topo == null)
            {
                Console.WriteLine("Pilha vazia!");
            }
            else
            {
                for (NoPilha no = topo; no != null; no = no.Prox)
                {
                    Console.WriteLine(no.Info);
                }
            }
        }

        public virtual char pop()
        {
            if (topo == null)
            {
                Console.WriteLine("Pilha Vazia! ");
                return '\0';
            }
            else
            {
                char temp = topo.Info;
                topo = topo.Prox;
                return temp;
            }


        }// fim da classe

    }
}