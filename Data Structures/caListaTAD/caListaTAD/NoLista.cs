using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caListaTAD
{

    internal class NoLista<TAD>
    {
        private NoLista<TAD> previo;
        private TAD info;
        private NoLista<TAD> prox;
        

        public NoLista()
        {
            previo = null; 

            prox = null;
        }
        public NoLista(TAD valor)
        {
            info = valor;
        }

        public TAD Info { get => info; set => info = value; }
        internal NoLista<TAD> Previo { get => previo; set => previo = value; }
        internal NoLista<TAD> Prox { get => prox; set => prox = value; }


    }
}