using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaConteiners
{
    internal class NoPilha
    {
        //atributos
        private string info;
        private NoPilha prox;

        //metodos

        //construtores
        public NoPilha()
        {
            prox = null;
        }
        public NoPilha(string infoIn)
        {
            info = infoIn;
            prox = null;
        }
        public NoPilha(string infoIn, NoPilha proxIn)
        {
            info = infoIn;
            prox = proxIn;
        }

        // getters e setters
        public string Info { get => info; set => info = value; }
        internal NoPilha Prox { get => prox; set => prox = value; }

    } // fim da classe
}
