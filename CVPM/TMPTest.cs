using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace CVPM
{
    public partial class TMPTest : Form
    {
        /*Movimiento de ventana*/
        int m, mX, mY;

        /*Variables de archivo bufer*/
        string nombre, apellido, id, puesto, proyecto1, proyecto2;
        string RutaBuf = @"C:\CVPM\Bufer\BuferUser.txt";

        /*Opciones de ventana*/

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mX = e.X;
            mY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1) this.SetDesktopLocation(MousePosition.X - mX, MousePosition.Y - mY);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        /*barra de herramientas*/
        
        private void tiemposMuertosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelTiMu.Visible = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            PanelTiMu.Visible = false;
        }


        /*Tiempos muertos*/
        private void BTNingresar_Click(object sender, EventArgs e)
        {
            Form Tiempo = new Tiempo_Muerto();
            Tiempo.Show();
            /*
            this.Hide();
            */
        }

        private void btnVeri_Click(object sender, EventArgs e)
        {
            Form VeriTi = new Verificacion_de_tiempos();
            VeriTi.Show();
        }

        /**/

        public TMPTest()
        {
            InitializeComponent();
        }

        private void TMPTest_Load(object sender, EventArgs e)
        {
            PanelTiMu.Visible = false;
            /*Lectura de archivo*/
            StreamReader buferRuta = new StreamReader(RutaBuf);
            id = buferRuta.ReadLine();
            nombre = buferRuta.ReadLine();
            apellido = buferRuta.ReadLine();
            proyecto1 = buferRuta.ReadLine();
            proyecto2 = buferRuta.ReadLine();
            puesto = buferRuta.ReadLine();

            lblnombre.Text = nombre + " " + apellido;
            lblpuesto.Text = puesto;
            lblproyecto1.Text = proyecto1;
            lblproyecto2.Text = proyecto2;
        }
    }
}
