using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaPorto
{
    internal class Porto
    {
        private Pilha local1;
        private Pilha local2;
        private Pilha local3;
        private Pilha local4;

        public Porto() 
        {
            local1 = new Pilha();
            local2 = new Pilha();
            local3 = new Pilha();
            local4 = new Pilha();
        }

        internal Pilha Local1 { get => local1; set => local1 = value; }
        internal Pilha Local2 { get => local2; set => local2 = value; }
        internal Pilha Local3 { get => local3; set => local3 = value; }
        internal Pilha Local4 { get => local4; set => local4 = value; }

        public void adicionar(string nome)
        {
            if (local1.contem(nome) || local2.contem(nome) || local3.contem(nome) || local4.contem(nome))
            {
                MessageBox.Show("Contêiner já foi inserido!", "Impossível empilhar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int menor_tamanho = acharMenorTamanho();
            if (menor_tamanho == 1)
            {
                local1.push(nome);
            }
            else if (menor_tamanho == 2)
            {
                local2.push(nome);
            }
            else if (menor_tamanho == 3)
            {
                local3.push(nome);
            }
            else
            {
                local4.push(nome);
            }
            MessageBox.Show("Contêiner inserido com sucesso!", "Formato válido", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public int acharMenorTamanho() 
        {
            int menor = local1.Tamanho;
            int indice = 1;
            if (local2.Tamanho < menor) 
            {
                menor = local2.Tamanho;
                indice = 2;
            }
            if (local3.Tamanho < menor)
            {
                menor = local3.Tamanho;
                indice = 3;
            }
            if (local4.Tamanho < menor)
            {
                menor = local4.Tamanho;
                indice = 4;
            }
            return indice;
        }

        public void remover(string nome)
        {
            if (!local1.contem(nome) &&  !local2.contem(nome) && !local3.contem(nome) && !local4.contem(nome))
            {
                MessageBox.Show("Contêiner inexistente!", "Impossível desempilhar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (local1.Topo.Info != nome && local2.Topo.Info != nome && local3.Topo.Info != nome 
            && local4.Topo.Info != nome)
            {
                MessageBox.Show("Contêiner não está no topo!", "Impossível desempilhar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (local1.Topo.Info == nome)
                {
                    local1.pop();
                }
                else if (local2.Topo.Info == nome)
                {
                    local2.pop();
                }
                else if (local3.Topo.Info == nome)
                {
                    local3.pop();
                }
                else 
                {
                    local4.pop();
                }
                MessageBox.Show("Contêiner removido com sucesso!", "Formato válido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public bool estaCheio() 
        { 
            if (local1.Tamanho == 3 && local2.Tamanho == 3 && local3.Tamanho == 3 && local4.Tamanho == 3)
            {
                return true;
            }
            return false;
        }

        public bool estaVazio() 
        {
            if (local1.Tamanho == 0 && local2.Tamanho == 0 && local3.Tamanho == 0 && local4.Tamanho == 0)
            {
                return true;
            }
            return false;
        }


    }
}
