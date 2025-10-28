using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caListaTAD
{

    internal class Lista<TAD>
    {
        private NoLista<TAD> inicio;
        private NoLista<TAD> fim;

 

        public Lista()
        {
            inicio = null;
            fim = null;
        }
        public Lista(TAD valor)
        {
            inicio = new NoLista<TAD>(valor);
            fim = null;
        }

        internal NoLista<TAD> Inicio { get => inicio; set => inicio = value; }
        internal NoLista<TAD> Fim { get => fim; set => fim = value; }

        public bool estaVazia()
        {
            return inicio == null;
        }
        public void imprime()
        {
            if (estaVazia())
                Console.WriteLine( "A lista está vazia!");
            else
            {
                string lista = "";
                NoLista<TAD> temp = inicio;
                while (temp != null)
                {
                    lista = lista + " " + temp.Info.ToString();
                    temp = temp.Prox;
                }
                Console.WriteLine(lista);
            }
        }
        public void insere(TAD valor)
        {
            NoLista<TAD> no = new NoLista<TAD>(valor);
            double valorD = Convert.ToDouble(valor);

            for (NoLista<TAD> temp = inicio; temp != null; temp = temp.Prox)
            {
                if (inicio == null)
                {
                    inicio = new NoLista<TAD>(valor);
                }
                else if (valorD < Convert.ToDouble(temp.Info) && temp == inicio) 
                {
                    no.Prox = temp;
                    temp.Previo = no;
                    inicio = no;
                }
                else if (valorD < Convert.ToDouble(temp.Info) && temp != inicio)
                {
                    no.Previo = temp.Previo;
                    no.Prox = temp;
                    temp.Previo = no;
                }
                else
                {
                    no.Previo = temp;
                    temp.Prox = no;
                    fim = no;
                }

            }

        }
        public void remove(TAD valor)
        {
            NoLista<TAD> noASerRemovido = new NoLista<TAD>(valor);

            if (noASerRemovido != null)
            {
                if (noASerRemovido == Inicio)
                {
                    Inicio = Inicio.Prox;
                    Inicio.Previo = null;
                }
                else if (noASerRemovido == Fim)
                {
                    Fim = Fim.Previo;
                    Fim.Prox = null;
                }
                else
                {
                    for (NoLista<TAD> temp = inicio; temp != null; temp = temp.Prox)
                    {
                        if (temp == noASerRemovido)
                        {
                            (noASerRemovido.Previo).Prox = noASerRemovido.Prox;
                            (noASerRemovido.Prox).Previo = noASerRemovido.Previo;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Valor Inválido");
            }

        }


    }
}

