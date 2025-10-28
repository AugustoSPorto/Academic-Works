using caEstacionamento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaEstacionamento
{
    public partial class Form1 : Form
    {
        Estacionamento estacionamento = new Estacionamento(10);
        public Form1()
        {
            InitializeComponent();
            textBoxResposta.Enabled = false;
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text == "")
                textBoxResposta.Text = "Identificação inválida!";
            else if (estacionamento.confereId(textBoxId.Text) == true)
                textBoxResposta.Text = "Carro já presente!";
            else
                textBoxResposta.Text = estacionamento.entrar(textBoxId.Text);
            
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text == "")
                textBoxResposta.Text = "Identificação inválida!";
            else
                textBoxResposta.Text = estacionamento.sair(textBoxId.Text);
        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            textBoxResposta.Text = estacionamento.imprime();
        }
    }
}
