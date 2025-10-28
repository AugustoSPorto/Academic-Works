using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq.Expressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.InteropServices;

namespace Modulo4
{
    public partial class Form1 : Form
    {
        // Define variaveis necessarias
        Thread threadRecebimentoPacotes = null;
        Thread threadEnvioPacotes = null;
        UdpClient usocketConexaoUDP = null;
        IPEndPoint ipConexaoRecebimentoUDP = null;
        IPEndPoint ipConexaoEnvioUDP = null;
        string mensagemRecebida;
        byte[] bytesRecebidos;
        public Mutex mutexDeControle = new Mutex();
        bool pararRecebimentoDados = false;
        bool pararEnvioDados = true;
        private Filtro filtroAtivo = new Filtro();
        List<string> variaveisRecebidas = new List<string>();
        List<double> valoresRecebidos = new List<double>();
        private int idFiltragem;
        private int modoOperacao;

        public Form1()
        {
            //Inicializa componentes com botoes desabilitados, para que apenas possa executar funcoes assim que o modo de operacao for escolhido
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            buttonIniciarFiltragem.Enabled = false;
            buttonPararFiltragem.Enabled = false;
            buttonAdicionar.Enabled = false;
            buttonAtualizar.Enabled = false;
            buttonExcluir.Enabled = false;
            buttonLimpar.Enabled = false;

            //Declarando modos de operado do modulo
            comboBoxModoOperacao.Items.Clear ();
            comboBoxModoOperacao.Items.Add("Formatação 99");
            comboBoxModoOperacao.Items.Add("Formatação 22");
        }


        private void comboBoxModoOperacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Seleciona quais opcoes estao diponiveis para o modo de operacao
            if (comboBoxModoOperacao.SelectedIndex == 0)
            {
                modoOperacao = 0;
                comboBoxVariavel.Text = "";
                comboBoxVariavel.Items.Clear();
                comboBoxVariavel.Items.Add("Ia");
                comboBoxVariavel.Items.Add("Ib");
                comboBoxVariavel.Items.Add("Ic");
                buttonAdicionar.Enabled = true;
                buttonAtualizar.Enabled = true;
                buttonExcluir.Enabled = true;
                buttonLimpar.Enabled = true;
                buttonIniciarFiltragem.Enabled = true;
                return;
            }
            if (comboBoxModoOperacao.SelectedIndex == 1)
            {
                modoOperacao = 1;
                comboBoxVariavel.Text = "";
                comboBoxVariavel.Items.Clear();
                comboBoxVariavel.Items.Add("current");
                comboBoxVariavel.Items.Add("voltage");
                buttonAdicionar.Enabled = true;
                buttonAtualizar.Enabled = true;
                buttonExcluir.Enabled = true;
                buttonLimpar.Enabled = true;
                buttonIniciarFiltragem.Enabled = true;
                return;
            }
        }


        private void buttonIniciarFiltragem_Click(object sender, EventArgs e)
        {
            //Inicializacao
            buttonIniciarFiltragem.Enabled = false;
            buttonPararFiltragem.Enabled = true;
            comboBoxModoOperacao.Enabled = false;

            //Realiza conexao UDP
            pararRecebimentoDados = false;
            pararEnvioDados = false;
            usocketConexaoUDP = new UdpClient(12345);
            usocketConexaoUDP.EnableBroadcast = true;
            ipConexaoRecebimentoUDP = new IPEndPoint(IPAddress.Any, 12345);
            ipConexaoEnvioUDP = new IPEndPoint(IPAddress.Parse("255.255.255.255"), 12346);
            textBoxRecebimento.Text = textBoxRecebimento.Text + "UDP CONECTADO !!!" + Environment.NewLine;

            //Cria thread para recebimento dos pacotes
            threadRecebimentoPacotes = new Thread(RecebimentoPacotes);
            threadRecebimentoPacotes.Start();
            //Cria thread para envio dos pacotes
            threadEnvioPacotes = new Thread(EnviarRelatorio);
            threadEnvioPacotes.Start();
        }

        private void buttonPararFiltragem_Click(object sender, EventArgs e)
        {
            //Inicializacoes de interface
            buttonIniciarFiltragem.Enabled = true;
            buttonPararFiltragem.Enabled = false;
            comboBoxModoOperacao.Enabled = true;
            pararRecebimentoDados = true;
            pararEnvioDados = true;

            // Tempo para parar conexao UDP
            Thread.Sleep(100);
            usocketConexaoUDP.Close();
            threadRecebimentoPacotes.Abort();
            threadEnvioPacotes.Abort();
        }


