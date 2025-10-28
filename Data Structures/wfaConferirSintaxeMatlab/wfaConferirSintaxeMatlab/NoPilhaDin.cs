using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPilhaDinamica
{
    internal class NoPilha
    {
        //atributos
        private char info;
        private NoPilha prox;

        //metodos

        //construtores
        public NoPilha()
        {
            prox = null;
        }
        public NoPilha(char infoIn)
        {
            info = infoIn;
            prox = null;
        }
        public NoPilha(char infoIn, NoPilha proxIn)
        {
            info = infoIn;
            prox = proxIn;
        }

        // getters e setters
        public char Info { get => info; set => info = value; }
        internal NoPilha Prox { get => prox; set => prox = value; }

    } // fim da classe
}
