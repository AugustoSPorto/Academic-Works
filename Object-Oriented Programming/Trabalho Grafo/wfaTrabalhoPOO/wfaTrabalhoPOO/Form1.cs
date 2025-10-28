using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfaBancoDeDadosFinanciadora;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace wfaTrabalhoPOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void limpar_text()
        {
            textBoxNomeC.Clear();
            textBoxEmailC.Clear();
            maskedTextBoxCpfC.Clear();
            maskedTextBoxTelefoneC.Clear();

            textBoxTituloJ.Clear();
            textBoxDevJ.Clear();
            textBoxPlatJ.Clear();
            textBoxCodBarras.Clear();

            maskedTextBoxCodC.Clear();
            textBoxCodJ.Clear();
            numericUpDownQtds.ResetText();
            maskedTextBoxPreco.Clear();
        }

        private void buttonGraClie_Click(object sender, EventArgs e)
        {
            if (textBoxEmailC.Text == "" || textBoxEmailC.Text == "" || maskedTextBoxTelefoneC == null || maskedTextBoxCpfC == null)
            {
                MessageBox.Show("Um ou mais campos vazios!", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string nome = textBoxNomeC.Text;
                    string email = textBoxEmailC.Text;
                    string cpf = maskedTextBoxCpfC.Text;
                    string telefone = maskedTextBoxTelefoneC.Text;

                    Cliente c1 = new Cliente(nome, email, cpf, telefone);

                    ConexaoString stringConexao = new ConexaoString();

                    string conexao = stringConexao.ConnString();

                    NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco

                    con.Open(); // Abre a conexao com o banco

                    //INSERIR
                    string commandText = String.Format("INSERT INTO cliente(nome_cliente,email_cliente,cpf_cliente,telefone_cliente) " +
                                                        "values('{0}','{1}','{2}','{3}')", c1.Nome, c1.Email, c1.Cpf, c1.Telefone);

                    using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
                    {
                        pgsqlcommand.ExecuteNonQuery();
                    }

                    // EXIBIR
                    DataTable dt = new DataTable(); // Objeto que pode conter tabelas

                    commandText = "SELECT * FROM cliente ORDER BY id_cliente";

                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(commandText, con)) // faz a ligação em bd e o datatable
                    {
                        Adpt.Fill(dt);
                    }

                    dataGridViewC.DataSource = dt;

                    con.Close();

                    MessageBox.Show("Cadastro Inserido com Sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limpar_text();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Um ou mais campos inválidos!", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void buttonAtuClie_Click(object sender, EventArgs e)
        {
                ConexaoString stringConexao = new ConexaoString();

                string conexao = stringConexao.ConnString();

                NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco

                con.Open(); // Abre a conexao com o banco

                // EXIBIR
                DataTable dt = new DataTable(); // Objeto que pode conter tabelas

                string commandText = "SELECT * FROM cliente ORDER BY id_cliente";

                using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(commandText, con)) // faz a ligação em bd e o datatable
                {
                    Adpt.Fill(dt);
                }

                dataGridViewC.DataSource = dt;

                con.Close();

                MessageBox.Show("Cadastro Atualizado com Sucesso! ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                limpar_text();

        }

        private void buttonDelClien_Click(object sender, EventArgs e)
        {
            if (textBoxEmailC.Text == "" || textBoxEmailC.Text == "" || maskedTextBoxTelefoneC == null || maskedTextBoxCpfC == null)
            {
                MessageBox.Show("Um ou mais campos vazios!", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string cpf = maskedTextBoxCpfC.Text;

                    ConexaoString stringConexao = new ConexaoString();

                    string conexao = stringConexao.ConnString();

                    NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco

                    con.Open(); // Abre a conexao com o banco

                    string commandText = String.Format("DELETE FROM cliente WHERE cpf_cliente = '{0}'", cpf);

                    using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
                    {
                        pgsqlcommand.ExecuteNonQuery();
                    }

                    con.Close();

                    MessageBox.Show("Cadastro Excluido com Sucesso! ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limpar_text();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Um ou mais campos inválidos!", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSairClie_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonGraJogo_Click(object sender, EventArgs e)
        {
            if (textBoxTituloJ.Text == "" || textBoxPlatJ.Text == "" || textBoxDevJ.Text == "" || textBoxCodBarras.Text == "")
            {
                MessageBox.Show("Um ou mais campos vazios!", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string titulo = textBoxTituloJ.Text;
                    string dev = textBoxDevJ.Text;
                    string plat = textBoxPlatJ.Text;
                    int codigo = Convert.ToInt32(textBoxCodBarras.Text);

                    Jogo j1 = new Jogo(titulo, dev, plat, codigo);

                    ConexaoString stringConexao = new ConexaoString();

                    string conexao = stringConexao.ConnString();

                    NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco

                    con.Open(); // Abre a conexao com o banco

                    //INSERIR
                    string commandText = String.Format("INSERT INTO jogo(titulo_jogo,desenvolvedora_jogo,plataforma_jogo, codigo_jogo) " +
                                                        "values('{0}','{1}','{2}', {3})", j1.Titulo, j1.Desenvolvedora, j1.Plataforma, j1.Cod);

                    using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
                    {
                        pgsqlcommand.ExecuteNonQuery();
                    }

                    // EXIBIR
                    DataTable dt = new DataTable(); // Objeto que pode conter tabelas

                    commandText = "SELECT * FROM jogo ORDER BY id_jogo";

                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(commandText, con)) // faz a ligação em bd e o datatable
                    {
                        Adpt.Fill(dt);
                    }

                    dataGridViewJ.DataSource = dt;

                    con.Close();

                    MessageBox.Show("Cadastro Inserido com Sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limpar_text();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Um ou mais campos inválidos!", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonAtuJogo_Click(object sender, EventArgs e)
        {
                ConexaoString stringConexao = new ConexaoString();

                string conexao = stringConexao.ConnString();

                NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco

                con.Open(); // Abre a conexao com o banco


                // EXIBIR
                DataTable dt = new DataTable(); // Objeto que pode conter tabelas

                string commandText = "SELECT * FROM jogo ORDER BY id_jogo";

                using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(commandText, con)) // faz a ligação em bd e o datatable
                {
                    Adpt.Fill(dt);
                }

                dataGridViewJ.DataSource = dt;

                con.Close();

                MessageBox.Show("Cadastro Atualizado com Sucesso! ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                limpar_text();
        }

        private void buttonDelJogo_Click(object sender, EventArgs e)
        {
            if (textBoxTituloJ.Text == "" || textBoxPlatJ.Text == "" || textBoxDevJ.Text == "" || textBoxCodBarras.Text == "")
            {
                MessageBox.Show("Um ou mais campos vazios!", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int codigo = Convert.ToInt32(textBoxCodBarras.Text);

                    ConexaoString stringConexao = new ConexaoString();

                    string conexao = stringConexao.ConnString();

                    NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco

                    con.Open(); // Abre a conexao com o banco

                    string commandText = String.Format("DELETE FROM jogo WHERE codigo_jogo = {0}", codigo);

                    using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
                    {
                        pgsqlcommand.ExecuteNonQuery();
                    }

                    con.Close();

                    MessageBox.Show("Cadastro Excluido com Sucesso! ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limpar_text();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Um ou mais campos inválidos!", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }   
        }

        private void buttonSairJogo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonGraVend_Click(object sender, EventArgs e)
        {
            if (textBoxCodJ.Text == "" || maskedTextBoxCodC.Text == "")
            {
                MessageBox.Show("Um ou mais campos vazios!", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string codC = maskedTextBoxCodC.Text;
                    int codJ = Convert.ToInt32(textBoxCodJ.Text);
                    int qtd = Convert.ToInt32(numericUpDownQtds.Value);
                    double preco = Convert.ToDouble(maskedTextBoxPreco.Text);

                    Venda v1 = new Venda(codC, codJ, qtd, preco);

                    ConexaoString stringConexao = new ConexaoString();

                    string conexao = stringConexao.ConnString();

                    NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco

                    con.Open(); // Abre a conexao com o banco

                    //INSERIR
                    string commandText = String.Format("INSERT INTO venda(id_cliente,id_jogo,quantidade_unidades,preco_unidade) " +
                                                        "values('{0}',{1},{2},{3})", v1.Cod_c, v1.Cod_j, v1.Qtd, v1.Preco);

                    using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
                    {
                        pgsqlcommand.ExecuteNonQuery();
                    }

                    // EXIBIR
                    DataTable dt = new DataTable(); // Objeto que pode conter tabelas

                    commandText = "SELECT * FROM venda ORDER BY cod_venda";

                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(commandText, con)) // faz a ligação em bd e o datatable
                    {
                        Adpt.Fill(dt);
                    }

                    dataGridViewV.DataSource = dt;

                    con.Close();

                    MessageBox.Show("Cadastro Inserido com Sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limpar_text();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Um ou mais campos inválidos!", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonAtuVend_Click(object sender, EventArgs e)
        {
                ConexaoString stringConexao = new ConexaoString();

                string conexao = stringConexao.ConnString();

                NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco

                con.Open(); // Abre a conexao com o banco


                // EXIBIR
                DataTable dt = new DataTable(); // Objeto que pode conter tabelas

                string commandText = "SELECT * FROM venda ORDER BY cod_venda";

                using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(commandText, con)) // faz a ligação em bd e o datatable
                {
                    Adpt.Fill(dt);
                }

                dataGridViewV.DataSource = dt;

                con.Close();

                MessageBox.Show("Cadastro Atualizado com Sucesso! ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            limpar_text();
        }

        private void buttonDelVend_Click(object sender, EventArgs e)
        {
            if (textBoxCodJ.Text == "" || maskedTextBoxCodC.Text == "")
            {
                MessageBox.Show("Um ou mais campos vazios!", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string codC = maskedTextBoxCodC.Text;

                    ConexaoString stringConexao = new ConexaoString();

                    string conexao = stringConexao.ConnString();

                    NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco

                    con.Open(); // Abre a conexao com o banco

                    string commandText = String.Format("DELETE FROM venda WHERE id_cliente = '{0}'", codC);

                    using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
                    {
                        pgsqlcommand.ExecuteNonQuery();
                    }

                    con.Close();

                    MessageBox.Show("Cadastro Excluido com Sucesso! ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limpar_text();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Um ou mais campos inválidos!", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void buttonSairVend_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}


