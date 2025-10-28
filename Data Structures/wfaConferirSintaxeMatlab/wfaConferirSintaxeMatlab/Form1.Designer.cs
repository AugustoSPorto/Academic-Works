namespace wfaConferirSintaxeMatlab
{
    partial class ConfereMatLab
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
            this.textBoxExpressao = new System.Windows.Forms.TextBox();
            this.buttonVerificar = new System.Windows.Forms.Button();
            this.labelResposta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informar Expressão:";
            // 
            // textBoxExpressao
            // 
            this.textBoxExpressao.Location = new System.Drawing.Point(179, 89);
            this.textBoxExpressao.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxExpressao.Name = "textBoxExpressao";
            this.textBoxExpressao.Size = new System.Drawing.Size(219, 20);
            this.textBoxExpressao.TabIndex = 1;
            this.textBoxExpressao.TextChanged += new System.EventHandler(this.textBoxExpressao_TextChanged);
            // 
            // buttonVerificar
            // 
            this.buttonVerificar.Location = new System.Drawing.Point(429, 86);
            this.buttonVerificar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonVerificar.Name = "buttonVerificar";
            this.buttonVerificar.Size = new System.Drawing.Size(104, 23);
            this.buttonVerificar.TabIndex = 2;
            this.buttonVerificar.Text = "VERIFICAR";
            this.buttonVerificar.UseVisualStyleBackColor = true;
            this.buttonVerificar.Click += new System.EventHandler(this.buttonVerificar_Click);
            // 
            // labelResposta
            // 
            this.labelResposta.AutoSize = true;
            this.labelResposta.Location = new System.Drawing.Point(63, 224);
            this.labelResposta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResposta.Name = "labelResposta";
            this.labelResposta.Size = new System.Drawing.Size(65, 15);
            this.labelResposta.TabIndex = 3;
            this.labelResposta.Text = "Resposta: ";
            // 
            // ConfereMatLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.labelResposta);
            this.Controls.Add(this.buttonVerificar);
            this.Controls.Add(this.textBoxExpressao);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ConfereMatLab";
            this.Text = "Conferir Sintaxe de Expressões Matemáticas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxExpressao;
        private System.Windows.Forms.Button buttonVerificar;
        private System.Windows.Forms.Label labelResposta;
    }
}

