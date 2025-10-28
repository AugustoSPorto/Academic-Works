namespace Modulo1
{
    partial class FormModulo1
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
            this.components = new System.ComponentModel.Container();
            this.buttonPararEnvioV1 = new System.Windows.Forms.Button();
            this.buttonIniciarMod1Iniciar = new System.Windows.Forms.Button();
            this.numericUpDownMod1Corrente = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMod1FreqEnvio = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonMod1Limpar = new System.Windows.Forms.Button();
            this.propertyGridUnidGeradoras = new System.Windows.Forms.PropertyGrid();
            this.listViewMod1UnidGeradora = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownMod1CodUnidGen = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownMod1Curto = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.timerPlotaModulo1SinaisEnviados = new System.Windows.Forms.Timer(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.formsPlotPacotesEnviados = new ScottPlot.FormsPlot();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxRecepcaoConexao = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMod1Corrente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMod1FreqEnvio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMod1CodUnidGen)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMod1Curto)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPararEnvioV1
            // 
            this.buttonPararEnvioV1.Enabled = false;
            this.buttonPararEnvioV1.Location = new System.Drawing.Point(157, 19);
            this.buttonPararEnvioV1.Name = "buttonPararEnvioV1";
            this.buttonPararEnvioV1.Size = new System.Drawing.Size(124, 36);
            this.buttonPararEnvioV1.TabIndex = 24;
            this.buttonPararEnvioV1.Text = "Parar";
            this.buttonPararEnvioV1.UseVisualStyleBackColor = true;
            this.buttonPararEnvioV1.Click += new System.EventHandler(this.buttonPararEnvioV1_Click);
            // 
            // buttonIniciarMod1Iniciar
            // 
            this.buttonIniciarMod1Iniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIniciarMod1Iniciar.Location = new System.Drawing.Point(9, 19);
            this.buttonIniciarMod1Iniciar.Name = "buttonIniciarMod1Iniciar";
            this.buttonIniciarMod1Iniciar.Size = new System.Drawing.Size(142, 36);
            this.buttonIniciarMod1Iniciar.TabIndex = 23;
            this.buttonIniciarMod1Iniciar.Text = "&Iniciar envios";
            this.buttonIniciarMod1Iniciar.UseVisualStyleBackColor = true;
            this.buttonIniciarMod1Iniciar.Click += new System.EventHandler(this.buttonIniciarParte1SV_Click);
            // 
            // numericUpDownMod1Corrente
            // 
            this.numericUpDownMod1Corrente.Location = new System.Drawing.Point(150, 91);
            this.numericUpDownMod1Corrente.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMod1Corrente.Name = "numericUpDownMod1Corrente";
            this.numericUpDownMod1Corrente.Size = new System.Drawing.Size(134, 22);
            this.numericUpDownMod1Corrente.TabIndex = 47;
            this.numericUpDownMod1Corrente.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownMod1FreqEnvio
            // 
            this.numericUpDownMod1FreqEnvio.Location = new System.Drawing.Point(129, 62);
            this.numericUpDownMod1FreqEnvio.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDownMod1FreqEnvio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMod1FreqEnvio.Name = "numericUpDownMod1FreqEnvio";
            this.numericUpDownMod1FreqEnvio.Size = new System.Drawing.Size(155, 22);
            this.numericUpDownMod1FreqEnvio.TabIndex = 21;
            this.numericUpDownMod1FreqEnvio.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Freq. envio (ms):";
            // 
            // buttonMod1Limpar
            // 
            this.buttonMod1Limpar.Location = new System.Drawing.Point(221, 526);
            this.buttonMod1Limpar.Name = "buttonMod1Limpar";
            this.buttonMod1Limpar.Size = new System.Drawing.Size(67, 23);
            this.buttonMod1Limpar.TabIndex = 58;
            this.buttonMod1Limpar.Text = "Limpar";
            this.buttonMod1Limpar.UseVisualStyleBackColor = true;
            this.buttonMod1Limpar.Click += new System.EventHandler(this.buttonMod1Limpar_Click);
            // 
            // propertyGridUnidGeradoras
            // 
            this.propertyGridUnidGeradoras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGridUnidGeradoras.Enabled = false;
            this.propertyGridUnidGeradoras.Location = new System.Drawing.Point(303, 3);
            this.propertyGridUnidGeradoras.Name = "propertyGridUnidGeradoras";
            this.propertyGridUnidGeradoras.Size = new System.Drawing.Size(294, 646);
            this.propertyGridUnidGeradoras.TabIndex = 48;
            // 
            // listViewMod1UnidGeradora
            // 
            this.listViewMod1UnidGeradora.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewMod1UnidGeradora.HideSelection = false;
            this.listViewMod1UnidGeradora.Location = new System.Drawing.Point(12, 281);
            this.listViewMod1UnidGeradora.Name = "listViewMod1UnidGeradora";
            this.listViewMod1UnidGeradora.Size = new System.Drawing.Size(276, 239);
            this.listViewMod1UnidGeradora.TabIndex = 56;
            this.listViewMod1UnidGeradora.UseCompatibleStateImageBehavior = false;
            this.listViewMod1UnidGeradora.View = System.Windows.Forms.View.Details;
            this.listViewMod1UnidGeradora.SelectedIndexChanged += new System.EventHandler(this.listViewMod1UnidGeradora_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Cód. MU";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Freq (ms)";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "I original";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "I curto";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(13, 166);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(275, 31);
            this.buttonAdicionar.TabIndex = 58;
            this.buttonAdicionar.Text = "Adicionar MU";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 55;
            this.label3.Text = "Valor corrente RMS:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 16);
            this.label2.TabIndex = 54;
            this.label2.Text = "Código unidade geradora:";
            // 
            // numericUpDownMod1CodUnidGen
            // 
            this.numericUpDownMod1CodUnidGen.Location = new System.Drawing.Point(190, 34);
            this.numericUpDownMod1CodUnidGen.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownMod1CodUnidGen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMod1CodUnidGen.Name = "numericUpDownMod1CodUnidGen";
            this.numericUpDownMod1CodUnidGen.Size = new System.Drawing.Size(94, 22);
            this.numericUpDownMod1CodUnidGen.TabIndex = 53;
            this.numericUpDownMod1CodUnidGen.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.buttonMod1Limpar);
            this.groupBox2.Controls.Add(this.numericUpDownMod1Curto);
            this.groupBox2.Controls.Add(this.listViewMod1UnidGeradora);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.buttonAdicionar);
            this.groupBox2.Controls.Add(this.numericUpDownMod1Corrente);
            this.groupBox2.Controls.Add(this.numericUpDownMod1FreqEnvio);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.numericUpDownMod1CodUnidGen);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 646);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adicionar nova unidade geradora";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonIniciarMod1Iniciar);
            this.groupBox1.Controls.Add(this.buttonPararEnvioV1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(3, 582);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 61);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            // 
            // numericUpDownMod1Curto
            // 
            this.numericUpDownMod1Curto.Location = new System.Drawing.Point(137, 122);
            this.numericUpDownMod1Curto.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMod1Curto.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMod1Curto.Name = "numericUpDownMod1Curto";
            this.numericUpDownMod1Curto.Size = new System.Drawing.Size(147, 22);
            this.numericUpDownMod1Curto.TabIndex = 59;
            this.numericUpDownMod1Curto.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 16);
            this.label9.TabIndex = 60;
            this.label9.Text = "Valor ref. de curto:";
            // 
            // timerPlotaModulo1SinaisEnviados
            // 
            this.timerPlotaModulo1SinaisEnviados.Interval = 1000;
            this.timerPlotaModulo1SinaisEnviados.Tick += new System.EventHandler(this.timerPlotaModulo1SinaisEnviados_Tick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.formsPlotPacotesEnviados);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(603, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(501, 646);
            this.groupBox5.TabIndex = 48;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Visualização pacotes saída";
            // 
            // formsPlotPacotesEnviados
            // 
            this.formsPlotPacotesEnviados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formsPlotPacotesEnviados.Location = new System.Drawing.Point(3, 18);
            this.formsPlotPacotesEnviados.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.formsPlotPacotesEnviados.Name = "formsPlotPacotesEnviados";
            this.formsPlotPacotesEnviados.Size = new System.Drawing.Size(495, 625);
            this.formsPlotPacotesEnviados.TabIndex = 23;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 371F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.propertyGridUnidGeradoras, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxRecepcaoConexao, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1478, 652);
            this.tableLayoutPanel1.TabIndex = 49;
            // 
            // textBoxRecepcaoConexao
            // 
            this.textBoxRecepcaoConexao.AcceptsTab = true;
            this.textBoxRecepcaoConexao.Location = new System.Drawing.Point(1110, 3);
            this.textBoxRecepcaoConexao.Multiline = true;
            this.textBoxRecepcaoConexao.Name = "textBoxRecepcaoConexao";
            this.textBoxRecepcaoConexao.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxRecepcaoConexao.Size = new System.Drawing.Size(365, 646);
            this.textBoxRecepcaoConexao.TabIndex = 50;
            // 
            // FormModulo1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 652);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormModulo1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador MockUP - módulo 1b";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMod1Corrente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMod1FreqEnvio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMod1CodUnidGen)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMod1Curto)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonPararEnvioV1;
        private System.Windows.Forms.Button buttonIniciarMod1Iniciar;
        private System.Windows.Forms.NumericUpDown numericUpDownMod1Corrente;
        private System.Windows.Forms.NumericUpDown numericUpDownMod1FreqEnvio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView listViewMod1UnidGeradora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownMod1CodUnidGen;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PropertyGrid propertyGridUnidGeradoras;
        private System.Windows.Forms.Button buttonMod1Limpar;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.NumericUpDown numericUpDownMod1Curto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timerPlotaModulo1SinaisEnviados;
        private System.Windows.Forms.GroupBox groupBox5;
        private ScottPlot.FormsPlot formsPlotPacotesEnviados;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxRecepcaoConexao;
    }
}