        private void RecebimentoPacotes()
        {
            Dictionary<string, double> dictContadorIED = new Dictionary<string, double>();
            int contadorTotal = 0;

            //Funcao que le pacotes constantemente
            while (true)
            {
                Dictionary<string, double> dictDados = new Dictionary<string, double>();

                //Condicao de parada
                if (pararRecebimentoDados)
                    return;

                // Recebimento dos pacotes
                bytesRecebidos = usocketConexaoUDP.Receive(ref ipConexaoRecebimentoUDP);
                mensagemRecebida = Encoding.ASCII.GetString(bytesRecebidos);
                textBoxRecebimento.Text += Environment.NewLine +
                                           "Recebeu o pacote (" + ipConexaoRecebimentoUDP.Address.ToString() + ") >>" + mensagemRecebida + Environment.NewLine +
                                           "Data de recebimento: " + $"[{DateTime.Now:HH:mm:ss.fff}]" + Environment.NewLine;

                // Converte ' em " para formatar json corretamente em um dicionario, para melhor entendimento
                string jsonFormatted = mensagemRecebida.Replace('\'', '"');
                var jsonDict = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonFormatted);
                string idDispositivo;

                //Adequa implementacao a diferente modos de operacao (voltado para diferentes tipos de pacotes)
                if (modoOperacao == 1)
                {
                    idDispositivo = jsonDict["ied"];
                    dictDados.Add("current", Convert.ToInt32(jsonDict["current"]));
                    dictDados.Add("voltage", Convert.ToInt32(jsonDict["voltage"]));
                }
                else
                {
                    idDispositivo = jsonDict["idDispositivo"];
                    dictDados.Add("Ia", Convert.ToInt32(jsonDict["Ia"]));
                    dictDados.Add("Ib", Convert.ToInt32(jsonDict["Ib"]));
                    dictDados.Add("Ic", Convert.ToInt32(jsonDict["Ic"]));
                }

                if (dictContadorIED.ContainsKey(idDispositivo))
                {
                    dictContadorIED[idDispositivo] += 1;
                    contadorTotal += 1;
                }
                else
                {
                    dictContadorIED.Add(idDispositivo, 1);
                    contadorTotal += 1;
                }

                //AutoScroll da caixa de texto
                textBoxRecebimento.SelectionStart = textBoxRecebimento.Text.Length;
                textBoxRecebimento.ScrollToCaret();

                //Obtem as medidas armazenadas e executa a filtragem
                variaveisRecebidas = new List<string>(dictDados.Keys);
                valoresRecebidos = new List<double>(dictDados.Values);
                string resultados = filtroAtivo.AplicarFiltros(variaveisRecebidas, valoresRecebidos);

                // Formata o relatorio
                StringBuilder relatorio = new StringBuilder();
                relatorio.AppendLine($"ID da filtragem realizada: {idFiltragem}");
                if (modoOperacao == 1)
                    relatorio.AppendLine("Variaveis analisadas: { current, voltage }");
                else
                    relatorio.AppendLine("Variaveis analisadas: { Ia, Ib, Ic }");
                relatorio.AppendLine("Regras aplicadas: {");
                relatorio.AppendLine(resultados + "}");
                relatorio.AppendLine($"Quantidade de pacotes analisados no total: {contadorTotal}");
                relatorio.AppendLine("Quantidade de pacotes analisados por IED: {");
                foreach (var item in dictContadorIED)
                {
                    relatorio.AppendLine($"Dispositivo {item.Key}: {item.Value}");
                }
                relatorio.AppendLine("}");
                
                // Atualizar text box de preview
                textBoxEnvio.Text = relatorio.ToString(); 
            }
        }

        public void EnviarRelatorio()
        {
            string formatoPacote;
            string tempo;
            byte[] bytes;

            //Funcao que envia pacotes periodicamente
            while (true)
            {
                //Estabeleci delay de 400ms por se encaixar mais proximo dos 0.5 medidos na pratica
                Thread.Sleep(400);

                //Obtem o relatorio e incrementa com o tempo atual para o envio
                formatoPacote = textBoxEnvio.Text;
                tempo = "(Data do ultimo relatorio enviado: " + Environment.NewLine + $"[{DateTime.Now:HH:mm:ss.fff}])" + Environment.NewLine;
                textBoxDataEnvio.Text = tempo;
                bytes = Encoding.ASCII.GetBytes(formatoPacote + tempo);

                //Bloqueia esta regiao para 1 thread por vez
                mutexDeControle.WaitOne();
                try
                {
                    //Se a conexao estiver ativa, envia o relatorio 
                    if (usocketConexaoUDP == null)
                        return;
                    usocketConexaoUDP.Send(bytes, bytes.Length, ipConexaoEnvioUDP);
                    idFiltragem++;
                }
                catch (ObjectDisposedException)
                {
                    return;
                }
                finally
                {
                    //Desbloqueia a regiao
                    mutexDeControle.ReleaseMutex();
                }
                if (pararEnvioDados)
                    return;
            }
        }



        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                string varLido = comboBoxVariavel.Text;
                string operadorLido = comboBoxOperador.Text;
                double valorLido = Convert.ToDouble(textBoxValor.Text);

                //Tratamento de erros
                if (valorLido < 0)
                {
                    MessageBox.Show("O valor digitado não é positivo.");
                    return;
                }
                if (comboBoxVariavel.Items.Contains(varLido) == false)
                {
                    MessageBox.Show("Escolha uma variável válida!");
                    return;
                }
                if (comboBoxOperador.Items.Contains(operadorLido) == false)
                {
                    MessageBox.Show("Escolha um operador válido!");
                    return;
                }
                //Adiciona os valores lidos as listas que compoem o filtro ativo
                filtroAtivo.AdicionarFiltro(varLido, operadorLido, valorLido);
                atualizaTabelaDeRegras();
            }
            catch (FormatException)
            {
                MessageBox.Show("O valor digitado não é válido para a criação de regras de filtragem.");
            }
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int indice = Convert.ToInt32(textBoxIndice.Text);
                string varLido = comboBoxVariavel.Text;
                string operadorLido = comboBoxOperador.Text;
                double valorLido = Convert.ToDouble(textBoxValor.Text);

                //Tratamento de erros
                if (valorLido < 0)
                {
                    MessageBox.Show("O valor digitado não é positivo.");
                    return;
                }
                if (comboBoxVariavel.Items.Contains(varLido) == false)
                {
                    MessageBox.Show("Escolha uma variável válida!");
                    return;
                }
                if (comboBoxOperador.Items.Contains(operadorLido) == false)
                {
                    MessageBox.Show("Escolha um operador válido!");
                    return;
                }
                if (indice >= filtroAtivo.Variaveis.Count)
                {
                    MessageBox.Show("Não há nenhum filtro com esse índice.");
                    return;
                }
                //Atualiza variaveis na posicao indicada, no filtro altivo
                filtroAtivo.AtualizarFiltro(varLido, operadorLido, valorLido, indice);
                atualizaTabelaDeRegras();

            }
            catch (FormatException)
            {
                MessageBox.Show("O índice digitado não é um valor válido.");
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int indice = Convert.ToInt32(textBoxIndice.Text);
                //Tratamento de erro
                if (indice >= filtroAtivo.Variaveis.Count)
                {
                    MessageBox.Show("Não há nenhum filtro com esse índice.");
                    return;
                }
                //Exclui variaveis na posicao indicada, no filtro ativo
                filtroAtivo.ExcluirFiltro(indice);
                atualizaTabelaDeRegras();
            }
            catch (FormatException)
            {
                MessageBox.Show("O índice digitado não é um valor válido.");
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            //Exclui todos as posicoes das listas do filtro ativo 
            filtroAtivo.LimparFiltro();
            atualizaTabelaDeRegras();
        }

        private void atualizaTabelaDeRegras()
        {
            // Limpa todos os itens existentes na ListView
            listView1.Items.Clear();

            //Adiciona todos os elementos do filtro
            for (int i = 0; i < filtroAtivo.Variaveis.Count; i++)
            {
                ListViewItem item = new ListViewItem(filtroAtivo.Variaveis[i]);
                item.SubItems.Add(filtroAtivo.Operadores[i]);
                item.SubItems.Add(filtroAtivo.Valores[i].ToString());

                // Adiciona o item à ListView
                listView1.Items.Add(item);
            }
        }

    }

}
