using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Newtonsoft.Json;
using ScottPlot.Drawing;
using ScottPlot;
using ScottPlot.Drawing.Colormaps;
using System.Globalization;



namespace Modulo1
{
    
    public partial class FormModulo1 : Form
    {
        Thread threadRecebimentosPacotesModulo1 = null;
        Thread[] listaThreadsUnidadesGeradorasModulo1;
        UnidadeGeradoraDadosMedicao[] listaUnidadesGeradorasDadosMedicao;
        UdpClient usocketConexaoUDPModulo1 = null;
        IPEndPoint ipConexaoRecebimentoUDPModulo1 = null;
        IPEndPoint ipConexaoEnvioUDPModulo1 = null;
        string menssagemRecebidaModulo1;
        byte[] bytesRecebidosModulo1;
        private List<int> dadosPlotarGraficoModulo1 = new List<int>();
        JSON_FORMATO_DADOS_MEDIDAS_ELETRICAS dadosRecebidosEmFormatoJSONModulo1;
        int contadorRecebimentoPacoteModulo1 = 0;
        public Mutex nossoMutex = new Mutex();
        bool pararRecebimentoDadosModulo1 = false;


        public FormModulo1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false; //possibilita que componentes sejam chamados por threads diferentes                                    //PASSO 1: encontra o IP e atribui a classe principal de dados e controle 
            formsPlotPacotesEnviados.Plot.Title("Taxa pacotes recebidos broadcasting de todas MUs", true, Color.Black, 12.0f);
            
        }

        private void buttonIniciarParte1SV_Click(object sender2, EventArgs e)
        {
            //verifica antes se usuario adicionou algum MU
            if (listViewMod1UnidGeradora.Items.Count < 1)
            {
                MessageBox.Show("Você primeiro deve cadastrar pelo menos 1 MU");
                return;

            }


            //parte 0: inicializacoes de interface
            buttonIniciarMod1Iniciar.Enabled = false;   
            propertyGridUnidGeradoras.Enabled = true;
            buttonPararEnvioV1.Enabled = true;
            timerPlotaModulo1SinaisEnviados.Start(); //para plotar sinais
            contadorRecebimentoPacoteModulo1 = 0;
            dadosPlotarGraficoModulo1.Clear();
            pararRecebimentoDadosModulo1 = false;


            //Parte 1: inicia conexao UDP
            usocketConexaoUDPModulo1 = new UdpClient(12344);
            ipConexaoRecebimentoUDPModulo1 = new IPEndPoint(IPAddress.Any, 12344);
            ipConexaoEnvioUDPModulo1 = new IPEndPoint(IPAddress.Parse("255.255.255.255"), 12346);
            textBoxRecepcaoConexao.Text = textBoxRecepcaoConexao.Text + "UDP CONECTADO !!!" + Environment.NewLine;
            threadRecebimentosPacotesModulo1 = new Thread(RecebimentoPacotesUDPModulo1);
            threadRecebimentosPacotesModulo1.Start();


            //Parte 2: gera objetos equivalantes a unidades geradoras
            int quantidadeUnidGeradoras = listViewMod1UnidGeradora.Items.Count;
            listaUnidadesGeradorasDadosMedicao = new UnidadeGeradoraDadosMedicao[quantidadeUnidGeradoras];
            listaThreadsUnidadesGeradorasModulo1 = new Thread[quantidadeUnidGeradoras];

            int codigo = 0;
            int freqEnvio = 0;
            int correnteOriginal = 0;
            int correnteCurto = 0;
            for (int i = 0; i < quantidadeUnidGeradoras; i++)
            {
                codigo = Convert.ToInt16(listViewMod1UnidGeradora.Items[i].SubItems[0].Text);
                freqEnvio = Convert.ToInt16(listViewMod1UnidGeradora.Items[i].SubItems[1].Text);
                correnteOriginal = Convert.ToInt16(listViewMod1UnidGeradora.Items[i].SubItems[2].Text);
                correnteCurto = Convert.ToInt16(listViewMod1UnidGeradora.Items[i].SubItems[3].Text);
                listaUnidadesGeradorasDadosMedicao[i] = new UnidadeGeradoraDadosMedicao(usocketConexaoUDPModulo1, ipConexaoEnvioUDPModulo1, nossoMutex, correnteOriginal, codigo, freqEnvio, correnteCurto, false);
            }
            

            //Parte 3: gera threads
            for (int i = 0; i < quantidadeUnidGeradoras; i++)
            {
                listaThreadsUnidadesGeradorasModulo1[i] = new Thread(new ThreadStart(listaUnidadesGeradorasDadosMedicao[i].EnviaPacotesUDPFrequentemente));
                listaThreadsUnidadesGeradorasModulo1[i].Name = "UnidGeradora" + i.ToString();
                listaThreadsUnidadesGeradorasModulo1[i].Start();
            }
           
        }

