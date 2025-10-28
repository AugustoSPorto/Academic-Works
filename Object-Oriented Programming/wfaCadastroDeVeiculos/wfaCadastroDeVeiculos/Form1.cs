using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaCadastroDeVeiculos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listView1.Columns.Add("Placa", 70);
            listView1.Columns.Add("Ano", 70);
            listView1.Columns.Add("Assentos", 70);
            listView1.Columns.Add("Eixos", 70);
            listView1.Columns.Add("Diária", 110);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonCadast_Click(object sender, EventArgs e)
        {
            if (radioButtonOni.Checked == true && radioButtonCam.Checked == false && textBoxPlaca.Text != null && textBoxAno.Text != null && textBoxQtd.Text != null)
            {
                Onibus onibus = new Onibus(textBoxPlaca.Text, Convert.ToInt32(textBoxAno.Text), Convert.ToInt32(textBoxQtd.Text));
                double diaria = Convert.ToDouble(onibus.alugar());

                ListViewItem item = new ListViewItem(onibus.Placa);
                item.SubItems.Add(Convert.ToString(onibus.Ano));
                item.SubItems.Add(Convert.ToString(onibus.Assentos));
                item.SubItems.Add("");
                item.SubItems.Add(Convert.ToString("R$ " + diaria.ToString("F2")));
                listView1.Items.Add(item);

            }
            else if (radioButtonOni.Checked == false && radioButtonCam.Checked == true && textBoxPlaca.Text != null && textBoxAno.Text != null && textBoxQtd.Text != null)
            {
                Caminhao caminhao = new Caminhao(textBoxPlaca.Text, Convert.ToInt32(textBoxAno.Text), Convert.ToInt32(textBoxQtd.Text));
                double diaria = Convert.ToDouble(caminhao.alugar());

                ListViewItem item = new ListViewItem(caminhao.Placa);
                item.SubItems.Add(Convert.ToString(caminhao.Ano));
                item.SubItems.Add("");
                item.SubItems.Add(Convert.ToString(caminhao.Eixos));
                item.SubItems.Add(Convert.ToString("R$ " + diaria.ToString("F2")));
                listView1.Items.Add(item);
            }
            else
            {
                Console.WriteLine("Configuração Inválida");
            }

        }

        private void radioButtonOni_CheckedChanged(object sender, EventArgs e)
        {
            labelQtd.Text = "Qtd. Assentos: ";
            pictureBoxOnibus.Visible = true;
            pictureBoxCam.Visible = false;
        }

        private void radioButtonCam_CheckedChanged(object sender, EventArgs e)
        {
            labelQtd.Text = "Qtd. Eixos: ";
            pictureBoxOnibus.Visible = false;
            pictureBoxCam.Visible = true;
        }

        private void buttonLimp_Click(object sender, EventArgs e)
        {
            textBoxPlaca.Clear();
            textBoxAno.Clear();
            textBoxQtd.Clear();
        }

    }
}
