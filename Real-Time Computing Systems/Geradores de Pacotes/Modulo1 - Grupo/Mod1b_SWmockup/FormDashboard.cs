using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mod1b_SWmockup
{
    public partial class FormDashboard : Form
    {
        public FormDashboard(BindingList<MU> mus)
        {
            InitializeComponent();
            dataGridView1.DataSource = mus;

            Thread threadAtualizacao = new Thread(() =>
            {
                while (true)
                {
                    Thread.Sleep(100); 

                    if (dataGridView1.InvokeRequired)
                    {
                        dataGridView1.Invoke(new MethodInvoker(() =>
                        {
                            dataGridView1.Refresh(); // Atualiza a interface
                        }));
                    }
                    else
                    {
                        dataGridView1.Refresh();
                    }
                }
            });
            threadAtualizacao.IsBackground = true;
            threadAtualizacao.Start();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mus = dataGridView1.DataSource as BindingList<MU>;

            if (button1.Text == "Executar")
            {
                foreach (MU mu in mus)
                {
                    // Cria uma nova thread para cada MU e executa o EnviaPacote
                    Thread threadEnvio = new Thread(new ThreadStart(mu.EnviaPacote));
                    threadEnvio.Start();
                }
                button1.Text = "Parar";

                MessageBox.Show("Pacotes sendo enviados via broadcast.");
            }
            else {
                foreach (MU mu in mus)
                {
                    mu.ParaEnvio = true;
                }
                button1.Text = "Executar";
                MessageBox.Show("Envio de pacotes interrompido.");
            }
        }

           

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
