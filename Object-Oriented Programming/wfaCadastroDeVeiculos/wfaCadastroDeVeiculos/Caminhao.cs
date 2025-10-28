using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaCadastroDeVeiculos
{
    internal class Caminhao : Veiculo
    {
        private int eixos;

        public Caminhao()
        {
            placa = null;
            ano = 0;
            eixos = 0;
        }
        public Caminhao(string placa, int ano, int eixo) : base(placa, ano)
        {
            this.placa = placa;
            this.ano = ano;
            this.eixos = eixo;
        }
        public int Eixos { get => eixos; set => eixos = value; }

        public override double alugar()
        {
            return ((300 * eixos) - (2023 - ano) * 50);
        }
    }
}
