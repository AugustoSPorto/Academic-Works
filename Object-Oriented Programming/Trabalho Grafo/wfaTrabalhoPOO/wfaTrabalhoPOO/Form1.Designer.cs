namespace wfaTrabalhoPOO
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageClie = new System.Windows.Forms.TabPage();
            this.dataGridViewC = new System.Windows.Forms.DataGridView();
            this.maskedTextBoxTelefoneC = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCpfC = new System.Windows.Forms.MaskedTextBox();
            this.textBoxEmailC = new System.Windows.Forms.TextBox();
            this.textBoxNomeC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSairClie = new System.Windows.Forms.Button();
            this.buttonDelClien = new System.Windows.Forms.Button();
            this.buttonAtuClie = new System.Windows.Forms.Button();
            this.buttonGraClie = new System.Windows.Forms.Button();
            this.tabPageJogo = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxCodBarras = new System.Windows.Forms.TextBox();
            this.dataGridViewJ = new System.Windows.Forms.DataGridView();
            this.textBoxTituloJ = new System.Windows.Forms.TextBox();
            this.textBoxDevJ = new System.Windows.Forms.TextBox();
            this.textBoxPlatJ = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSairJogo = new System.Windows.Forms.Button();
            this.buttonDelJogo = new System.Windows.Forms.Button();
            this.buttonAtuJogo = new System.Windows.Forms.Button();
            this.buttonGraJogo = new System.Windows.Forms.Button();
            this.tabPageVend = new System.Windows.Forms.TabPage();
            this.maskedTextBoxCodC = new System.Windows.Forms.MaskedTextBox();
            this.dataGridViewV = new System.Windows.Forms.DataGridView();
            this.textBoxCodJ = new System.Windows.Forms.TextBox();
            this.maskedTextBoxPreco = new System.Windows.Forms.MaskedTextBox();
            this.numericUpDownQtds = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonSairVend = new System.Windows.Forms.Button();
            this.buttonDelVend = new System.Windows.Forms.Button();
            this.buttonAtuVend = new System.Windows.Forms.Button();
            this.buttonGraVend = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageClie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewC)).BeginInit();
            this.tabPageJogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJ)).BeginInit();
            this.tabPageVend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQtds)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageClie);
            this.tabControl1.Controls.Add(this.tabPageJogo);
            this.tabControl1.Controls.Add(this.tabPageVend);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1902, 1033);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageClie
            // 
            this.tabPageClie.BackColor = System.Drawing.Color.LightGray;
            this.tabPageClie.Controls.Add(this.dataGridViewC);
            this.tabPageClie.Controls.Add(this.maskedTextBoxTelefoneC);
            this.tabPageClie.Controls.Add(this.maskedTextBoxCpfC);
            this.tabPageClie.Controls.Add(this.textBoxEmailC);
            this.tabPageClie.Controls.Add(this.textBoxNomeC);
            this.tabPageClie.Controls.Add(this.label4);
            this.tabPageClie.Controls.Add(this.label3);
            this.tabPageClie.Controls.Add(this.label2);
            this.tabPageClie.Controls.Add(this.label1);
            this.tabPageClie.Controls.Add(this.buttonSairClie);
            this.tabPageClie.Controls.Add(this.buttonDelClien);
            this.tabPageClie.Controls.Add(this.buttonAtuClie);
            this.tabPageClie.Controls.Add(this.buttonGraClie);
            this.tabPageClie.Location = new System.Drawing.Point(4, 25);
            this.tabPageClie.Name = "tabPageClie";
            this.tabPageClie.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClie.Size = new System.Drawing.Size(1894, 1004);
            this.tabPageClie.TabIndex = 0;
            this.tabPageClie.Text = "Cliente";
            // 
            // dataGridViewC
            // 
            this.dataGridViewC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewC.Location = new System.Drawing.Point(249, 640);
            this.dataGridViewC.Name = "dataGridViewC";
            this.dataGridViewC.RowHeadersWidth = 51;
            this.dataGridViewC.RowTemplate.Height = 24;
            this.dataGridViewC.Size = new System.Drawing.Size(1324, 212);
            this.dataGridViewC.TabIndex = 14;
            // 
            // maskedTextBoxTelefoneC
            // 
            this.maskedTextBoxTelefoneC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.maskedTextBoxTelefoneC.Location = new System.Drawing.Point(1182, 282);
            this.maskedTextBoxTelefoneC.Mask = " (00) 00000-0000";
            this.maskedTextBoxTelefoneC.Name = "maskedTextBoxTelefoneC";
            this.maskedTextBoxTelefoneC.Size = new System.Drawing.Size(193, 34);
            this.maskedTextBoxTelefoneC.TabIndex = 12;
            // 
            // maskedTextBoxCpfC
            // 
            this.maskedTextBoxCpfC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.maskedTextBoxCpfC.Location = new System.Drawing.Point(1182, 167);
            this.maskedTextBoxCpfC.Mask = " 000.000.000-00";
            this.maskedTextBoxCpfC.Name = "maskedTextBoxCpfC";
            this.maskedTextBoxCpfC.Size = new System.Drawing.Size(193, 34);
            this.maskedTextBoxCpfC.TabIndex = 11;
            // 
            // textBoxEmailC
            // 
            this.textBoxEmailC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxEmailC.Location = new System.Drawing.Point(377, 280);
            this.textBoxEmailC.Name = "textBoxEmailC";
            this.textBoxEmailC.Size = new System.Drawing.Size(446, 34);
            this.textBoxEmailC.TabIndex = 10;
            // 
            // textBoxNomeC
            // 
            this.textBoxNomeC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxNomeC.Location = new System.Drawing.Point(377, 169);
            this.textBoxNomeC.Name = "textBoxNomeC";
            this.textBoxNomeC.Size = new System.Drawing.Size(446, 34);
            this.textBoxNomeC.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(1015, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(244, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(1039, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "CPF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(244, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome:";
            // 
            // buttonSairClie
            // 
            this.buttonSairClie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonSairClie.Location = new System.Drawing.Point(1396, 461);
            this.buttonSairClie.Name = "buttonSairClie";
            this.buttonSairClie.Size = new System.Drawing.Size(177, 54);
            this.buttonSairClie.TabIndex = 4;
            this.buttonSairClie.Text = "SAIR";
            this.buttonSairClie.UseVisualStyleBackColor = true;
            this.buttonSairClie.Click += new System.EventHandler(this.buttonSairClie_Click);
            // 
            // buttonDelClien
            // 
            this.buttonDelClien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonDelClien.Location = new System.Drawing.Point(1002, 461);
            this.buttonDelClien.Name = "buttonDelClien";
            this.buttonDelClien.Size = new System.Drawing.Size(227, 54);
            this.buttonDelClien.TabIndex = 3;
            this.buttonDelClien.Text = "DELETAR";
            this.buttonDelClien.UseVisualStyleBackColor = true;
            this.buttonDelClien.Click += new System.EventHandler(this.buttonDelClien_Click);
            // 
            // buttonAtuClie
            // 
            this.buttonAtuClie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonAtuClie.Location = new System.Drawing.Point(586, 461);
            this.buttonAtuClie.Name = "buttonAtuClie";
            this.buttonAtuClie.Size = new System.Drawing.Size(250, 54);
            this.buttonAtuClie.TabIndex = 2;
            this.buttonAtuClie.Text = "ATUALIZAR";
            this.buttonAtuClie.UseVisualStyleBackColor = true;
            this.buttonAtuClie.Click += new System.EventHandler(this.buttonAtuClie_Click);
            // 
            // buttonGraClie
            // 
            this.buttonGraClie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonGraClie.Location = new System.Drawing.Point(249, 461);
            this.buttonGraClie.Name = "buttonGraClie";
            this.buttonGraClie.Size = new System.Drawing.Size(199, 54);
            this.buttonGraClie.TabIndex = 1;
            this.buttonGraClie.Text = "GRAVAR";
            this.buttonGraClie.UseVisualStyleBackColor = true;
            this.buttonGraClie.Click += new System.EventHandler(this.buttonGraClie_Click);
            // 
            // tabPageJogo
            // 
            this.tabPageJogo.BackColor = System.Drawing.Color.LightGray;
            this.tabPageJogo.Controls.Add(this.label12);
            this.tabPageJogo.Controls.Add(this.textBoxCodBarras);
            this.tabPageJogo.Controls.Add(this.dataGridViewJ);
            this.tabPageJogo.Controls.Add(this.textBoxTituloJ);
            this.tabPageJogo.Controls.Add(this.textBoxDevJ);
            this.tabPageJogo.Controls.Add(this.textBoxPlatJ);
            this.tabPageJogo.Controls.Add(this.label7);
            this.tabPageJogo.Controls.Add(this.label6);
            this.tabPageJogo.Controls.Add(this.label5);
            this.tabPageJogo.Controls.Add(this.buttonSairJogo);
            this.tabPageJogo.Controls.Add(this.buttonDelJogo);
            this.tabPageJogo.Controls.Add(this.buttonAtuJogo);
            this.tabPageJogo.Controls.Add(this.buttonGraJogo);
            this.tabPageJogo.Location = new System.Drawing.Point(4, 25);
            this.tabPageJogo.Name = "tabPageJogo";
            this.tabPageJogo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageJogo.Size = new System.Drawing.Size(1894, 1004);
            this.tabPageJogo.TabIndex = 1;
            this.tabPageJogo.Text = "Jogo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label12.Location = new System.Drawing.Point(240, 369);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(192, 29);
            this.label12.TabIndex = 18;
            this.label12.Text = "Código do Jogo:";
            // 
            // textBoxCodBarras
            // 
            this.textBoxCodBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxCodBarras.Location = new System.Drawing.Point(466, 366);
            this.textBoxCodBarras.Name = "textBoxCodBarras";
            this.textBoxCodBarras.Size = new System.Drawing.Size(965, 34);
            this.textBoxCodBarras.TabIndex = 17;
            // 
            // dataGridViewJ
            // 
            this.dataGridViewJ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJ.Location = new System.Drawing.Point(234, 607);
            this.dataGridViewJ.Name = "dataGridViewJ";
            this.dataGridViewJ.RowHeadersWidth = 51;
            this.dataGridViewJ.RowTemplate.Height = 24;
            this.dataGridViewJ.Size = new System.Drawing.Size(1450, 283);
            this.dataGridViewJ.TabIndex = 16;
            // 
            // textBoxTituloJ
            // 
            this.textBoxTituloJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxTituloJ.Location = new System.Drawing.Point(466, 71);
            this.textBoxTituloJ.Name = "textBoxTituloJ";
            this.textBoxTituloJ.Size = new System.Drawing.Size(965, 34);
            this.textBoxTituloJ.TabIndex = 15;
            // 
            // textBoxDevJ
            // 
            this.textBoxDevJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxDevJ.Location = new System.Drawing.Point(466, 163);
            this.textBoxDevJ.Name = "textBoxDevJ";
            this.textBoxDevJ.Size = new System.Drawing.Size(965, 34);
            this.textBoxDevJ.TabIndex = 14;
            // 
            // textBoxPlatJ
            // 
            this.textBoxPlatJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxPlatJ.Location = new System.Drawing.Point(466, 260);
            this.textBoxPlatJ.Name = "textBoxPlatJ";
            this.textBoxPlatJ.Size = new System.Drawing.Size(965, 34);
            this.textBoxPlatJ.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(267, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "Plataforma:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(240, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Desenvolvedora:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(297, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Título:";
            // 
            // buttonSairJogo
            // 
            this.buttonSairJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonSairJogo.Location = new System.Drawing.Point(1464, 461);
            this.buttonSairJogo.Name = "buttonSairJogo";
            this.buttonSairJogo.Size = new System.Drawing.Size(220, 61);
            this.buttonSairJogo.TabIndex = 9;
            this.buttonSairJogo.Text = "SAIR";
            this.buttonSairJogo.UseVisualStyleBackColor = true;
            this.buttonSairJogo.Click += new System.EventHandler(this.buttonSairJogo_Click);
            // 
            // buttonDelJogo
            // 
            this.buttonDelJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonDelJogo.Location = new System.Drawing.Point(1079, 461);
            this.buttonDelJogo.Name = "buttonDelJogo";
            this.buttonDelJogo.Size = new System.Drawing.Size(209, 61);
            this.buttonDelJogo.TabIndex = 8;
            this.buttonDelJogo.Text = "DELETAR";
            this.buttonDelJogo.UseVisualStyleBackColor = true;
            this.buttonDelJogo.Click += new System.EventHandler(this.buttonDelJogo_Click);
            // 
            // buttonAtuJogo
            // 
            this.buttonAtuJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonAtuJogo.Location = new System.Drawing.Point(609, 461);
            this.buttonAtuJogo.Name = "buttonAtuJogo";
            this.buttonAtuJogo.Size = new System.Drawing.Size(285, 61);
            this.buttonAtuJogo.TabIndex = 7;
            this.buttonAtuJogo.Text = "ATUALIZAR";
            this.buttonAtuJogo.UseVisualStyleBackColor = true;
            this.buttonAtuJogo.Click += new System.EventHandler(this.buttonAtuJogo_Click);
            // 
            // buttonGraJogo
            // 
            this.buttonGraJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonGraJogo.Location = new System.Drawing.Point(234, 461);
            this.buttonGraJogo.Name = "buttonGraJogo";
            this.buttonGraJogo.Size = new System.Drawing.Size(216, 61);
            this.buttonGraJogo.TabIndex = 6;
            this.buttonGraJogo.Text = "GRAVAR";
            this.buttonGraJogo.UseVisualStyleBackColor = true;
            this.buttonGraJogo.Click += new System.EventHandler(this.buttonGraJogo_Click);
            // 
            // tabPageVend
            // 
            this.tabPageVend.BackColor = System.Drawing.Color.LightGray;
            this.tabPageVend.Controls.Add(this.maskedTextBoxCodC);
            this.tabPageVend.Controls.Add(this.dataGridViewV);
            this.tabPageVend.Controls.Add(this.textBoxCodJ);
            this.tabPageVend.Controls.Add(this.maskedTextBoxPreco);
            this.tabPageVend.Controls.Add(this.numericUpDownQtds);
            this.tabPageVend.Controls.Add(this.label11);
            this.tabPageVend.Controls.Add(this.label10);
            this.tabPageVend.Controls.Add(this.label9);
            this.tabPageVend.Controls.Add(this.label8);
            this.tabPageVend.Controls.Add(this.buttonSairVend);
            this.tabPageVend.Controls.Add(this.buttonDelVend);
            this.tabPageVend.Controls.Add(this.buttonAtuVend);
            this.tabPageVend.Controls.Add(this.buttonGraVend);
            this.tabPageVend.Location = new System.Drawing.Point(4, 25);
            this.tabPageVend.Name = "tabPageVend";
            this.tabPageVend.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVend.Size = new System.Drawing.Size(1894, 1004);
            this.tabPageVend.TabIndex = 2;
            this.tabPageVend.Text = "Vendas";
            // 
            // maskedTextBoxCodC
            // 
            this.maskedTextBoxCodC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.maskedTextBoxCodC.Location = new System.Drawing.Point(466, 131);
            this.maskedTextBoxCodC.Mask = " 000.000.000-00";
            this.maskedTextBoxCodC.Name = "maskedTextBoxCodC";
            this.maskedTextBoxCodC.Size = new System.Drawing.Size(191, 34);
            this.maskedTextBoxCodC.TabIndex = 19;
            // 
            // dataGridViewV
            // 
            this.dataGridViewV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewV.Location = new System.Drawing.Point(251, 625);
            this.dataGridViewV.Name = "dataGridViewV";
            this.dataGridViewV.RowHeadersWidth = 51;
            this.dataGridViewV.RowTemplate.Height = 24;
            this.dataGridViewV.Size = new System.Drawing.Size(1368, 244);
            this.dataGridViewV.TabIndex = 18;
            // 
            // textBoxCodJ
            // 
            this.textBoxCodJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxCodJ.Location = new System.Drawing.Point(466, 277);
            this.textBoxCodJ.Name = "textBoxCodJ";
            this.textBoxCodJ.Size = new System.Drawing.Size(446, 34);
            this.textBoxCodJ.TabIndex = 17;
            // 
            // maskedTextBoxPreco
            // 
            this.maskedTextBoxPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.maskedTextBoxPreco.Location = new System.Drawing.Point(1274, 270);
            this.maskedTextBoxPreco.Name = "maskedTextBoxPreco";
            this.maskedTextBoxPreco.Size = new System.Drawing.Size(345, 34);
            this.maskedTextBoxPreco.TabIndex = 15;
            // 
            // numericUpDownQtds
            // 
            this.numericUpDownQtds.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.numericUpDownQtds.Location = new System.Drawing.Point(1396, 134);
            this.numericUpDownQtds.Name = "numericUpDownQtds";
            this.numericUpDownQtds.Size = new System.Drawing.Size(85, 34);
            this.numericUpDownQtds.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label11.Location = new System.Drawing.Point(1073, 275);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 29);
            this.label11.TabIndex = 13;
            this.label11.Text = "Preço Unitário:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label10.Location = new System.Drawing.Point(1073, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(260, 29);
            this.label10.TabIndex = 12;
            this.label10.Text = "Quantidade de Cópias:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label9.Location = new System.Drawing.Point(246, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(192, 29);
            this.label9.TabIndex = 11;
            this.label9.Text = "Código do Jogo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label8.Location = new System.Drawing.Point(246, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 29);
            this.label8.TabIndex = 10;
            this.label8.Text = "CPF do Cliente:";
            // 
            // buttonSairVend
            // 
            this.buttonSairVend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonSairVend.Location = new System.Drawing.Point(1450, 459);
            this.buttonSairVend.Name = "buttonSairVend";
            this.buttonSairVend.Size = new System.Drawing.Size(169, 57);
            this.buttonSairVend.TabIndex = 9;
            this.buttonSairVend.Text = "SAIR";
            this.buttonSairVend.UseVisualStyleBackColor = true;
            this.buttonSairVend.Click += new System.EventHandler(this.buttonSairVend_Click);
            // 
            // buttonDelVend
            // 
            this.buttonDelVend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonDelVend.Location = new System.Drawing.Point(1078, 459);
            this.buttonDelVend.Name = "buttonDelVend";
            this.buttonDelVend.Size = new System.Drawing.Size(235, 57);
            this.buttonDelVend.TabIndex = 8;
            this.buttonDelVend.Text = "DELETAR";
            this.buttonDelVend.UseVisualStyleBackColor = true;
            this.buttonDelVend.Click += new System.EventHandler(this.buttonDelVend_Click);
            // 
            // buttonAtuVend
            // 
            this.buttonAtuVend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonAtuVend.Location = new System.Drawing.Point(653, 459);
            this.buttonAtuVend.Name = "buttonAtuVend";
            this.buttonAtuVend.Size = new System.Drawing.Size(259, 57);
            this.buttonAtuVend.TabIndex = 7;
            this.buttonAtuVend.Text = "ATUALIZAR";
            this.buttonAtuVend.UseVisualStyleBackColor = true;
            this.buttonAtuVend.Click += new System.EventHandler(this.buttonAtuVend_Click);
            // 
            // buttonGraVend
            // 
            this.buttonGraVend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonGraVend.Location = new System.Drawing.Point(251, 459);
            this.buttonGraVend.Name = "buttonGraVend";
            this.buttonGraVend.Size = new System.Drawing.Size(229, 57);
            this.buttonGraVend.TabIndex = 6;
            this.buttonGraVend.Text = "GRAVAR";
            this.buttonGraVend.UseVisualStyleBackColor = true;
            this.buttonGraVend.Click += new System.EventHandler(this.buttonGraVend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Venda de Jogos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabPageClie.ResumeLayout(false);
            this.tabPageClie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewC)).EndInit();
            this.tabPageJogo.ResumeLayout(false);
            this.tabPageJogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJ)).EndInit();
            this.tabPageVend.ResumeLayout(false);
            this.tabPageVend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQtds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageClie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSairClie;
        private System.Windows.Forms.Button buttonDelClien;
        private System.Windows.Forms.Button buttonAtuClie;
        private System.Windows.Forms.Button buttonGraClie;
        private System.Windows.Forms.TabPage tabPageJogo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSairJogo;
        private System.Windows.Forms.Button buttonDelJogo;
        private System.Windows.Forms.Button buttonAtuJogo;
        private System.Windows.Forms.Button buttonGraJogo;
        private System.Windows.Forms.TabPage tabPageVend;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPreco;
        private System.Windows.Forms.NumericUpDown numericUpDownQtds;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonSairVend;
        private System.Windows.Forms.Button buttonDelVend;
        private System.Windows.Forms.Button buttonAtuVend;
        private System.Windows.Forms.Button buttonGraVend;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefoneC;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCpfC;
        private System.Windows.Forms.TextBox textBoxEmailC;
        private System.Windows.Forms.TextBox textBoxNomeC;
        private System.Windows.Forms.TextBox textBoxTituloJ;
        private System.Windows.Forms.TextBox textBoxDevJ;
        private System.Windows.Forms.TextBox textBoxPlatJ;
        private System.Windows.Forms.TextBox textBoxCodJ;
        private System.Windows.Forms.DataGridView dataGridViewC;
        private System.Windows.Forms.DataGridView dataGridViewJ;
        private System.Windows.Forms.DataGridView dataGridViewV;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxCodBarras;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCodC;
    }
}