        private void buttonPararEnvioV1_Click(object sender, EventArgs e)
        {
            //parte 0: inicializacoes de interface
            propertyGridUnidGeradoras.Enabled = false;
            buttonPararEnvioV1.Enabled = false;
            timerPlotaModulo1SinaisEnviados.Stop(); //para plotar sinais
            contadorRecebimentoPacoteModulo1 = 0;
            dadosPlotarGraficoModulo1.Clear();
            buttonIniciarMod1Iniciar.Enabled = true;
            pararRecebimentoDadosModulo1 = true;

            //Parte 1: para os objetos equivalantes a unidades geradoras            
            for (int i = 0; i < listaUnidadesGeradorasDadosMedicao.Length; i++)
            {
                listaUnidadesGeradorasDadosMedicao[i].pararEnvio = true; //vai forcar as threads pararem
            }
            Thread.Sleep(500);
            listaUnidadesGeradorasDadosMedicao = null;

            //Parte 2: fecha conexao UDP
            usocketConexaoUDPModulo1.Close();
            threadRecebimentosPacotesModulo1.Abort();
        }

        private void RecebimentoPacotesUDPModulo1()
        {
            //esta funcao eh uma thread que fica lendo os pacotes de rede
            while (true)
            {
                if (pararRecebimentoDadosModulo1)//para 
                    return;
                bytesRecebidosModulo1 = usocketConexaoUDPModulo1.Receive(ref ipConexaoRecebimentoUDPModulo1);
                contadorRecebimentoPacoteModulo1++;

                //Com estes comandos abaixo, que estao comentados, vc poderia ler os valores. Observe que temos que usar a classe  "JsonConvert"
                menssagemRecebidaModulo1 = Encoding.ASCII.GetString(bytesRecebidosModulo1);
                dadosRecebidosEmFormatoJSONModulo1 = JsonConvert.DeserializeObject<JSON_FORMATO_DADOS_MEDIDAS_ELETRICAS>(menssagemRecebidaModulo1);
                textBoxRecepcaoConexao.Text = textBoxRecepcaoConexao.Text + "RECEBEU_UDP (" + ipConexaoRecebimentoUDPModulo1.Address.ToString() + ") >>" + menssagemRecebidaModulo1 + Environment.NewLine;
            }
        }

        private void buttonMod1Limpar_Click(object sender, EventArgs e)
        {
            listViewMod1UnidGeradora.Items.Clear();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            listViewMod1UnidGeradora.Items.Add(new ListViewItem(new String[] { numericUpDownMod1CodUnidGen.Value.ToString(), numericUpDownMod1FreqEnvio.Value.ToString(), numericUpDownMod1Corrente.Value.ToString(), numericUpDownMod1Curto.Value.ToString() }));
            numericUpDownMod1CodUnidGen.Value = numericUpDownMod1CodUnidGen.Value + 1; 
        }

        private void timerPlotaModulo1SinaisEnviados_Tick(object sender, EventArgs e)
        {
            //Esta funcao atualiza o grafico de plotagem periodicamente
            if (dadosPlotarGraficoModulo1.Count > 300) //se tiver muitas amostras, zera
            {
                dadosPlotarGraficoModulo1.Clear();
            }
            else
            {
                dadosPlotarGraficoModulo1.Add(contadorRecebimentoPacoteModulo1);
            }
            contadorRecebimentoPacoteModulo1 = 0; //zera contagem


            //ATUALIZA VISUALIZACAO DE GRAFICO:
            double[] ys = new double[dadosPlotarGraficoModulo1.Count];
            double[] xs = DataGen.Consecutive(dadosPlotarGraficoModulo1.Count);
            for (int i = 0; i < dadosPlotarGraficoModulo1.Count; i++)
            {
                ys[i] = (double)dadosPlotarGraficoModulo1[i];
            }
            formsPlotPacotesEnviados.Plot.Clear();
            if (dadosPlotarGraficoModulo1.Count > 1)
            {
                formsPlotPacotesEnviados.Plot.AddScatterLines(xs, ys, Color.Blue, 2);
                formsPlotPacotesEnviados.Refresh();
            }
        }

        private void listViewMod1UnidGeradora_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaUnidadesGeradorasDadosMedicao == null)
                return;

            int indiceUnidGeradora = 0;
            if (listViewMod1UnidGeradora.SelectedItems.Count > 0)
                indiceUnidGeradora = Convert.ToInt16(listViewMod1UnidGeradora.SelectedItems[0].Text);
            else
                return;

            for (int i = 0; i < listaUnidadesGeradorasDadosMedicao.Length; i++)
            {
                if (listaUnidadesGeradorasDadosMedicao[i].codDestaUnidade == indiceUnidGeradora)
                {
                    propertyGridUnidGeradoras.SelectedObject = listaUnidadesGeradorasDadosMedicao[i];
                    return;
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }//fim classe



}//fim namespace
