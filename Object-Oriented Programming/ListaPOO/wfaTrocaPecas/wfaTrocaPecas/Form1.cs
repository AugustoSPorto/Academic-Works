using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaTrocaPecas
{
    public partial class Form1 : Form
    {
        Pilha produto = new Pilha();

        public Form1()
        {
            InitializeComponent();
            label1.Visible = false;
            label2.Visible = false;
            label4.Visible = false;
            textBoxPeca.Visible = false;
            textBoxPOrig.Visible = false;
            textBoxPNova.Visible = false;
        }

        public void limparTexto() 
        {
            textBoxPeca.Clear();
            textBoxPNova.Clear();
            textBoxPOrig.Clear();
        }


        private void radioButtonAdd_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPeca.Visible = true;
            label4.Visible = true;
            label1.Visible = false;
            label2.Visible = false;
            textBoxPOrig.Visible = false;
            textBoxPNova.Visible = false;
        }

        private void radioButtonPop_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPeca.Visible = true;
            label4.Visible = true;
            label1.Visible = false;
            label2.Visible = false;
            textBoxPOrig.Visible = false;
            textBoxPNova.Visible = false;
        }

        private void radioButtonTroca_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPNova.Visible = true;
            textBoxPOrig.Visible = true;
            label1.Visible=true;
            label2.Visible=true;
            textBoxPeca.Visible = false;
            label4.Visible = false;
        }

        private void buttonExec_Click(object sender, EventArgs e)
        {
            try
            {
                // Adicionar peça
                if (radioButtonAdd.Checked)
                {
                    if (textBoxPeca.Text == "")
                    {
                        MessageBox.Show("Campo Vazio!", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (produto.contem(textBoxPeca.Text) == false) { 
                        produto.push(textBoxPeca.Text);
                        MessageBox.Show("Peça Inserida Com Sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Peça Já Foi Inserida!", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                // Remover peça
                else if (radioButtonPop.Checked)
                {
                    if (textBoxPeca.Text == "")
                    {
                        MessageBox.Show("Campos Vazio!", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!produto.contem(textBoxPeca.Text)) {
                        MessageBox.Show("Peça Inexistente!", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (produto.contem(textBoxPeca.Text))
                    {
                        produto.retirar(textBoxPeca.Text);
                        MessageBox.Show("Peça Retirada Com Sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                // Trocar peça
                else if (radioButtonTroca.Checked)
                {
                    if (textBoxPOrig.Text == "" || textBoxPNova.Text == "")
                    {
                        MessageBox.Show("Um Ou Mais Campos Vazios!", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (produto.contem(textBoxPOrig.Text))
                    {
                        produto.trocar(textBoxPOrig.Text, textBoxPNova.Text);
                        MessageBox.Show("Peças Trocadas Com Sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Peça Original Inexistente!", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                textBoxRes.Text = produto.imprime();
                limparTexto();
            }
            catch (FormatException)
            {
                MessageBox.Show("Um ou mais campos inválidos!", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
