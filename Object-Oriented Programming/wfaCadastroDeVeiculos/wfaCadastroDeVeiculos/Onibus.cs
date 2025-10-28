using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaCadastroDeVeiculos
{
    internal class Onibus : Veiculo
    {
        private int assentos;

        public Onibus()
        {
            placa = null;
            ano = 0;
            assentos = 0;
        }
        public Onibus(string placa, int ano, int numAssentos) : base(placa, ano)
        {
            this.placa = placa;
            this.ano = ano;
            this.assentos = numAssentos;
        }

        public int Assentos { get => assentos; set => assentos = value; }

        public override double alugar()
        {
            return ((30 * assentos) - (2023 - ano) * 70);
        }
    }
}
