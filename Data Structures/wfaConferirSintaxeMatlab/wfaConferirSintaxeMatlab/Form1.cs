using caPilhaDinamica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaConferirSintaxeMatlab
{
    public partial class ConfereMatLab : Form
    {
        public ConfereMatLab()
        {
            InitializeComponent();
            labelResposta.Visible = false;
        }

        private void textBoxExpressao_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonVerificar_Click(object sender, EventArgs e)
        {
            ExpressaoMat expressao = new ExpressaoMat();
            labelResposta.Text = "";
            string s = textBoxExpressao.Text;
            for (int i  = 0; i<textBoxExpressao.Text.Length; i++) 
            {
                expressao.push(s[i]);
            }


            if (expressao.verficaExpressao() == false)
            {
                labelResposta.Text = "Expressão Inválida!";
            }
            else
            {
                labelResposta.Text = "Expressão Válida!";
            }
            labelResposta.Visible = true;
            
        }
    }

}
