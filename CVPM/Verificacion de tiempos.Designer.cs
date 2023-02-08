namespace CVPM
{
    partial class Verificacion_de_tiempos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.base_De_Datos_pruebasP1DataSet3 = new CVPM.Base_De_Datos_pruebasP1DataSet3();
            this.tiemposMuertosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiemposMuertosTableAdapter = new CVPM.Base_De_Datos_pruebasP1DataSet3TableAdapters.TiemposMuertosTableAdapter();
            this.tableAdapterManager = new CVPM.Base_De_Datos_pruebasP1DataSet3TableAdapters.TableAdapterManager();
            this.tiemposMuertosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbfecha = new System.Windows.Forms.TextBox();
            this.Busqueda = new System.Windows.Forms.GroupBox();
            this.rbnombre = new System.Windows.Forms.RadioButton();
            this.rbequipo = new System.Windows.Forms.RadioButton();
            this.rbfecha = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.tbequipo = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.base_De_Datos_pruebasP1DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiemposMuertosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiemposMuertosDataGridView)).BeginInit();
            this.Busqueda.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 33);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(4, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 22);
            this.label7.TabIndex = 2;
            this.label7.Text = "TMPTest";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Location = new System.Drawing.Point(1004, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::CVPM.Properties.Resources.apagado;
            this.pictureBox3.Location = new System.Drawing.Point(1035, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // base_De_Datos_pruebasP1DataSet3
            // 
            this.base_De_Datos_pruebasP1DataSet3.DataSetName = "Base_De_Datos_pruebasP1DataSet3";
            this.base_De_Datos_pruebasP1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tiemposMuertosBindingSource
            // 
            this.tiemposMuertosBindingSource.DataMember = "TiemposMuertos";
            this.tiemposMuertosBindingSource.DataSource = this.base_De_Datos_pruebasP1DataSet3;
            // 
            // tiemposMuertosTableAdapter
            // 
            this.tiemposMuertosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.TiemposMuertosTableAdapter = this.tiemposMuertosTableAdapter;
            this.tableAdapterManager.UpdateOrder = CVPM.Base_De_Datos_pruebasP1DataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WIPTableAdapter = null;
            // 
            // tiemposMuertosDataGridView
            // 
            this.tiemposMuertosDataGridView.AllowUserToDeleteRows = false;
            this.tiemposMuertosDataGridView.AutoGenerateColumns = false;
            this.tiemposMuertosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tiemposMuertosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.tiemposMuertosDataGridView.DataSource = this.tiemposMuertosBindingSource;
            this.tiemposMuertosDataGridView.Location = new System.Drawing.Point(12, 188);
            this.tiemposMuertosDataGridView.Name = "tiemposMuertosDataGridView";
            this.tiemposMuertosDataGridView.ReadOnly = true;
            this.tiemposMuertosDataGridView.Size = new System.Drawing.Size(1039, 220);
            this.tiemposMuertosDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Hora de paro";
            this.dataGridViewTextBoxColumn2.HeaderText = "Hora de paro";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Hora de arranque";
            this.dataGridViewTextBoxColumn3.HeaderText = "Hora de arranque";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Fecha";
            this.dataGridViewTextBoxColumn4.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Equipo";
            this.dataGridViewTextBoxColumn5.HeaderText = "Equipo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Numero de equipos";
            this.dataGridViewTextBoxColumn6.HeaderText = "Numero de equipos";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Refacciones";
            this.dataGridViewTextBoxColumn7.HeaderText = "Refacciones";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Causa";
            this.dataGridViewTextBoxColumn8.HeaderText = "Causa";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Accion correctiva";
            this.dataGridViewTextBoxColumn9.HeaderText = "Accion correctiva";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn10.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // tbfecha
            // 
            this.tbfecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbfecha.Location = new System.Drawing.Point(10, 40);
            this.tbfecha.Name = "tbfecha";
            this.tbfecha.Size = new System.Drawing.Size(100, 20);
            this.tbfecha.TabIndex = 6;
            this.tbfecha.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // Busqueda
            // 
            this.Busqueda.Controls.Add(this.rbnombre);
            this.Busqueda.Controls.Add(this.rbequipo);
            this.Busqueda.Controls.Add(this.rbfecha);
            this.Busqueda.Controls.Add(this.button1);
            this.Busqueda.Controls.Add(this.label1);
            this.Busqueda.Controls.Add(this.label3);
            this.Busqueda.Controls.Add(this.label2);
            this.Busqueda.Controls.Add(this.tbnombre);
            this.Busqueda.Controls.Add(this.tbequipo);
            this.Busqueda.Controls.Add(this.tbfecha);
            this.Busqueda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Busqueda.Location = new System.Drawing.Point(12, 33);
            this.Busqueda.Name = "Busqueda";
            this.Busqueda.Size = new System.Drawing.Size(237, 149);
            this.Busqueda.TabIndex = 7;
            this.Busqueda.TabStop = false;
            this.Busqueda.Text = "Busqueda";
            // 
            // rbnombre
            // 
            this.rbnombre.AutoSize = true;
            this.rbnombre.Location = new System.Drawing.Point(124, 105);
            this.rbnombre.Name = "rbnombre";
            this.rbnombre.Size = new System.Drawing.Size(62, 17);
            this.rbnombre.TabIndex = 9;
            this.rbnombre.TabStop = true;
            this.rbnombre.Text = "Nombre";
            this.rbnombre.UseVisualStyleBackColor = true;
            this.rbnombre.CheckedChanged += new System.EventHandler(this.rbnombre_CheckedChanged);
            // 
            // rbequipo
            // 
            this.rbequipo.AutoSize = true;
            this.rbequipo.Location = new System.Drawing.Point(124, 85);
            this.rbequipo.Name = "rbequipo";
            this.rbequipo.Size = new System.Drawing.Size(58, 17);
            this.rbequipo.TabIndex = 9;
            this.rbequipo.TabStop = true;
            this.rbequipo.Text = "Equipo";
            this.rbequipo.UseVisualStyleBackColor = true;
            this.rbequipo.CheckedChanged += new System.EventHandler(this.rbequipo_CheckedChanged);
            // 
            // rbfecha
            // 
            this.rbfecha.AutoSize = true;
            this.rbfecha.Location = new System.Drawing.Point(124, 66);
            this.rbfecha.Name = "rbfecha";
            this.rbfecha.Size = new System.Drawing.Size(55, 17);
            this.rbfecha.TabIndex = 9;
            this.rbfecha.TabStop = true;
            this.rbfecha.Text = "Fecha";
            this.rbfecha.UseVisualStyleBackColor = true;
            this.rbfecha.CheckedChanged += new System.EventHandler(this.rbfecha_CheckedChanged);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(172, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 8;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(6, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(124, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Equipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fecha";
            // 
            // tbnombre
            // 
            this.tbnombre.Location = new System.Drawing.Point(10, 105);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(100, 20);
            this.tbnombre.TabIndex = 6;
            // 
            // tbequipo
            // 
            this.tbequipo.Location = new System.Drawing.Point(128, 40);
            this.tbequipo.Name = "tbequipo";
            this.tbequipo.Size = new System.Drawing.Size(100, 20);
            this.tbequipo.TabIndex = 6;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(9, 9);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.monthCalendar1);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Location = new System.Drawing.Point(255, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 203);
            this.panel2.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(201, 181);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 19);
            this.button3.TabIndex = 8;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Verificacion_de_tiempos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1063, 424);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Busqueda);
            this.Controls.Add(this.tiemposMuertosDataGridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Verificacion_de_tiempos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verificacion_de_tiempos";
            this.Load += new System.EventHandler(this.Verificacion_de_tiempos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.base_De_Datos_pruebasP1DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiemposMuertosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiemposMuertosDataGridView)).EndInit();
            this.Busqueda.ResumeLayout(false);
            this.Busqueda.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Base_De_Datos_pruebasP1DataSet3 base_De_Datos_pruebasP1DataSet3;
        private System.Windows.Forms.BindingSource tiemposMuertosBindingSource;
        private Base_De_Datos_pruebasP1DataSet3TableAdapters.TiemposMuertosTableAdapter tiemposMuertosTableAdapter;
        private Base_De_Datos_pruebasP1DataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tiemposMuertosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.TextBox tbfecha;
        private System.Windows.Forms.GroupBox Busqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbnombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbequipo;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton rbnombre;
        private System.Windows.Forms.RadioButton rbequipo;
        private System.Windows.Forms.RadioButton rbfecha;
    }
}