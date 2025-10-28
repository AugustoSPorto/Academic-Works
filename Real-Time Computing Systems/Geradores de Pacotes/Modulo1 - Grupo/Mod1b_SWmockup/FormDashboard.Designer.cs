namespace Mod1b_SWmockup
{
    partial class FormDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            mUBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            mUBindingSource1 = new BindingSource(components);
            button1 = new Button();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apelidoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Corrente = new DataGridViewTextBoxColumn();
            Tensao = new DataGridViewTextBoxColumn();
            valorCurtoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contadorPacotesEnviadosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descricaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            socketConexaoUDPDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ipConexaoEnvioUDPDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mUBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mUBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(220, 23, 24, 29);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(bigLabel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 81);
            panel1.TabIndex = 6;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(21, 16);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // bigLabel2
            // 
            bigLabel2.AutoSize = true;
            bigLabel2.BackColor = Color.Transparent;
            bigLabel2.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            bigLabel2.ForeColor = Color.White;
            bigLabel2.Location = new Point(77, 14);
            bigLabel2.Name = "bigLabel2";
            bigLabel2.Size = new Size(231, 46);
            bigLabel2.TabIndex = 1;
            bigLabel2.Text = "DASHBOARD";
            // 
            // mUBindingSource
            // 
            mUBindingSource.DataSource = typeof(MU);
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, apelidoDataGridViewTextBoxColumn, Corrente, Tensao, valorCurtoDataGridViewTextBoxColumn, contadorPacotesEnviadosDataGridViewTextBoxColumn, descricaoDataGridViewTextBoxColumn, Estado, socketConexaoUDPDataGridViewTextBoxColumn, ipConexaoEnvioUDPDataGridViewTextBoxColumn });
            dataGridView1.DataSource = mUBindingSource;
            dataGridView1.Location = new Point(105, 125);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(869, 397);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // mUBindingSource1
            // 
            mUBindingSource1.DataSource = typeof(MU);
            // 
            // button1
            // 
            button1.Location = new Point(453, 578);
            button1.Name = "button1";
            button1.Size = new Size(178, 37);
            button1.TabIndex = 10;
            button1.Text = "Executar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.HeaderText = "ID";
            iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            iDDataGridViewTextBoxColumn.Width = 35;
            // 
            // apelidoDataGridViewTextBoxColumn
            // 
            apelidoDataGridViewTextBoxColumn.DataPropertyName = "Apelido";
            apelidoDataGridViewTextBoxColumn.HeaderText = "Apelido";
            apelidoDataGridViewTextBoxColumn.MinimumWidth = 6;
            apelidoDataGridViewTextBoxColumn.Name = "apelidoDataGridViewTextBoxColumn";
            apelidoDataGridViewTextBoxColumn.Width = 125;
            // 
            // Corrente
            // 
            Corrente.DataPropertyName = "Corrente";
            Corrente.HeaderText = "Corrente (A)";
            Corrente.MinimumWidth = 6;
            Corrente.Name = "Corrente";
            Corrente.Width = 125;
            // 
            // Tensao
            // 
            Tensao.DataPropertyName = "Tensao";
            Tensao.HeaderText = "Tensão (V)";
            Tensao.MinimumWidth = 6;
            Tensao.Name = "Tensao";
            Tensao.Width = 125;
            // 
            // valorCurtoDataGridViewTextBoxColumn
            // 
            valorCurtoDataGridViewTextBoxColumn.DataPropertyName = "ValorCurto";
            valorCurtoDataGridViewTextBoxColumn.HeaderText = "ValorCurto (A)";
            valorCurtoDataGridViewTextBoxColumn.MinimumWidth = 6;
            valorCurtoDataGridViewTextBoxColumn.Name = "valorCurtoDataGridViewTextBoxColumn";
            valorCurtoDataGridViewTextBoxColumn.Width = 125;
            // 
            // contadorPacotesEnviadosDataGridViewTextBoxColumn
            // 
            contadorPacotesEnviadosDataGridViewTextBoxColumn.DataPropertyName = "ContadorPacotesEnviados";
            contadorPacotesEnviadosDataGridViewTextBoxColumn.HeaderText = "Nº Pacotes Enviados";
            contadorPacotesEnviadosDataGridViewTextBoxColumn.MinimumWidth = 6;
            contadorPacotesEnviadosDataGridViewTextBoxColumn.Name = "contadorPacotesEnviadosDataGridViewTextBoxColumn";
            contadorPacotesEnviadosDataGridViewTextBoxColumn.Width = 157;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            descricaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            descricaoDataGridViewTextBoxColumn.Width = 125;
            // 
            // Estado
            // 
            Estado.DataPropertyName = "Estado";
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            // 
            // socketConexaoUDPDataGridViewTextBoxColumn
            // 
            socketConexaoUDPDataGridViewTextBoxColumn.DataPropertyName = "SocketConexaoUDP";
            socketConexaoUDPDataGridViewTextBoxColumn.HeaderText = "SocketConexaoUDP";
            socketConexaoUDPDataGridViewTextBoxColumn.MinimumWidth = 6;
            socketConexaoUDPDataGridViewTextBoxColumn.Name = "socketConexaoUDPDataGridViewTextBoxColumn";
            socketConexaoUDPDataGridViewTextBoxColumn.Width = 200;
            // 
            // ipConexaoEnvioUDPDataGridViewTextBoxColumn
            // 
            ipConexaoEnvioUDPDataGridViewTextBoxColumn.DataPropertyName = "IpConexaoEnvioUDP";
            ipConexaoEnvioUDPDataGridViewTextBoxColumn.HeaderText = "IpConexaoEnvioUDP";
            ipConexaoEnvioUDPDataGridViewTextBoxColumn.MinimumWidth = 6;
            ipConexaoEnvioUDPDataGridViewTextBoxColumn.Name = "ipConexaoEnvioUDPDataGridViewTextBoxColumn";
            ipConexaoEnvioUDPDataGridViewTextBoxColumn.Width = 200;
            // 
            // FormDashboard
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1200, 655);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDashboard";
            Text = "FormDashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)mUBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)mUBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox3;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private BindingSource mUBindingSource;
        private DataGridView dataGridView1;
        private BindingSource mUBindingSource1;
        private Button button1;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apelidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Corrente;
        private DataGridViewTextBoxColumn Tensao;
        private DataGridViewTextBoxColumn valorCurtoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contadorPacotesEnviadosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn socketConexaoUDPDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ipConexaoEnvioUDPDataGridViewTextBoxColumn;
    }
}