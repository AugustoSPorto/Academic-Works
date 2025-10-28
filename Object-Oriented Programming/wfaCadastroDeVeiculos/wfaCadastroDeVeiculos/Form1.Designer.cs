namespace wfaCadastroDeVeiculos
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
            this.radioButtonOni = new System.Windows.Forms.RadioButton();
            this.radioButtonCam = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelQtd = new System.Windows.Forms.Label();
            this.buttonCadast = new System.Windows.Forms.Button();
            this.buttonLimp = new System.Windows.Forms.Button();
            this.textBoxPlaca = new System.Windows.Forms.TextBox();
            this.textBoxAno = new System.Windows.Forms.TextBox();
            this.textBoxQtd = new System.Windows.Forms.TextBox();
            this.pictureBoxOnibus = new System.Windows.Forms.PictureBox();
            this.pictureBoxCam = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOnibus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCam)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonOni
            // 
            this.radioButtonOni.AutoSize = true;
            this.radioButtonOni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonOni.Location = new System.Drawing.Point(115, 70);
            this.radioButtonOni.Name = "radioButtonOni";
            this.radioButtonOni.Size = new System.Drawing.Size(76, 22);
            this.radioButtonOni.TabIndex = 0;
            this.radioButtonOni.TabStop = true;
            this.radioButtonOni.Text = "Ônibus";
            this.radioButtonOni.UseVisualStyleBackColor = true;
            this.radioButtonOni.CheckedChanged += new System.EventHandler(this.radioButtonOni_CheckedChanged);
            // 
            // radioButtonCam
            // 
            this.radioButtonCam.AutoSize = true;
            this.radioButtonCam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCam.Location = new System.Drawing.Point(337, 70);
            this.radioButtonCam.Name = "radioButtonCam";
            this.radioButtonCam.Size = new System.Drawing.Size(97, 22);
            this.radioButtonCam.TabIndex = 1;
            this.radioButtonCam.TabStop = true;
            this.radioButtonCam.Text = "Caminhão";
            this.radioButtonCam.UseVisualStyleBackColor = true;
            this.radioButtonCam.CheckedChanged += new System.EventHandler(this.radioButtonCam_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Placa: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ano: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelQtd
            // 
            this.labelQtd.AutoSize = true;
            this.labelQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQtd.Location = new System.Drawing.Point(81, 209);
            this.labelQtd.Name = "labelQtd";
            this.labelQtd.Size = new System.Drawing.Size(110, 18);
            this.labelQtd.TabIndex = 4;
            this.labelQtd.Text = "Qtd. Assentos: ";
            // 
            // buttonCadast
            // 
            this.buttonCadast.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonCadast.Location = new System.Drawing.Point(197, 269);
            this.buttonCadast.Name = "buttonCadast";
            this.buttonCadast.Size = new System.Drawing.Size(117, 23);
            this.buttonCadast.TabIndex = 7;
            this.buttonCadast.Text = "CADASTRAR";
            this.buttonCadast.UseVisualStyleBackColor = false;
            this.buttonCadast.Click += new System.EventHandler(this.buttonCadast_Click);
            // 
            // buttonLimp
            // 
            this.buttonLimp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonLimp.Location = new System.Drawing.Point(385, 269);
            this.buttonLimp.Name = "buttonLimp";
            this.buttonLimp.Size = new System.Drawing.Size(89, 23);
            this.buttonLimp.TabIndex = 8;
            this.buttonLimp.Text = "LIMPAR";
            this.buttonLimp.UseVisualStyleBackColor = false;
            this.buttonLimp.Click += new System.EventHandler(this.buttonLimp_Click);
            // 
            // textBoxPlaca
            // 
            this.textBoxPlaca.Location = new System.Drawing.Point(197, 135);
            this.textBoxPlaca.Name = "textBoxPlaca";
            this.textBoxPlaca.Size = new System.Drawing.Size(277, 22);
            this.textBoxPlaca.TabIndex = 9;
            // 
            // textBoxAno
            // 
            this.textBoxAno.Location = new System.Drawing.Point(197, 171);
            this.textBoxAno.Name = "textBoxAno";
            this.textBoxAno.Size = new System.Drawing.Size(277, 22);
            this.textBoxAno.TabIndex = 10;
            // 
            // textBoxQtd
            // 
            this.textBoxQtd.Location = new System.Drawing.Point(197, 205);
            this.textBoxQtd.Name = "textBoxQtd";
            this.textBoxQtd.Size = new System.Drawing.Size(277, 22);
            this.textBoxQtd.TabIndex = 11;
            // 
            // pictureBoxOnibus
            // 
            this.pictureBoxOnibus.Image = global::wfaCadastroDeVeiculos.Properties.Resources.onibus;
            this.pictureBoxOnibus.Location = new System.Drawing.Point(550, 70);
            this.pictureBoxOnibus.Name = "pictureBoxOnibus";
            this.pictureBoxOnibus.Size = new System.Drawing.Size(204, 157);
            this.pictureBoxOnibus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOnibus.TabIndex = 12;
            this.pictureBoxOnibus.TabStop = false;
            // 
            // pictureBoxCam
            // 
            this.pictureBoxCam.Image = global::wfaCadastroDeVeiculos.Properties.Resources.caminhao;
            this.pictureBoxCam.Location = new System.Drawing.Point(550, 70);
            this.pictureBoxCam.Name = "pictureBoxCam";
            this.pictureBoxCam.Size = new System.Drawing.Size(204, 157);
            this.pictureBoxCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCam.TabIndex = 13;
            this.pictureBoxCam.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(98, 329);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(614, 97);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBoxCam);
            this.Controls.Add(this.pictureBoxOnibus);
            this.Controls.Add(this.textBoxQtd);
            this.Controls.Add(this.textBoxAno);
            this.Controls.Add(this.textBoxPlaca);
            this.Controls.Add(this.buttonLimp);
            this.Controls.Add(this.buttonCadast);
            this.Controls.Add(this.labelQtd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonCam);
            this.Controls.Add(this.radioButtonOni);
            this.Name = "Form1";
            this.Text = "Cadastro de Veiculos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOnibus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonOni;
        private System.Windows.Forms.RadioButton radioButtonCam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelQtd;
        private System.Windows.Forms.Button buttonCadast;
        private System.Windows.Forms.Button buttonLimp;
        private System.Windows.Forms.TextBox textBoxPlaca;
        private System.Windows.Forms.TextBox textBoxAno;
        private System.Windows.Forms.TextBox textBoxQtd;
        private System.Windows.Forms.PictureBox pictureBoxOnibus;
        private System.Windows.Forms.PictureBox pictureBoxCam;
        private System.Windows.Forms.ListView listView1;
    }
}

