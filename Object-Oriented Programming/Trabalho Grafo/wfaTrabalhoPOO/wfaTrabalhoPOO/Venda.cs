using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaTrabalhoPOO
{
    internal class Venda
    {
        // Atributos
        private string cod_c;
        private int cod_j;
        private int qtd;
        private double preco;

        // Métodos
        // * getters e setters
        public string Cod_c { get => cod_c; set => cod_c = value; }
        public int Cod_j { get => cod_j; set => cod_j = value; }
        public int Qtd { get => qtd; set => qtd = value; }
        public double Preco { get => preco; set => preco = value; }
        // * construtor
        public Venda( string cod_c, int cod_j, int qtd, double preco)
        {
            this.cod_c = cod_c;
            this.cod_j = cod_j;
            this.qtd = qtd;
            this.preco = preco;
        }
    }
}
