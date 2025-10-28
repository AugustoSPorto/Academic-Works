using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Modulo1
{
    public class UnidadeGeradoraDadosMedicao
    {
        [Browsable(true)]
        [ReadOnly(false)]
        [Description("Valor de corrente emitido pelo pacote")]
        [DisplayName("Corrente normal")]
        public int valorCorrente { get; set; }

        [Browsable(true)]
        [ReadOnly(false)]
        [Description("Código desta unidade geradora de pacotes")]
        [DisplayName("COD")]
        public int codDestaUnidade { get; set; }

        [Browsable(true)]
        [ReadOnly(false)]
        [Description("Frequencia de envio de pacotes em ms")]
        [DisplayName("Freq. envio")]
        public int freqEnvioPacotesMS { get; set; }

        [Browsable(true)]
        [ReadOnly(true)]
        [Description("Quantidade de pacotes enviados")]
        [DisplayName("Pacotes enviados")]
        public int contadoPacotesEnviados { get; set; }

        [Browsable(true)]
        [ReadOnly(false)]
        [Description("Valor que indica se o item esta em curto")]
        [DisplayName("Valor curto")]
        public int valorCurto { get; set; }

        [Browsable(true)]
        [ReadOnly(false)]
        [Description("Indica se está em curto")]
        [DisplayName("Em curto?")]
        public bool estaCurto { get; set; }

        [Browsable(false)]
        public bool pararEnvio { get; set; }

        public Mutex nossoMutex;
        public UdpClient usocketConexaoUDP;
        public IPEndPoint ipConexaoEnvioUDP;

        public UnidadeGeradoraDadosMedicao(UdpClient p_usocketConexaoUDP, IPEndPoint p_ipConexaoEnvioUDP, Mutex p_nossoMutex, int p_valorCorrente, int p_codDestaUnidade, int p_freqEnvioPacotesMS, int p_valorCurto, bool p_estaCurto)
        {
            nossoMutex = p_nossoMutex;
            valorCorrente = p_valorCorrente;
            codDestaUnidade = p_codDestaUnidade;
            freqEnvioPacotesMS = p_freqEnvioPacotesMS;
            valorCurto = p_valorCurto;
            estaCurto = p_estaCurto;
            usocketConexaoUDP = p_usocketConexaoUDP;
            ipConexaoEnvioUDP = p_ipConexaoEnvioUDP;
            contadoPacotesEnviados = 0;
            pararEnvio = false;

        }


        //esta eh uma thread para cada MU que gera as medidas eletricas e manda para a rede
        public void EnviaPacotesUDPFrequentemente()
        {
            string formatoPacote;
            string corrente;
            byte[] bytes;

            while (true)
            {
                corrente = Convert.ToString(valorCorrente);
                if (valorCorrente > valorCurto)
                    estaCurto = true;
                else
                    estaCurto = false;
                if (contadoPacotesEnviados < 65000)
                    contadoPacotesEnviados++;
                else
                    contadoPacotesEnviados = 0;
                formatoPacote = "{'Ia':" + corrente +
                                ",'Ib':" + corrente +
                                ",'Ic':" + corrente +
                                ",'numPacote':" + contadoPacotesEnviados.ToString() +
                                ",'idDispositivo':" + codDestaUnidade.ToString() + "}";

                bytes = Encoding.ASCII.GetBytes(formatoPacote);
                nossoMutex.WaitOne(); //bloqueia esta regiao para 1 simples thread acessar
                if (usocketConexaoUDP != null)
                    usocketConexaoUDP.Send(bytes, bytes.Length, ipConexaoEnvioUDP);
                nossoMutex.ReleaseMutex(); //desbloqueia esta regiao 
                if (pararEnvio)
                    return;
                if ((valorCorrente < valorCurto) || !estaCurto) //se nao estiver em curto
                    Thread.Sleep(freqEnvioPacotesMS); //aguarda ate proximo envio
                                                      //else//esta em curto
                                                      //Thread.Sleep(1); //coloquei para nao sobrecarregar
            }

        }

    }

}
