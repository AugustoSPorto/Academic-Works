namespace wfaTrocaPecas
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
            this.textBoxPOrig = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPNova = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonAdd = new System.Windows.Forms.RadioButton();
            this.radioButtonPop = new System.Windows.Forms.RadioButton();
            this.radioButtonTroca = new System.Windows.Forms.RadioButton();
            this.buttonExec = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPeca = new System.Windows.Forms.TextBox();
            this.textBoxRes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxPOrig
            // 
            this.textBoxPOrig.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxPOrig.Location = new System.Drawing.Point(585, 313);
            this.textBoxPOrig.Name = "textBoxPOrig";
            this.textBoxPOrig.Size = new System.Drawing.Size(519, 34);
            this.textBoxPOrig.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(282, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome da peça original:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(294, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome da nova peça:";
            // 
            // textBoxPNova
            // 
            this.textBoxPNova.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxPNova.Location = new System.Drawing.Point(585, 402);
            this.textBoxPNova.Name = "textBoxPNova";
            this.textBoxPNova.Size = new System.Drawing.Size(519, 34);
            this.textBoxPNova.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.Location = new System.Drawing.Point(293, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ações:";
            // 
            // radioButtonAdd
            // 
            this.radioButtonAdd.AutoSize = true;
            this.radioButtonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.radioButtonAdd.Location = new System.Drawing.Point(299, 192);
            this.radioButtonAdd.Name = "radioButtonAdd";
            this.radioButtonAdd.Size = new System.Drawing.Size(196, 33);
            this.radioButtonAdd.TabIndex = 6;
            this.radioButtonAdd.TabStop = true;
            this.radioButtonAdd.Text = "Adicionar Peça";
            this.radioButtonAdd.UseVisualStyleBackColor = true;
            this.radioButtonAdd.CheckedChanged += new System.EventHandler(this.radioButtonAdd_CheckedChanged);
            // 
            // radioButtonPop
            // 
            this.radioButtonPop.AutoSize = true;
            this.radioButtonPop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.radioButtonPop.Location = new System.Drawing.Point(743, 192);
            this.radioButtonPop.Name = "radioButtonPop";
            this.radioButtonPop.Size = new System.Drawing.Size(167, 33);
            this.radioButtonPop.TabIndex = 7;
            this.radioButtonPop.TabStop = true;
            this.radioButtonPop.Text = "Retirar Peça";
            this.radioButtonPop.UseVisualStyleBackColor = true;
            this.radioButtonPop.CheckedChanged += new System.EventHandler(this.radioButtonPop_CheckedChanged);
            // 
            // radioButtonTroca
            // 
            this.radioButtonTroca.AutoSize = true;
            this.radioButtonTroca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.radioButtonTroca.Location = new System.Drawing.Point(1142, 192);
            this.radioButtonTroca.Name = "radioButtonTroca";
            this.radioButtonTroca.Size = new System.Drawing.Size(178, 33);
            this.radioButtonTroca.TabIndex = 8;
            this.radioButtonTroca.TabStop = true;
            this.radioButtonTroca.Text = "Trocar Peças";
            this.radioButtonTroca.UseVisualStyleBackColor = true;
            this.radioButtonTroca.CheckedChanged += new System.EventHandler(this.radioButtonTroca_CheckedChanged);
            // 
            // buttonExec
            // 
            this.buttonExec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonExec.Location = new System.Drawing.Point(1261, 342);
            this.buttonExec.Name = "buttonExec";
            this.buttonExec.Size = new System.Drawing.Size(282, 58);
            this.buttonExec.TabIndex = 9;
            this.buttonExec.Text = "EXECUTAR";
            this.buttonExec.UseVisualStyleBackColor = true;
            this.buttonExec.Click += new System.EventHandler(this.buttonExec_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(318, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nome da peça:";
            // 
            // textBoxPeca
            // 
            this.textBoxPeca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxPeca.Location = new System.Drawing.Point(585, 357);
            this.textBoxPeca.Name = "textBoxPeca";
            this.textBoxPeca.Size = new System.Drawing.Size(519, 34);
            this.textBoxPeca.TabIndex = 10;
            // 
            // textBoxRes
            // 
            this.textBoxRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxRes.Location = new System.Drawing.Point(287, 571);
            this.textBoxRes.Multiline = true;
            this.textBoxRes.Name = "textBoxRes";
            this.textBoxRes.Size = new System.Drawing.Size(1256, 249);
            this.textBoxRes.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.textBoxRes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPeca);
            this.Controls.Add(this.buttonExec);
            this.Controls.Add(this.radioButtonTroca);
            this.Controls.Add(this.radioButtonPop);
            this.Controls.Add(this.radioButtonAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPNova);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPOrig);
            this.Name = "Form1";
            this.Text = "Troca de Peças";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPOrig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPNova;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonAdd;
        private System.Windows.Forms.RadioButton radioButtonPop;
        private System.Windows.Forms.RadioButton radioButtonTroca;
        private System.Windows.Forms.Button buttonExec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPeca;
        private System.Windows.Forms.TextBox textBoxRes;
    }
}

