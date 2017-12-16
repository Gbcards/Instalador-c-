namespace Instalador
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelFinalizar = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.cbIniciarApp = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.cbCrearAccesoDirecto = new System.Windows.Forms.CheckBox();
            this.lbl_Instalando = new System.Windows.Forms.Label();
            this.panelProgressBar = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.metroProgressBar2 = new MetroFramework.Controls.MetroProgressBar();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.lblexpandido = new System.Windows.Forms.Label();
            this.panel_Cancel_Install = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel_Install = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtRutaInstalar = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            this.panelFinalizar.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelProgressBar.SuspendLayout();
            this.panel_Cancel_Install.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel_Install.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label1.Location = new System.Drawing.Point(435, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "x";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label2.Location = new System.Drawing.Point(411, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "_";
            this.label2.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.panelFinalizar);
            this.panel1.Controls.Add(this.lbl_Instalando);
            this.panel1.Controls.Add(this.panelProgressBar);
            this.panel1.Controls.Add(this.lblexpandido);
            this.panel1.Controls.Add(this.panel_Cancel_Install);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.panel_Install);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 526);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // panelFinalizar
            // 
            this.panelFinalizar.Controls.Add(this.label22);
            this.panelFinalizar.Controls.Add(this.label21);
            this.panelFinalizar.Controls.Add(this.panel5);
            this.panelFinalizar.Controls.Add(this.panel4);
            this.panelFinalizar.Location = new System.Drawing.Point(10, 192);
            this.panelFinalizar.Name = "panelFinalizar";
            this.panelFinalizar.Size = new System.Drawing.Size(443, 300);
            this.panelFinalizar.TabIndex = 23;
            this.panelFinalizar.Visible = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.label22.Location = new System.Drawing.Point(29, 64);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(269, 17);
            this.label22.TabIndex = 25;
            this.label22.Text = "Presione Finalizar para cerrar este asistente. ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(28, 14);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(175, 21);
            this.label21.TabIndex = 24;
            this.label21.Text = "Instalación Completada.";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label20);
            this.panel5.Controls.Add(this.cbIniciarApp);
            this.panel5.Location = new System.Drawing.Point(32, 113);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(146, 27);
            this.panel5.TabIndex = 21;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label20.Location = new System.Drawing.Point(25, 6);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(101, 15);
            this.label20.TabIndex = 17;
            this.label20.Text = "Iniciar Aplicación ";
            // 
            // cbIniciarApp
            // 
            this.cbIniciarApp.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbIniciarApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.cbIniciarApp.Checked = true;
            this.cbIniciarApp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIniciarApp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(70)))));
            this.cbIniciarApp.FlatAppearance.BorderSize = 2;
            this.cbIniciarApp.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(251)))));
            this.cbIniciarApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbIniciarApp.Location = new System.Drawing.Point(5, 5);
            this.cbIniciarApp.Name = "cbIniciarApp";
            this.cbIniciarApp.Size = new System.Drawing.Size(15, 15);
            this.cbIniciarApp.TabIndex = 19;
            this.cbIniciarApp.Text = " ";
            this.cbIniciarApp.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label19);
            this.panel4.Controls.Add(this.cbCrearAccesoDirecto);
            this.panel4.Location = new System.Drawing.Point(32, 154);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(146, 27);
            this.panel4.TabIndex = 20;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label19.Location = new System.Drawing.Point(25, 6);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(117, 15);
            this.label19.TabIndex = 17;
            this.label19.Text = "Crear Acceso Directo";
            // 
            // cbCrearAccesoDirecto
            // 
            this.cbCrearAccesoDirecto.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbCrearAccesoDirecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.cbCrearAccesoDirecto.Checked = true;
            this.cbCrearAccesoDirecto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCrearAccesoDirecto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(70)))));
            this.cbCrearAccesoDirecto.FlatAppearance.BorderSize = 2;
            this.cbCrearAccesoDirecto.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(251)))));
            this.cbCrearAccesoDirecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCrearAccesoDirecto.Location = new System.Drawing.Point(5, 5);
            this.cbCrearAccesoDirecto.Name = "cbCrearAccesoDirecto";
            this.cbCrearAccesoDirecto.Size = new System.Drawing.Size(15, 15);
            this.cbCrearAccesoDirecto.TabIndex = 19;
            this.cbCrearAccesoDirecto.Text = " ";
            this.cbCrearAccesoDirecto.UseVisualStyleBackColor = false;
            // 
            // lbl_Instalando
            // 
            this.lbl_Instalando.AutoSize = true;
            this.lbl_Instalando.Location = new System.Drawing.Point(365, 80);
            this.lbl_Instalando.Name = "lbl_Instalando";
            this.lbl_Instalando.Size = new System.Drawing.Size(13, 13);
            this.lbl_Instalando.TabIndex = 22;
            this.lbl_Instalando.Text = "0";
            this.lbl_Instalando.Visible = false;
            // 
            // panelProgressBar
            // 
            this.panelProgressBar.Controls.Add(this.label18);
            this.panelProgressBar.Controls.Add(this.label17);
            this.panelProgressBar.Controls.Add(this.label16);
            this.panelProgressBar.Controls.Add(this.label15);
            this.panelProgressBar.Controls.Add(this.label14);
            this.panelProgressBar.Controls.Add(this.label13);
            this.panelProgressBar.Controls.Add(this.label12);
            this.panelProgressBar.Controls.Add(this.label11);
            this.panelProgressBar.Controls.Add(this.label10);
            this.panelProgressBar.Controls.Add(this.metroProgressBar2);
            this.panelProgressBar.Controls.Add(this.metroProgressBar1);
            this.panelProgressBar.Location = new System.Drawing.Point(10, 193);
            this.panelProgressBar.Name = "panelProgressBar";
            this.panelProgressBar.Size = new System.Drawing.Size(436, 311);
            this.panelProgressBar.TabIndex = 21;
            this.panelProgressBar.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.label18.Location = new System.Drawing.Point(381, 218);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 15);
            this.label18.TabIndex = 31;
            this.label18.Text = "%";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.label17.Location = new System.Drawing.Point(358, 218);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 15);
            this.label17.TabIndex = 30;
            this.label17.Text = "100";
            this.label17.TextChanged += new System.EventHandler(this.label17_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.label16.Location = new System.Drawing.Point(29, 218);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(113, 15);
            this.label16.TabIndex = 29;
            this.label16.Text = "Total de Instalación ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.label15.Location = new System.Drawing.Point(29, 33);
            this.label15.MaximumSize = new System.Drawing.Size(371, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(371, 15);
            this.label15.TabIndex = 28;
            this.label15.Text = "G:\\Instalador\\Instalador\\Instalador\\bin\\Debug\\dll\\kappa\\Nueva carp";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.label14.Location = new System.Drawing.Point(29, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(114, 15);
            this.label14.TabIndex = 27;
            this.label14.Text = "MetroFramework.dll";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.label13.Location = new System.Drawing.Point(371, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(12, 15);
            this.label13.TabIndex = 26;
            this.label13.Text = "/";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.label12.Location = new System.Drawing.Point(380, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 15);
            this.label12.TabIndex = 25;
            this.label12.Text = "20";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.label11.Location = new System.Drawing.Point(355, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 15);
            this.label11.TabIndex = 24;
            this.label11.Text = "20";
            this.label11.TextChanged += new System.EventHandler(this.label11_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.label10.Location = new System.Drawing.Point(29, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "Copiados 0.00Mb de 000.00Mb ";
            // 
            // metroProgressBar2
            // 
            this.metroProgressBar2.Location = new System.Drawing.Point(32, 95);
            this.metroProgressBar2.Name = "metroProgressBar2";
            this.metroProgressBar2.Size = new System.Drawing.Size(367, 23);
            this.metroProgressBar2.TabIndex = 1;
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(32, 186);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(369, 23);
            this.metroProgressBar1.TabIndex = 0;
            // 
            // lblexpandido
            // 
            this.lblexpandido.AutoSize = true;
            this.lblexpandido.Location = new System.Drawing.Point(328, 80);
            this.lblexpandido.Name = "lblexpandido";
            this.lblexpandido.Size = new System.Drawing.Size(13, 13);
            this.lblexpandido.TabIndex = 20;
            this.lblexpandido.Text = "0";
            this.lblexpandido.Visible = false;
            // 
            // panel_Cancel_Install
            // 
            this.panel_Cancel_Install.Controls.Add(this.label9);
            this.panel_Cancel_Install.Location = new System.Drawing.Point(1, 285);
            this.panel_Cancel_Install.Name = "panel_Cancel_Install";
            this.panel_Cancel_Install.Size = new System.Drawing.Size(452, 100);
            this.panel_Cancel_Install.TabIndex = 0;
            this.panel_Cancel_Install.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(60, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(325, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "¿Está seguro que desea cancelar la instalación?";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.UseCompatibleTextRendering = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.label5.Location = new System.Drawing.Point(38, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "con Gbcards";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(34, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Instalador en c#";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(68, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 54);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gbcards";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(21, 29);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // panel_Install
            // 
            this.panel_Install.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel_Install.Controls.Add(this.panel2);
            this.panel_Install.Controls.Add(this.label8);
            this.panel_Install.Controls.Add(this.label6);
            this.panel_Install.Controls.Add(this.button1);
            this.panel_Install.Controls.Add(this.txtRutaInstalar);
            this.panel_Install.Location = new System.Drawing.Point(11, 194);
            this.panel_Install.Name = "panel_Install";
            this.panel_Install.Size = new System.Drawing.Size(436, 311);
            this.panel_Install.TabIndex = 19;
            this.panel_Install.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Install_MouseDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.checkBox2);
            this.panel2.Location = new System.Drawing.Point(28, 267);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 27);
            this.panel2.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label7.Location = new System.Drawing.Point(25, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(263, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Acepto los términos y condiciones de la licencia.";
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.checkBox2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(70)))));
            this.checkBox2.FlatAppearance.BorderSize = 2;
            this.checkBox2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(251)))));
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Location = new System.Drawing.Point(5, 5);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 15);
            this.checkBox2.TabIndex = 19;
            this.checkBox2.Text = " ";
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.label8.Location = new System.Drawing.Point(29, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Este sistema fue diseñado para...";
            this.label8.UseCompatibleTextRendering = true;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            this.label8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label8_MouseDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.label6.Location = new System.Drawing.Point(26, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(277, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "El programa de instalación requiere de 200Mb para:";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(106)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(390, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtRutaInstalar
            // 
            this.txtRutaInstalar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.txtRutaInstalar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRutaInstalar.Enabled = false;
            this.txtRutaInstalar.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRutaInstalar.ForeColor = System.Drawing.Color.White;
            this.txtRutaInstalar.Location = new System.Drawing.Point(29, 36);
            this.txtRutaInstalar.Name = "txtRutaInstalar";
            this.txtRutaInstalar.Size = new System.Drawing.Size(338, 23);
            this.txtRutaInstalar.TabIndex = 11;
            this.txtRutaInstalar.Text = "C:\\Archivos de Programa (x86)";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(1, 530);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(458, 101);
            this.panel3.TabIndex = 19;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(106)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(290, 58);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Sí";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(106)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(362, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Siguiente";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(460, 528);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelFinalizar.ResumeLayout(false);
            this.panelFinalizar.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelProgressBar.ResumeLayout(false);
            this.panelProgressBar.PerformLayout();
            this.panel_Cancel_Install.ResumeLayout(false);
            this.panel_Cancel_Install.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel_Install.ResumeLayout(false);
            this.panel_Install.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtRutaInstalar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel_Install;
        private System.Windows.Forms.Panel panel_Cancel_Install;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblexpandido;
        private System.Windows.Forms.Panel panelProgressBar;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private System.Windows.Forms.Label lbl_Instalando;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox cbCrearAccesoDirecto;
        private System.Windows.Forms.Panel panelFinalizar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox cbIniciarApp;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
    }
}