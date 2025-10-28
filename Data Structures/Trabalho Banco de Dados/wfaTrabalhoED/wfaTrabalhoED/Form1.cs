using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaTrabalhoED
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxCami.Enabled = false;
            //textBoxCami.Dock = DockStyle.Fill;
            textBoxDist.Enabled = false;
        }

        public void limparTexto()
        {
            textBoxDest.Clear();
            textBoxOrig.Clear();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            try
            {
                // Criando dicionario que traduz as cidades para vertices (escolhi ordem crescente)
                Dictionary<string, int> cidades = new Dictionary<string, int>();
                cidades.Add("Araguari",0);
                cidades.Add("Capinópolis", 1);
                cidades.Add("Cascalho Rico", 2);
                cidades.Add("Centralina", 3);
                cidades.Add("Douradinhos", 4);
                cidades.Add("Estrela do Sul", 5);
                cidades.Add("Grupiara", 6);
                cidades.Add("Indianópolis", 7);
                cidades.Add("Ituiutaba", 8);
                cidades.Add("Itumbiara", 9);
                cidades.Add("Monte Alegre de Minas", 10);
                cidades.Add("Romaria", 11);
                cidades.Add("São Juliana", 12);
                cidades.Add("Tupaciguara", 13);
                cidades.Add("Uberlândia", 14);
                List<string> nomesCidade = new List<string>(cidades.Keys);


                // Criando grafo
                Grafo mapa = new Grafo(15);
                mapa.addAresta(7, 12, 40);
                mapa.addAresta(12, 11, 28);
                mapa.addAresta(0, 2, 28);
                mapa.addAresta(0, 5, 34);
                mapa.addAresta(2, 6, 32);
                mapa.addAresta(5, 6, 38);
                mapa.addAresta(1, 8, 30);
                mapa.addAresta(1, 3, 40);
                mapa.addAresta(8, 10, 85);
                mapa.addAresta(8, 4, 90);
                mapa.addAresta(10, 4, 28);
                mapa.addAresta(3, 9, 20);
                mapa.addAresta(3, 10, 75);
                mapa.addAresta(9, 13, 55);
                mapa.addAresta(13, 10, 44);
                mapa.addAresta(14, 4, 63);
                mapa.addAresta(14, 10, 60);
                mapa.addAresta(14, 13, 60);
                mapa.addAresta(14, 0, 30);
                mapa.addAresta(14, 11, 78);
                mapa.addAresta(14, 7, 45);


                if (textBoxOrig.Text == "" || textBoxDest.Text == "")
                {
                    MessageBox.Show("Um ou mais campos vazios!", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (textBoxOrig.Text ==  textBoxDest.Text)
                {
                    MessageBox.Show("Cidade de origem e destino iguais!", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (nomesCidade.Contains(textBoxOrig.Text) == false || nomesCidade.Contains(textBoxDest.Text) == false)
                {
                    MessageBox.Show("Uma ou mais cidades não pertecem ao mapa!", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int origem = cidades[textBoxOrig.Text];
                    int destino = cidades[textBoxDest.Text];

                    int distancia = mapa.acharDistancia(origem, destino);
                    textBoxDist.Text = (Convert.ToString(distancia) + " Km");

                    List<int> lista = mapa.dijkstra(origem, destino);
                    string saida = "";

                    foreach (int i in lista)
                    {
                        if (i != destino)
                        {
                            saida += (nomesCidade[i] + " --> ");
                        }
                        else
                        {
                            saida += nomesCidade[i];
                        }
                    }
                    textBoxCami.Text = saida;
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Um ou mais campos inválidos!", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            limparTexto();

        }
    }
}
