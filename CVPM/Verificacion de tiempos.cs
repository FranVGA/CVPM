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
    public partial class Verificacion_de_tiempos : Form
    {

        /*Base de datos*/
        OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Base_De_Datos_pruebasP1.accdb");

        int m, mX, mY;

        public Verificacion_de_tiempos()
        {
            InitializeComponent();
        }

        private void Verificacion_de_tiempos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'base_De_Datos_pruebasP1DataSet3.TiemposMuertos' Puede moverla o quitarla según sea necesario.
            this.tiemposMuertosTableAdapter.Fill(this.base_De_Datos_pruebasP1DataSet3.TiemposMuertos);
            try
            {
                conexion.Open();

            }
            catch (Exception error)
            {
                MessageBox.Show("Error en la conexion");
            }
            panel2.Visible = false;
            tbequipo.Enabled = false;
            tbfecha.Enabled = false;
            tbnombre.Enabled = false;
        }






        private void tiemposMuertosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tiemposMuertosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.base_De_Datos_pruebasP1DataSet3);

        }












        /*Busqueda*/
        private void rbfecha_CheckedChanged(object sender, EventArgs e)
        {
            rbequipo.Checked = false;
            rbnombre.Checked = false;

            tbfecha.Enabled = true;
            tbnombre.Enabled = false;
            tbequipo.Enabled = false;
        }

        private void rbequipo_CheckedChanged(object sender, EventArgs e)
        {
            rbfecha.Checked = false;
            rbnombre.Checked = false;

            tbfecha.Enabled = false;
            tbnombre.Enabled = false;
            tbequipo.Enabled = true;
        }

        private void rbnombre_CheckedChanged(object sender, EventArgs e)
        {
            rbequipo.Checked = false;
            rbfecha.Checked = false;

            tbfecha.Enabled = false;
            tbnombre.Enabled = true;
            tbequipo.Enabled = false;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbfecha.Checked == true)
            {
                this.tiemposMuertosTableAdapter.BusquedaPorFecha(base_De_Datos_pruebasP1DataSet3.TiemposMuertos, tbfecha.Text);
            }
            else if (rbequipo.Checked == true)
            {
                this.tiemposMuertosTableAdapter.BusquedaPorEquipo(base_De_Datos_pruebasP1DataSet3.TiemposMuertos, tbequipo.Text);
            }
            else if (rbnombre.Checked == true)  
            {
                this.tiemposMuertosTableAdapter.BusquedaPorNombre(base_De_Datos_pruebasP1DataSet3.TiemposMuertos, tbnombre.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string fecha = monthCalendar1.SelectionStart.Day.ToString() + "/" + monthCalendar1.SelectionStart.Month.ToString() + "/" + monthCalendar1.SelectionStart.Year.ToString();
            tbfecha.Text = fecha;
            panel2.Visible = false;
        }








        /*Barra de movimiento*/
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mX = e.X;
            mY = e.Y;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1) this.SetDesktopLocation(MousePosition.X - mX, MousePosition.Y - mY);
        }
    }
}
