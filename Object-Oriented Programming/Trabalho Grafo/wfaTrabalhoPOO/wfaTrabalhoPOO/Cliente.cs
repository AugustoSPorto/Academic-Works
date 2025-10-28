using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaTrabalhoPOO
{
    internal class Cliente
    {
        // Atributos
        private string nome;
        private string email;
        private string cpf;
        private string telefone;

        // Métodos
        // * setters e getters
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Telefone { get => telefone; set => telefone = value; }

        // * construtores
        public Cliente(string nome, string email, string cpf, string telefone) 
        {
            this.nome = nome;
            this.email = email;
            this.cpf = cpf;
            this.telefone = telefone;
        }

    }
}
