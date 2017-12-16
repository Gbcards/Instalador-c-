using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using MetroFramework;
using IWshRuntimeLibrary;
using System.IO;

namespace Instalador
{
    public partial class Form1 : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
       
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public Form1()
        {
            
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            button2.Text = "No";
            button3.Visible = true;
            panel_Install.Visible = false;
            panel_Cancel_Install.Visible = true;
            panelProgressBar.Visible = false;

            if (checkBox2.Checked == true)
            {
                lblexpandido.Text = "1";
            }
            if (checkBox2.Checked == false)
            {
               
                if (lblexpandido.Text == "0")
                {
                    timer1.Start();
                }
                lblexpandido.Text = "1";
            }
           
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.FromArgb(230,230,230);
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.FromArgb(230, 230, 230);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (movimiento==false)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtRutaInstalar.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(this.Location.X, this.Location.Y-30);

            txtRutaInstalar.Text = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            label8.Text =   "Este Instalador es un demo para la comunidad" + Environment.NewLine +
                            "Mostrando todas las funcionalidades" + Environment.NewLine + 
                            "y poder depurar errores de código."+Environment.NewLine+Environment.NewLine+
                            "Esta aplicación no es responsable de la perdida"+ Environment.NewLine+
                            "de información ya sea por robo(hacking) o eliminación"+Environment.NewLine+
                            "de la base de datos." + Environment.NewLine+Environment.NewLine+
                            "Debe de aceptar los términos de licencia para poder instalar el producto.";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        
        int num;
        bool movimiento = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lblexpandido.Text=="1")
            {
                checkBox2.Enabled = false;
                movimiento = true;
                panel1.Height += 4;
                    this.Height += 4;
                    num++;
                    if (num == 26)
                    {
                        num = 0;
                        checkBox2.Enabled = true;
                        movimiento = false;
                        timer1.Stop();
                    }
            }
            if (lblexpandido.Text=="0")
            {
                checkBox2.Enabled = false;
                movimiento = true;
                panel1.Height -= 4;
                    this.Height -= 4;

                    num++;
                    if (num == 26)
                    {
                        num = 0;
                        checkBox2.Enabled = true;
                        movimiento = false;
                        timer1.Stop();
                    }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                if (lblexpandido.Text == "0")
                {
                    timer1.Start();
                }
                lblexpandido.Text = "1";
            }
            else
            {
                if (lblexpandido.Text=="1")
                {
                    timer1.Start();
                }
                lblexpandido.Text = "0";
            }
        }

        private void panel_Install_MouseDown(object sender, MouseEventArgs e)
        {
            if (movimiento==false)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }

        private void label8_MouseDown(object sender, MouseEventArgs e)
        {
            if (movimiento==false)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "No")
            {
                lblexpandido.Text = "0";
                if (lbl_Instalando.Text == "0")
                {
                    if (panelProgressBar.Visible == true)
                    {
                        panelProgressBar.Visible = false;
                    }
                    timer1.Start();
                    checkBox2.Checked = false;
                    panel_Install.Visible = true;
                    panel_Cancel_Install.Visible = false;
                    button2.Text = "Siguiente";
                    button3.Visible = false;
                }
                else
                {
                    lblexpandido.Text = "1";
                    panelProgressBar.Visible = true;
                    panel_Cancel_Install.Visible = false;
                    button2.Text = "Cancelar";
                    button3.Visible = false;
                }
            }
            else if (button2.Text == "Siguiente")
            {
                lbl_Instalando.Text = "1";
                button2.Text = "Cancelar";
                panel_Install.Visible = false;
                if (panelProgressBar.Visible == false)
                {
                    panelProgressBar.Visible = true;
                    label12.Text = "" + ArchivosDirectorios.ObtenerNumerodeArchivos(Application.StartupPath + @"\app", true).ToString();
                    ArchivosDirectorios obj = new ArchivosDirectorios();
                    obj.DirectoryCopy(Application.StartupPath + @"\app", @txtRutaInstalar.Text + @"\Gbcards\Instalador", true, label11, metroProgressBar2, label10, label15, label14);
                } 
            }
            else if (button2.Text == "Cancelar")
            {
                button2.Text = "No";
                button3.Visible = true;
                panel_Install.Visible = false;
                panel_Cancel_Install.Visible = true;
                panelProgressBar.Visible = false;
                //panelProgressBar.Visible = false;
                if (lbl_Instalando.Text=="1")
                {
                    lblexpandido.Text = "1";
                }

                if (checkBox2.Checked == true)
                {
                    lblexpandido.Text = "1";
                }
                if (checkBox2.Checked == false)
                {
                    if (lblexpandido.Text == "0")
                    {
                        timer1.Start();
                    }
                    lblexpandido.Text = "1";
                }
            }
            else if (button2.Text == "Finalizar")
            {
                if (cbCrearAccesoDirecto.Checked == true)
                {
                    CreateShortcut(Application.StartupPath + @"\Instalador.exe", "Gbcards");
                }
                if (cbIniciarApp.Checked == true)
                {
                    
                }
                Application.Exit();
            }
        }

        void CreateShortcut(string linkPath, string filename)
        {
            var shell = new WshShell();
            IWshShortcut link = (IWshShortcut)shell.CreateShortcut((Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), filename + ".lnk")));
            link.Description = "Instalador";
            link.TargetPath = linkPath;
            link.Save();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void label11_TextChanged(object sender, EventArgs e)
        {
            metroProgressBar1.Maximum = int.Parse(label12.Text);
            metroProgressBar1.Value = int.Parse(label11.Text);

            double porcentaje = (double.Parse(label11.Text) * 100) / double.Parse(label12.Text);

            label17.Text = porcentaje.ToString();
        }

        private void label17_TextChanged(object sender, EventArgs e)
        {
            
            if (label17.Text == "100" || label17.Text == "100.00")
            {
                panelProgressBar.Visible = false;
                panelFinalizar.Visible = true;
                button2.Text = "Finalizar";
                label1.Enabled = false;
                cbCrearAccesoDirecto.Checked = true;
            }
        }
    }
}
