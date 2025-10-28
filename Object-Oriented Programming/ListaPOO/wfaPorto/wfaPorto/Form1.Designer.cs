namespace wfaPorto
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.buttonAdic = new System.Windows.Forms.Button();
            this.buttonReti = new System.Windows.Forms.Button();
            this.textBoxLoc1 = new System.Windows.Forms.TextBox();
            this.textBoxLoc2 = new System.Windows.Forms.TextBox();
            this.textBoxLoc3 = new System.Windows.Forms.TextBox();
            this.textBoxLoc4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(240, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Contêiner:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxNome.Location = new System.Drawing.Point(527, 109);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(1073, 34);
            this.textBoxNome.TabIndex = 1;
            // 
            // buttonAdic
            // 
            this.buttonAdic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonAdic.Location = new System.Drawing.Point(126, 223);
            this.buttonAdic.Name = "buttonAdic";
            this.buttonAdic.Size = new System.Drawing.Size(228, 47);
            this.buttonAdic.TabIndex = 2;
            this.buttonAdic.Text = "ADICIONAR";
            this.buttonAdic.UseVisualStyleBackColor = true;
            this.buttonAdic.Click += new System.EventHandler(this.buttonAdic_Click);
            // 
            // buttonReti
            // 
            this.buttonReti.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonReti.Location = new System.Drawing.Point(583, 223);
            this.buttonReti.Name = "buttonReti";
            this.buttonReti.Size = new System.Drawing.Size(257, 47);
            this.buttonReti.TabIndex = 3;
            this.buttonReti.Text = "RETIRAR";
            this.buttonReti.UseVisualStyleBackColor = true;
            this.buttonReti.Click += new System.EventHandler(this.buttonReti_Click);
            // 
            // textBoxLoc1
            // 
            this.textBoxLoc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBoxLoc1.Location = new System.Drawing.Point(85, 433);
            this.textBoxLoc1.Multiline = true;
            this.textBoxLoc1.Name = "textBoxLoc1";
            this.textBoxLoc1.Size = new System.Drawing.Size(385, 496);
            this.textBoxLoc1.TabIndex = 4;
            // 
            // textBoxLoc2
            // 
            this.textBoxLoc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBoxLoc2.Location = new System.Drawing.Point(527, 433);
            this.textBoxLoc2.Multiline = true;
            this.textBoxLoc2.Name = "textBoxLoc2";
            this.textBoxLoc2.Size = new System.Drawing.Size(385, 496);
            this.textBoxLoc2.TabIndex = 7;
            // 
            // textBoxLoc3
            // 
            this.textBoxLoc3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBoxLoc3.Location = new System.Drawing.Point(980, 433);
            this.textBoxLoc3.Multiline = true;
            this.textBoxLoc3.Name = "textBoxLoc3";
            this.textBoxLoc3.Size = new System.Drawing.Size(385, 496);
            this.textBoxLoc3.TabIndex = 8;
            // 
            // textBoxLoc4
            // 
            this.textBoxLoc4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBoxLoc4.Location = new System.Drawing.Point(1446, 433);
            this.textBoxLoc4.Multiline = true;
            this.textBoxLoc4.Name = "textBoxLoc4";
            this.textBoxLoc4.Size = new System.Drawing.Size(385, 496);
            this.textBoxLoc4.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(52, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Local 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(522, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Local 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(975, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Local 3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(1441, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "Local 4:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxLoc4);
            this.Controls.Add(this.textBoxLoc3);
            this.Controls.Add(this.textBoxLoc2);
            this.Controls.Add(this.textBoxLoc1);
            this.Controls.Add(this.buttonReti);
            this.Controls.Add(this.buttonAdic);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Logística do Porto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Button buttonAdic;
        private System.Windows.Forms.Button buttonReti;
        private System.Windows.Forms.TextBox textBoxLoc1;
        private System.Windows.Forms.TextBox textBoxLoc2;
        private System.Windows.Forms.TextBox textBoxLoc3;
        private System.Windows.Forms.TextBox textBoxLoc4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

