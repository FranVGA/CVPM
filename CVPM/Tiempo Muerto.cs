using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Diagnostics;
using System.IO;

namespace CVPM
{
    public partial class Tiempo_Muerto : Form
    {
        int m, mX, mY;

        /*Variables de archivo bufer*/
        string nombre, apellido, id, puesto, proyecto1, proyecto2;
        string RutaBuf = @"C:\CVPM\Bufer\BuferUser.txt";

        /*Base de datos*/
        OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Base_De_Datos_pruebasP1.accdb");

        public Tiempo_Muerto()
        {
            InitializeComponent();
        }

        private void Tiempo_Muerto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'base_De_Datos_pruebasP1DataSet3.TiemposMuertos' Puede moverla o quitarla según sea necesario.
            this.tiemposMuertosTableAdapter.Fill(this.base_De_Datos_pruebasP1DataSet3.TiemposMuertos);
            panel2.Visible = false;
            txbnupart.Enabled = false;
            try
            {
                conexion.Open();
                lblestado.Text = "Conectado";
                lblestado.ForeColor = Color.Green;
            }
            catch (Exception error)
            {
                lblestado.Text = "Desconectado";
                lblestado.ForeColor = Color.Red;
            }

            StreamReader buferRuta = new StreamReader(RutaBuf);
            id = buferRuta.ReadLine();
            nombre = buferRuta.ReadLine();
            apellido = buferRuta.ReadLine();
            proyecto1 = buferRuta.ReadLine();
            proyecto2 = buferRuta.ReadLine();
            puesto = buferRuta.ReadLine();

            lblnombre.Text = nombre + " " + apellido;

            tiemposMuertosDataGridView.Visible = false;
        }








        /*Barra de movimiento*/
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mX = e.X;
            mY = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }


        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1) this.SetDesktopLocation(MousePosition.X - mX, MousePosition.Y - mY);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tiemposMuertosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tiemposMuertosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.base_De_Datos_pruebasP1DataSet3);

        }










        /*Ingreso de datos*/


        private void tbfecha_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void selecSi_CheckedChanged(object sender, EventArgs e)
        {
            selecNO.Checked = false;
            txbnupart.Enabled = true;
        }

        private void selecNO_CheckedChanged(object sender, EventArgs e)
        {
            selecSi.Checked = false;
            txbnupart.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fecha = monthCalendar1.SelectionStart.Day.ToString() + "/" + monthCalendar1.SelectionStart.Month.ToString() + "/" + monthCalendar1.SelectionStart.Year.ToString();
            tbfecha.Text = fecha;
            panel2.Visible = false;
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            try
            {
                string horaDeParo, horaDeArranque, causa, accion;
                horaDeParo = cbhp.Text + ":" + cbmp.Text;
                horaDeArranque = cbha.Text + ":" + cbma.Text;
                causa = rtbCausa.Text;
                accion = rtbaccion.Text;
                this.tiemposMuertosTableAdapter.InsertTiemposMuertos(horaDeParo, horaDeArranque, tbfecha.Text, cbequipo.Text, cbnumeq.Text, txbnupart.Text, causa, accion, lblnombre.Text);
                MessageBox.Show("Resgistrado exitosamente");
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error al registrar");
            }
            tbfecha.Text = "";
            cbequipo.Text = "";
            cbha.Text = "";
            cbma.Text = "";
            cbhp.Text = "";
            cbmp.Text = "";
            cbnumeq.Text = "";
            txbnupart.Text = "";
            rtbaccion.Text = "";
            rtbCausa.Text = "";

        }

    }
}
