using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaTrabalhoPOO
{
    internal class Jogo
    {
        // Atributos
        private string titulo;
        private string desenvolvedora;
        private string plataforma;
        private int cod;

        // Métodos
        // * getters e setters
        public string Titulo { get => titulo; set => titulo = value; }
        public string Desenvolvedora { get => desenvolvedora; set => desenvolvedora = value; }
        public string Plataforma { get => plataforma; set => plataforma = value; }
        public int Cod { get => cod; set => cod = value; }

        // * construtor
        public Jogo(string titulo, string desenvolvedora, string plataforma, int cod)
        {
            this.titulo = titulo;
            this.desenvolvedora = desenvolvedora;
            this.plataforma = plataforma;
            this.cod = cod;
            
        }
    }
}
