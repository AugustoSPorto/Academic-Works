using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caListaTAD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista<double> ld = new Lista<double>();
            ld.insere(2.5);
            ld.insere(8.9);
            ld.insere(4.3);
            ld.insere(3.8);
            ld.imprime();
            Console.ReadLine();
        }
    }
}
