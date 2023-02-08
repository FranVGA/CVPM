namespace CVPM
{
    partial class Tiempo_Muerto
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tbfecha = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbequipo = new System.Windows.Forms.ComboBox();
            this.cbnumeq = new System.Windows.Forms.ComboBox();
            this.rtbaccion = new System.Windows.Forms.RichTextBox();
            this.rtbCausa = new System.Windows.Forms.RichTextBox();
            this.selecSi = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.selecNO = new System.Windows.Forms.RadioButton();
            this.txbnupart = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.cbma = new System.Windows.Forms.ComboBox();
            this.cbha = new System.Windows.Forms.ComboBox();
            this.cbmp = new System.Windows.Forms.ComboBox();
            this.cbhp = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblestado = new System.Windows.Forms.Label();
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
            this.tiemposMuertosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.base_De_Datos_pruebasP1DataSet3 = new CVPM.Base_De_Datos_pruebasP1DataSet3();
            this.tiemposMuertosTableAdapter = new CVPM.Base_De_Datos_pruebasP1DataSet3TableAdapters.TiemposMuertosTableAdapter();
            this.tableAdapterManager = new CVPM.Base_De_Datos_pruebasP1DataSet3TableAdapters.TableAdapterManager();
            this.lblnombre = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tiemposMuertosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiemposMuertosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.base_De_Datos_pruebasP1DataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // tbfecha
            // 
            this.tbfecha.Location = new System.Drawing.Point(16, 76);
            this.tbfecha.Name = "tbfecha";
            this.tbfecha.Size = new System.Drawing.Size(123, 20);
            this.tbfecha.TabIndex = 1;
            this.tbfecha.Click += new System.EventHandler(this.tbfecha_Click);
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
            this.panel1.Size = new System.Drawing.Size(611, 33);
            this.panel1.TabIndex = 3;
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
            this.pictureBox4.Location = new System.Drawing.Point(547, 5);
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
            this.pictureBox3.Location = new System.Drawing.Point(578, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(155, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hora de paro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(155, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hora de arranque";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Numero de equipos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(304, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Causa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(304, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Accion correctiva";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(12, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 21);
            this.label8.TabIndex = 5;
            this.label8.Text = "Equipo";
            // 
            // cbequipo
            // 
            this.cbequipo.FormattingEnabled = true;
            this.cbequipo.Items.AddRange(new object[] {
            "eqp1",
            "eqp2",
            "eqp3",
            "eqp4"});
            this.cbequipo.Location = new System.Drawing.Point(16, 137);
            this.cbequipo.Name = "cbequipo";
            this.cbequipo.Size = new System.Drawing.Size(129, 21);
            this.cbequipo.TabIndex = 4;
            // 
            // cbnumeq
            // 
            this.cbnumeq.FormattingEnabled = true;
            this.cbnumeq.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbnumeq.Location = new System.Drawing.Point(16, 197);
            this.cbnumeq.Name = "cbnumeq";
            this.cbnumeq.Size = new System.Drawing.Size(75, 21);
            this.cbnumeq.TabIndex = 4;
            // 
            // rtbaccion
            // 
            this.rtbaccion.Location = new System.Drawing.Point(308, 216);
            this.rtbaccion.Name = "rtbaccion";
            this.rtbaccion.Size = new System.Drawing.Size(283, 96);
            this.rtbaccion.TabIndex = 6;
            this.rtbaccion.Text = "";
            // 
            // rtbCausa
            // 
            this.rtbCausa.Location = new System.Drawing.Point(308, 76);
            this.rtbCausa.Name = "rtbCausa";
            this.rtbCausa.Size = new System.Drawing.Size(283, 96);
            this.rtbCausa.TabIndex = 6;
            this.rtbCausa.Text = "";
            // 
            // selecSi
            // 
            this.selecSi.AutoSize = true;
            this.selecSi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.selecSi.Location = new System.Drawing.Point(16, 254);
            this.selecSi.Name = "selecSi";
            this.selecSi.Size = new System.Drawing.Size(34, 17);
            this.selecSi.TabIndex = 8;
            this.selecSi.TabStop = true;
            this.selecSi.Text = "Si";
            this.selecSi.UseVisualStyleBackColor = true;
            this.selecSi.CheckedChanged += new System.EventHandler(this.selecSi_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(141, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 21);
            this.label9.TabIndex = 5;
            this.label9.Text = "# de parte";
            // 
            // selecNO
            // 
            this.selecNO.AutoSize = true;
            this.selecNO.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.selecNO.Location = new System.Drawing.Point(57, 254);
            this.selecNO.Name = "selecNO";
            this.selecNO.Size = new System.Drawing.Size(39, 17);
            this.selecNO.TabIndex = 8;
            this.selecNO.TabStop = true;
            this.selecNO.Text = "No";
            this.selecNO.UseVisualStyleBackColor = true;
            this.selecNO.CheckedChanged += new System.EventHandler(this.selecNO_CheckedChanged);
            // 
            // txbnupart
            // 
            this.txbnupart.Location = new System.Drawing.Point(16, 277);
            this.txbnupart.Name = "txbnupart";
            this.txbnupart.Size = new System.Drawing.Size(123, 20);
            this.txbnupart.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(12, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(216, 21);
            this.label10.TabIndex = 5;
            this.label10.Text = "Se requirieron refacciones?";
            // 
            // btnregistrar
            // 
            this.btnregistrar.Location = new System.Drawing.Point(518, 323);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(73, 19);
            this.btnregistrar.TabIndex = 10;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.monthCalendar1.Location = new System.Drawing.Point(9, 6);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.monthCalendar1);
            this.panel2.Location = new System.Drawing.Point(180, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 211);
            this.panel2.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(163, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 20);
            this.button2.TabIndex = 12;
            this.button2.Text = "Seleccionar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(203, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 21);
            this.label13.TabIndex = 5;
            this.label13.Text = ":";
            // 
            // cbma
            // 
            this.cbma.FormattingEnabled = true;
            this.cbma.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60"});
            this.cbma.Location = new System.Drawing.Point(223, 136);
            this.cbma.Name = "cbma";
            this.cbma.Size = new System.Drawing.Size(38, 21);
            this.cbma.TabIndex = 4;
            // 
            // cbha
            // 
            this.cbha.FormattingEnabled = true;
            this.cbha.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cbha.Location = new System.Drawing.Point(159, 137);
            this.cbha.Name = "cbha";
            this.cbha.Size = new System.Drawing.Size(38, 21);
            this.cbha.TabIndex = 4;
            // 
            // cbmp
            // 
            this.cbmp.FormattingEnabled = true;
            this.cbmp.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60"});
            this.cbmp.Location = new System.Drawing.Point(223, 76);
            this.cbmp.Name = "cbmp";
            this.cbmp.Size = new System.Drawing.Size(38, 21);
            this.cbmp.TabIndex = 4;
            // 
            // cbhp
            // 
            this.cbhp.FormattingEnabled = true;
            this.cbhp.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cbhp.Location = new System.Drawing.Point(159, 77);
            this.cbhp.Name = "cbhp";
            this.cbhp.Size = new System.Drawing.Size(38, 21);
            this.cbhp.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(203, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 21);
            this.label11.TabIndex = 5;
            this.label11.Text = ":";
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblestado.Location = new System.Drawing.Point(616, 326);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(0, 13);
            this.lblestado.TabIndex = 13;
            // 
            // tiemposMuertosDataGridView
            // 
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
            this.tiemposMuertosDataGridView.Location = new System.Drawing.Point(597, 170);
            this.tiemposMuertosDataGridView.Name = "tiemposMuertosDataGridView";
            this.tiemposMuertosDataGridView.Size = new System.Drawing.Size(595, 123);
            this.tiemposMuertosDataGridView.TabIndex = 28;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Hora de paro";
            this.dataGridViewTextBoxColumn2.HeaderText = "Hora de paro";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Hora de arranque";
            this.dataGridViewTextBoxColumn3.HeaderText = "Hora de arranque";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Fecha";
            this.dataGridViewTextBoxColumn4.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Equipo";
            this.dataGridViewTextBoxColumn5.HeaderText = "Equipo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Numero de equipos";
            this.dataGridViewTextBoxColumn6.HeaderText = "Numero de equipos";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Refacciones";
            this.dataGridViewTextBoxColumn7.HeaderText = "Refacciones";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Causa";
            this.dataGridViewTextBoxColumn8.HeaderText = "Causa";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Accion correctiva";
            this.dataGridViewTextBoxColumn9.HeaderText = "Accion correctiva";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn10.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // tiemposMuertosBindingSource
            // 
            this.tiemposMuertosBindingSource.DataMember = "TiemposMuertos";
            this.tiemposMuertosBindingSource.DataSource = this.base_De_Datos_pruebasP1DataSet3;
            // 
            // base_De_Datos_pruebasP1DataSet3
            // 
            this.base_De_Datos_pruebasP1DataSet3.DataSetName = "Base_De_Datos_pruebasP1DataSet3";
            this.base_De_Datos_pruebasP1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblnombre.Location = new System.Drawing.Point(75, 526);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(0, 21);
            this.lblnombre.TabIndex = 29;
            // 
            // Tiempo_Muerto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(611, 352);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.selecNO);
            this.Controls.Add(this.selecSi);
            this.Controls.Add(this.rtbCausa);
            this.Controls.Add(this.rtbaccion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbequipo);
            this.Controls.Add(this.cbhp);
            this.Controls.Add(this.cbmp);
            this.Controls.Add(this.cbha);
            this.Controls.Add(this.cbma);
            this.Controls.Add(this.cbnumeq);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txbnupart);
            this.Controls.Add(this.tbfecha);
            this.Controls.Add(this.tiemposMuertosDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tiempo_Muerto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Causa";
            this.Load += new System.EventHandler(this.Tiempo_Muerto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tiemposMuertosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiemposMuertosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.base_De_Datos_pruebasP1DataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox tbfecha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbequipo;
        private System.Windows.Forms.ComboBox cbnumeq;
        private System.Windows.Forms.RichTextBox rtbaccion;
        private System.Windows.Forms.RichTextBox rtbCausa;
        private System.Windows.Forms.RadioButton selecSi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton selecNO;
        private System.Windows.Forms.TextBox txbnupart;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbma;
        private System.Windows.Forms.ComboBox cbha;
        private System.Windows.Forms.ComboBox cbmp;
        private System.Windows.Forms.ComboBox cbhp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblestado;
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
        private System.Windows.Forms.Label lblnombre;
    }
}