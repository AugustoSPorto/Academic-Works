using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaPorto
{
    public partial class Form1 : Form
    {
        Porto p1 = new Porto();
        public Form1()
        {
            InitializeComponent();
        }

        public void saida()
        {
            textBoxLoc1.Text = p1.Local1.imprime();
            textBoxLoc2.Text = p1.Local2.imprime();
            textBoxLoc3.Text = p1.Local3.imprime();
            textBoxLoc4.Text = p1.Local4.imprime();
            textBoxNome.Clear();
        }

        private void buttonAdic_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNome.Text == "")
                {
                    MessageBox.Show("Campo vazio!", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (p1.estaCheio())
                {
                    MessageBox.Show("Porto está cheio!", "Impossível empilhar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    p1.adicionar(textBoxNome.Text);
                    saida();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Campo inválido!", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonReti_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNome.Text == "")
                {
                    MessageBox.Show("Campo vazio!", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (p1.estaVazio())
                {
                    MessageBox.Show("Porto está vazio!", "Impossível desempilhar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    p1.remover(textBoxNome.Text);
                    saida();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Campo inválido!", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
