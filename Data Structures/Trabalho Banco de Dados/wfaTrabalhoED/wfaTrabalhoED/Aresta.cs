using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaTrabalhoED
{
    internal class Aresta
    {
        //Atributos
        private int origem;
        private int destino;
        private int distancia;

        //Métodos
        // * construtores
        public Aresta() 
        {
            origem = 0;
            destino = 0;
            distancia = 0;
        }
        public Aresta(int origem, int destino, int distancia)
        {
            this.origem = origem;
            this.destino = destino;
            this.distancia = distancia;
        }
        // * getters e setters
        public int Origem { get => origem; set => origem = value; }
        public int Destino { get => destino; set => destino = value; }
        public int Distancia { get => distancia; set => distancia = value; }
    }
}
