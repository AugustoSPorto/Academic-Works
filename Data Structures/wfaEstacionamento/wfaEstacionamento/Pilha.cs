using caEstacionamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaConteiners
{
    internal class Pilha
    {
        //atributos
        protected NoPilha topo = new NoPilha();

        public NoPilha Topo { get => topo; set => topo = value; }


        //metodos
        //construtores
        public Pilha()
        {
            topo = null;
        }

        public Pilha(string n)
        {
            topo = new NoPilha(n);
        }


        public virtual bool pilhaVazia()
        {
            if (topo == null)
                return false;
            else
                return true;
        }

        public virtual void push(string n)
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

        public virtual string imprime()
        {
            string res = "";
            if (topo == null)
            {
                return("Pilha vazia!");
            }
            else
            {
                for (NoPilha no = topo; no != null; no = no.Prox)
                {
                    res += (no.Info) + "\r\t";
                }
                return res;
            }
        }

        public virtual string pop()
        {
            if (topo == null)
            {         
                return null;
            }
            else
            {
                string temp = topo.Info;
                topo = topo.Prox;
                return temp;
            }


        }

    } // fim da classe
}
