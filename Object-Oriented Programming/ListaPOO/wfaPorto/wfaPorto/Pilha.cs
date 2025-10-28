using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaPorto
{
    internal class Pilha
    {
        //Atributos
        private NoPilha topo = new NoPilha();
        private int tamanho;

        public NoPilha Topo { get => topo; set => topo = value; }
        public int Tamanho { get => tamanho; set => tamanho = value; }


        //metodos
        // construtores
        public Pilha()
        {
            topo = null;
            tamanho = 0;
        }

        public Pilha(string n)
        {
            topo = new NoPilha(n);
            tamanho = 1;
        }


        public bool pilhaVazia()
        {
            if (topo == null)
                return false;
            else
                return true;
        }

        public void push(string n)
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
            tamanho++;
        }

        public string imprime()
        {
            string res = "";
            if (topo == null)
            {
                return ("Pilha vazia!");
            }
            else
            {
                for (NoPilha no = topo; no != null; no = no.Prox)
                {
                    res += (no.Info) + "\r\n";
                }
                return res;
            }
        }

        public string pop()
        {
            if (topo == null)
            {
                return null;
            }
            else
            {
                tamanho--;
                string temp = topo.Info;
                topo = topo.Prox;
                return temp;
            }
        }

        public bool contem(string nome)
        {
            if (topo == null)
            {
                return false;
            }
            NoPilha no = topo;
            for (int i = 0; i < tamanho; i++)
            {
                if (no.Info == nome)
                {
                    return true;
                }
                else
                {
                    no = no.Prox;
                }
            }
            return false;
        }
    }
}
