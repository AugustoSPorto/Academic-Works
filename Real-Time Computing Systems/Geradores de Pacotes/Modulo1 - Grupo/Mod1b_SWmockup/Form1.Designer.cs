namespace Mod1b_SWmockup
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            foxLabel1 = new ReaLTaiizor.Controls.FoxLabel();
            btnHam = new PictureBox();
            sidebar = new FlowLayoutPanel();
            panelDashboard = new Panel();
            buttonDashboard = new Button();
            panelCadastro = new Panel();
            buttonCadastroMU = new Button();
            panelSobre = new Panel();
            buttonSobre = new Button();
            timerSidebarTransition = new System.Windows.Forms.Timer(components);
            panelContent = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHam).BeginInit();
            sidebar.SuspendLayout();
            panelDashboard.SuspendLayout();
            panelCadastro.SuspendLayout();
            panelSobre.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(nightControlBox1);
            panel1.Controls.Add(foxLabel1);
            panel1.Controls.Add(btnHam);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1300, 45);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(23, 24, 29);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(23, 24, 29);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(23, 24, 29);
            nightControlBox1.Location = new Point(1161, 0);
            nightControlBox1.MaximizeHoverColor = Color.Black;
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.Black;
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 2;
            // 
            // foxLabel1
            // 
            foxLabel1.BackColor = Color.Transparent;
            foxLabel1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            foxLabel1.ForeColor = Color.FromArgb(76, 88, 100);
            foxLabel1.Location = new Point(57, 12);
            foxLabel1.Name = "foxLabel1";
            foxLabel1.Size = new Size(470, 24);
            foxLabel1.TabIndex = 1;
            foxLabel1.Text = "Módulo 1b - Software Mockup para Measure Units (MUs)";
            // 
            // btnHam
            // 
            btnHam.Image = (Image)resources.GetObject("btnHam.Image");
            btnHam.Location = new Point(14, 5);
            btnHam.Name = "btnHam";
            btnHam.Size = new Size(35, 35);
            btnHam.SizeMode = PictureBoxSizeMode.Zoom;
            btnHam.TabIndex = 0;
            btnHam.TabStop = false;
            btnHam.Click += btnHam_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(220, 23, 24, 29);
            sidebar.Controls.Add(panelDashboard);
            sidebar.Controls.Add(panelCadastro);
            sidebar.Controls.Add(panelSobre);
            sidebar.Dock = DockStyle.Left;
            sidebar.FlowDirection = FlowDirection.TopDown;
            sidebar.ForeColor = SystemColors.ControlText;
            sidebar.Location = new Point(0, 45);
            sidebar.Name = "sidebar";
            sidebar.Padding = new Padding(0, 40, 0, 0);
            sidebar.Size = new Size(230, 655);
            sidebar.TabIndex = 1;
            sidebar.TabStop = true;
            // 
            // panelDashboard
            // 
            panelDashboard.Controls.Add(buttonDashboard);
            panelDashboard.Location = new Point(3, 43);
            panelDashboard.Name = "panelDashboard";
            panelDashboard.Size = new Size(227, 50);
            panelDashboard.TabIndex = 3;
            // 
            // buttonDashboard
            // 
            buttonDashboard.BackColor = Color.FromArgb(220, 23, 24, 29);
            buttonDashboard.ForeColor = Color.White;
            buttonDashboard.Image = (Image)resources.GetObject("buttonDashboard.Image");
            buttonDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDashboard.Location = new Point(-8, -14);
            buttonDashboard.Name = "buttonDashboard";
            buttonDashboard.Padding = new Padding(20, 0, 0, 0);
            buttonDashboard.Size = new Size(270, 74);
            buttonDashboard.TabIndex = 2;
            buttonDashboard.Text = "            Dashboard";
            buttonDashboard.TextAlign = ContentAlignment.MiddleLeft;
            buttonDashboard.UseVisualStyleBackColor = false;
            buttonDashboard.Click += buttonDashboard_Click;
            // 
            // panelCadastro
            // 
            panelCadastro.BackColor = Color.White;
            panelCadastro.Controls.Add(buttonCadastroMU);
            panelCadastro.Location = new Point(3, 99);
            panelCadastro.Name = "panelCadastro";
            panelCadastro.Size = new Size(227, 50);
            panelCadastro.TabIndex = 4;
            // 
            // buttonCadastroMU
            // 
            buttonCadastroMU.BackColor = Color.FromArgb(220, 23, 24, 29);
            buttonCadastroMU.ForeColor = Color.White;
            buttonCadastroMU.Image = (Image)resources.GetObject("buttonCadastroMU.Image");
            buttonCadastroMU.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCadastroMU.Location = new Point(-8, -14);
            buttonCadastroMU.Name = "buttonCadastroMU";
            buttonCadastroMU.Padding = new Padding(20, 0, 0, 0);
            buttonCadastroMU.Size = new Size(270, 74);
            buttonCadastroMU.TabIndex = 2;
            buttonCadastroMU.Text = "            Cadastro MU";
            buttonCadastroMU.TextAlign = ContentAlignment.MiddleLeft;
            buttonCadastroMU.UseVisualStyleBackColor = false;
            buttonCadastroMU.Click += buttonCadastroMU_Click;
            // 
            // panelSobre
            // 
            panelSobre.Controls.Add(buttonSobre);
            panelSobre.Location = new Point(3, 155);
            panelSobre.Name = "panelSobre";
            panelSobre.Size = new Size(227, 50);
            panelSobre.TabIndex = 4;
            // 
            // buttonSobre
            // 
            buttonSobre.BackColor = Color.FromArgb(220, 23, 24, 29);
            buttonSobre.ForeColor = Color.White;
            buttonSobre.Image = (Image)resources.GetObject("buttonSobre.Image");
            buttonSobre.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSobre.Location = new Point(-5, -13);
            buttonSobre.Name = "buttonSobre";
            buttonSobre.Padding = new Padding(20, 0, 0, 0);
            buttonSobre.Size = new Size(267, 74);
            buttonSobre.TabIndex = 2;
            buttonSobre.Text = "            Sobre";
            buttonSobre.TextAlign = ContentAlignment.MiddleLeft;
            buttonSobre.UseVisualStyleBackColor = false;
            buttonSobre.Click += buttonSobre_Click;
            // 
            // timerSidebarTransition
            // 
            timerSidebarTransition.Interval = 10;
            timerSidebarTransition.Tick += timerSidebarTransition_Tick;
            // 
            // panelContent
            // 
            panelContent.BackColor = SystemColors.ButtonFace;
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(230, 45);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1070, 655);
            panelContent.TabIndex = 3;
            panelContent.MouseDown += panelContent_MouseDown_1;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1300, 700);
            Controls.Add(panelContent);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            MouseDown += Form1_MouseDown_1;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnHam).EndInit();
            sidebar.ResumeLayout(false);
            panelDashboard.ResumeLayout(false);
            panelCadastro.ResumeLayout(false);
            panelSobre.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox btnHam;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private ReaLTaiizor.Controls.FoxLabel foxLabel1;
        private FlowLayoutPanel sidebar;
        private Panel panelDashboard;
        private Button buttonDashboard;
        private Panel panelSobre;
        private Button buttonSobre;
        private Panel panelCadastro;
        private Button buttonCadastroMU;
        private System.Windows.Forms.Timer timerSidebarTransition;
        private Panel panelContent;
    }
}
