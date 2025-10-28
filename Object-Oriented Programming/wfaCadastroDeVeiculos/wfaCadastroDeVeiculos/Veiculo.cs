using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaCadastroDeVeiculos
{
    internal class Veiculo
    {
        protected string placa;
        protected int ano;

        public Veiculo()
        {
            placa = null;
            ano = 0;
        }
        public Veiculo(string placa, int ano)
        {
            this.placa = placa;
            this.ano = ano;
            
        }

        public string Placa { get => placa; set => placa = value; }
        public int Ano { get => ano; set => ano = value; }

        public virtual double alugar()
        {
            return 0;
        }
    }
}
