using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

public class ReceptorBroadcast
{
    public void Iniciar()
    {
        Thread threadReceber = new Thread(EscutarPacotes);
        threadReceber.IsBackground = true;
        threadReceber.Start();
    }

    private void EscutarPacotes()
    {
        UdpClient cliente = new UdpClient(12345); 
        cliente.EnableBroadcast = true;
        IPEndPoint ip = new IPEndPoint(IPAddress.Any, 12345);

        while (true)
        {
            try
            {
                byte[] dados = cliente.Receive(ref ip);
                string mensagem = Encoding.ASCII.GetString(dados);

                if (mensagem.Contains("\"object\":22") && mensagem.Contains("\"resource\":3"))
                {
                    Console.WriteLine("Pacote recebido:");
                    Console.WriteLine(mensagem);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao receber pacote: " + ex.Message);
            }
        }
    }
}
