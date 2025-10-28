using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Mod1b_SWmockup
{
    public partial class Form1 : Form
    {
        private FormCadastro formCadastroInstance;
        private FormDashboard formDashboardInstance;

        public Form1()
        {   
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            var receptor = new ReceptorBroadcast();
            receptor.Iniciar();
            OpenFormInPanel(new FormSobre());

        }


        // Código para permitir mover a janela///////////////////////////////////////////////
        private const int HTLEFT = 10;
        private const int HTRIGHT = 11;
        private const int HTTOP = 12;
        private const int HTTOPLEFT = 13;
        private const int HTTOPRIGHT = 14;
        private const int HTBOTTOM = 15;
        private const int HTBOTTOMLEFT = 16;
        private const int HTBOTTOMRIGHT = 17;
        private const int WM_NCHITTEST = 0x84;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST)
            {
                Point cursor = PointToClient(Cursor.Position);

                int gripSize = 10; // Tamanho da "borda" para resize (ajuste se quiser)

                if (cursor.X >= Width - gripSize && cursor.Y >= Height - gripSize)
                    m.Result = (IntPtr)HTBOTTOMRIGHT;
                else if (cursor.X <= gripSize && cursor.Y >= Height - gripSize)
                    m.Result = (IntPtr)HTBOTTOMLEFT;
                else if (cursor.X <= gripSize && cursor.Y <= gripSize)
                    m.Result = (IntPtr)HTTOPLEFT;
                else if (cursor.X >= Width - gripSize && cursor.Y <= gripSize)
                    m.Result = (IntPtr)HTTOPRIGHT;
                else if (cursor.X <= gripSize)
                    m.Result = (IntPtr)HTLEFT;
                else if (cursor.X >= Width - gripSize)
                    m.Result = (IntPtr)HTRIGHT;
                else if (cursor.Y <= gripSize)
                    m.Result = (IntPtr)HTTOP;
                else if (cursor.Y >= Height - gripSize)
                    m.Result = (IntPtr)HTBOTTOM;
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////


        // Animação Slidebar Menu ////////////////////////////////////////////////////////////
        bool timerSidebarExpand = true;
        private void timerSidebarTransition_Tick(object sender, EventArgs e)
        {
            if (timerSidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 65)
                {
                    timerSidebarExpand = false;
                    timerSidebarTransition.Stop();
                }
                panelCadastro.Width = sidebar.Width;
                panelDashboard.Width = sidebar.Width;
                panelSobre.Width = sidebar.Width;
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 230)
                {
                    timerSidebarExpand = true;
                    timerSidebarTransition.Stop();

                    panelCadastro.Width = sidebar.Width;
                    panelDashboard.Width = sidebar.Width;
                    panelSobre.Width = sidebar.Width;
                }
            }
        }
        // Método para abrir um form qnd clica no botãozin da esquerda ////////////////////
        private void OpenFormInPanel(Form formToOpen)
        {
            // Limpa o painel antes de adicionar o novo form
            panelContent.Controls.Clear();

            formToOpen.TopLevel = false;
            formToOpen.FormBorderStyle = FormBorderStyle.None;
            formToOpen.Dock = DockStyle.Fill;

            panelContent.Controls.Add(formToOpen);
            panelContent.Tag = formToOpen;
            formToOpen.Show();
        }
        private void btnHam_Click(object sender, EventArgs e)
        {
            timerSidebarTransition.Start();
        }

        // Comandos para abrir os forms qnd clica no slidebar ///////////////////////////
        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            if (formDashboardInstance == null || formDashboardInstance.IsDisposed)
            {
                if (formCadastroInstance == null)// faz não crashar qnd abre direto a aba de dashboard

                {
                    formCadastroInstance = new FormCadastro();
                }
                    formDashboardInstance = new FormDashboard(formCadastroInstance.GetMUs());
            }
            OpenFormInPanel(formDashboardInstance);
        }
  
        private void buttonCadastroMU_Click(object sender, EventArgs e)
        {
            if (formCadastroInstance == null || formCadastroInstance.IsDisposed)
            {
                formCadastroInstance = new FormCadastro();
            }
            OpenFormInPanel(formCadastroInstance);
        }
        private void buttonSobre_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new FormSobre());
        }
        //////////////////////////////////////////////////////////////////////////////////////
        ///
        private void FormDashboard_FormClosed(object? sender, FormClosedEventArgs e)
        {

        }
        
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        { }
        private void Form1_MouseDown_1(object sender, MouseEventArgs e)
        { }
        private void panelContent_MouseDown_1(object sender, MouseEventArgs e)
        { }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

        }

        
    }
}