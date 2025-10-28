using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wfaConteiners;

namespace caEstacionamento
{
    internal class Estacionamento : Pilha
    {
        int limite = 0;
        int qtdCarros = 0;
        public Estacionamento(int lim) 
        {
            topo = null;
            limite = lim;
        }
        public Estacionamento(string idCarro, int lim) : base(idCarro)
        {
            topo = new NoPilha(idCarro);
            limite = lim;
        }
        public string entrar(string idCarro)
        {
            if (qtdCarros < limite)
            {
                base.push(idCarro);
                qtdCarros++;
                return("O carro " + idCarro + " ocupou a vaga: " + (qtdCarros));
            }
            else
            {
                return("Estacionamento cheio!");
            }
        }
        public string sair(string idCarro)
        {
            if (topo == null)
                return ("Estacionamento Vazio");
            else
            {
                if (confereId(idCarro))
                {
                    Pilha temp = new Pilha();
                    for (int i = qtdCarros; i > 0; i--)
                    {
                        if (topo.Info == idCarro)
                        {
                            base.pop();
                            qtdCarros--;
                            for (int j = qtdCarros; j > 0; j--)
                            {
                                if (temp.Topo != null)
                                {
                                    base.push(temp.Topo.Info);
                                    temp.pop();
                                }
                            }
                            break;
                        }
                        temp.push(base.pop());
                    }
                    return ("O carro " + idCarro  + " deixou o estacionamento");
                }
                else
                    return ("Carro informado não está no estacionamento");
            }
        }
        public bool confereId(string idCarro)
        {
            NoPilha temp = topo;
            for (int i = qtdCarros; i > 0; i--)
            {
                if (temp.Info == idCarro)
                    return true;
                else
                    temp = temp.Prox;
            }
            return false;
        }


    }
}
