using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Instalador
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int cont;
        private void timer1_Tick(object sender, EventArgs e)
        {
            cont++;
            if (cont>10)
            {
                timer1.Stop();
                this.Hide();
                Form1 obj = new Form1();
                obj.Show();
                //Application.Exit();
            }
            if(cont==3)
            {
                label2.Text = "Cargando";
            }
            if (cont == 6)
            {
                label2.Text = "Comprobando Motor de Datos";
            }
            if (cont == 9)
            {
                label2.Text = "Comprobando DataBase";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
