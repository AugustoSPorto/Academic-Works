using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaTrocaPecas
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
                string temp = topo.Info;
                topo = topo.Prox;
                return temp;
            }
        }

        public bool contem(string nome)
        {
            try
            {
                if (topo == null)
                {
                    return false;
                }
                NoPilha no = topo;
                for (int i = 0; i < tamanho; i++)
                {
                    if (no == null)
                    {
                        return false;
                    }
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
            catch (NullReferenceException)
            {
                return false;
            }
        }

        public void retirar(string nome)
        {
            Pilha pTemp = new Pilha();
            NoPilha no = topo;
            // Desmontagem
            for (int i = 0 ;i < tamanho; i++)
            {
                if (no.Info == nome)
                {
                    pop();
                    tamanho--;
                    break;
                }
                else
                {
                    pTemp.push(no.Info);
                    no = no.Prox;
                    pop();
                }
            }
            // Remontagem
            for (int i = 0 ; i < pTemp.tamanho ; i++)
            {
                push(pTemp.Topo.Info);
                pTemp.pop();
            }
        }

        public void trocar(string nomeOrig,string nomeNovo)
        {
            Pilha pTemp = new Pilha();
            NoPilha no = topo;
            // Desmontagem
            for (int i = 0; i < tamanho; i++)
            {
                if (no.Info == nomeOrig)
                {
                    // Troca
                    pop();
                    push(nomeNovo);
                    break;
                }
                else
                {
                    pTemp.push(no.Info);
                    no = no.Prox;
                    pop();
                }
            }
            // Remontagem
            for (int i = 0; i < pTemp.tamanho; i++)
            {
                push(pTemp.Topo.Info);
                pTemp.pop();
            }
        }

    }
}
