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
using System.IO;

namespace CVPM
{
    public partial class Form1 : Form
    {
        int m, mX, mY;
        int x;
        int porcentaje;

        /*Base de datos*/
        OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Base_De_Datos_pruebasP1.accdb");

        /*Buffer*/
        string RutaBuf = @"C:\CVPM\Bufer\BuferUser.txt";

        /*Movimiento de ventana*/
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mX = e.X;
            mY = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1) this.SetDesktopLocation(MousePosition.X - mX, MousePosition.Y - mY);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mX = e.X;
            mY = e.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1) this.SetDesktopLocation(MousePosition.X - mX, MousePosition.Y - mY);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        /********/
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'base_De_Datos_pruebasP1DataSet3.Login' Puede moverla o quitarla según sea necesario.
            this.loginTableAdapter.Fill(this.base_De_Datos_pruebasP1DataSet3.Login);
            loginDataGridView.Visible = false;
            try
            {
                conexion.Open();
                LblEstado.Text = "Conectado";
                LblEstado.ForeColor = Color.Green;
            }
            catch(Exception error)
            {
                LblEstado.Text = "Desconectado";
                LblEstado.ForeColor = Color.Red;
            }
            TbUser.Focus();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string strnombre, strapellido, strproyecto1, strproyecto2, strID, strPuesto;
            string consulta = "select password, usuario from Login where password = '" + TBPass.Text + "' and usuario = '" + TbUser.Text + "'";
            OleDbCommand comando = new OleDbCommand(consulta, conexion);
            OleDbDataReader leer;
            leer = comando.ExecuteReader();
            Boolean comprobacion = leer.HasRows;
            if (comprobacion)
            {
                OleDbCommand cmd = conexion.CreateCommand();
                this.loginTableAdapter.Busqueda(base_De_Datos_pruebasP1DataSet3.Login, TbUser.Text);
                strID = loginDataGridView.Rows[0].Cells[0].Value.ToString();
                strnombre = loginDataGridView.Rows[0].Cells[3].Value.ToString();
                strapellido = loginDataGridView.Rows[0].Cells[4].Value.ToString();
                strproyecto1 = loginDataGridView.Rows[0].Cells[5].Value.ToString();
                strproyecto2 = loginDataGridView.Rows[0].Cells[6].Value.ToString();
                strPuesto = loginDataGridView.Rows[0].Cells[7].Value.ToString();
                cmd.CommandText = "select id from Login";
                File.WriteAllText(RutaBuf, "");
                using (StreamWriter bufer = File.AppendText(RutaBuf))
                {
                    bufer.WriteLine(strID);
                    bufer.WriteLine(strnombre);
                    bufer.WriteLine(strapellido);
                    bufer.WriteLine(strproyecto1);
                    bufer.WriteLine(strproyecto2);
                    bufer.WriteLine(strPuesto);
                }
                TiPB.Start();
            }
            else
            {
                MessageBox.Show("Usuario no existe");
            }
        }

        private void loginBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.loginBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.base_De_Datos_pruebasP1DataSet3);

        }

        private void TbUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            { 
                TBPass.Focus();
            }
        }

        private void TBPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string strnombre, strapellido, strproyecto1, strproyecto2, strID, strPuesto;
                string consulta = "select password, usuario from Login where password = '" + TBPass.Text + "' and usuario = '" + TbUser.Text + "'";
                OleDbCommand comando = new OleDbCommand(consulta, conexion);
                OleDbDataReader leer;
                leer = comando.ExecuteReader();
                Boolean comprobacion = leer.HasRows;
                if (comprobacion)
                {
                    OleDbCommand cmd = conexion.CreateCommand();
                    this.loginTableAdapter.Busqueda(base_De_Datos_pruebasP1DataSet3.Login, TbUser.Text);
                    strID = loginDataGridView.Rows[0].Cells[0].Value.ToString();
                    strnombre = loginDataGridView.Rows[0].Cells[3].Value.ToString();
                    strapellido = loginDataGridView.Rows[0].Cells[4].Value.ToString();
                    strproyecto1 = loginDataGridView.Rows[0].Cells[5].Value.ToString();
                    strproyecto2 = loginDataGridView.Rows[0].Cells[6].Value.ToString();
                    strPuesto = loginDataGridView.Rows[0].Cells[7].Value.ToString();
                    cmd.CommandText = "select id from Login";
                    File.WriteAllText(RutaBuf, "");
                    using (StreamWriter bufer = File.AppendText(RutaBuf))
                    {
                        bufer.WriteLine(strID);
                        bufer.WriteLine(strnombre);
                        bufer.WriteLine(strapellido);
                        bufer.WriteLine(strproyecto1);
                        bufer.WriteLine(strproyecto2);
                        bufer.WriteLine(strPuesto);
                    }
                    TiPB.Start();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos / Verifique conexion");
                }
            }
        }


        private void TiPB_Tick_1(object sender, EventArgs e)
        {
            ProB.Width = x;
            x += 10;
            porcentaje = (x * 100) / borde.Width;
            if (porcentaje >= 100)
            {
                Form Login = new TMPTest();
                Login.Show();
                this.Hide();
                TiPB.Stop();
            }
        }

        private void TiPB_Tick(object sender, EventArgs e)
        {
            ProB.Width = x;
            x += 10;
            porcentaje = (x * 100) / borde.Width;
            if (porcentaje >= 100)
            {
                Form Login = new TMPTest();
                Login.Show();
                /**/this.Hide();
                TiPB.Stop();
            }
        }

    }
}
