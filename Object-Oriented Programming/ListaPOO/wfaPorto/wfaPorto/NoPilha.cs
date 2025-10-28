using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaPorto
{
    internal class NoPilha
    {
        // Atributos
        private string nome;
        private NoPilha prox;

        // Métodos
        // * construtores
        public NoPilha()
        {
            nome = "";
            prox = null;
        }
        public NoPilha(string nome)
        {
            this.nome = nome;
            prox = null;
        }
        public NoPilha(string nome, NoPilha prox)
        {
            this.nome = nome;
            this.prox = prox;
        }

        // * getters e setters
        public string Info { get => nome; set => nome = value; }
        internal NoPilha Prox { get => prox; set => prox = value; }
    }
}
