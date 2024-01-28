namespace Ahorcado
{
    partial class Juego
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Juego));
            this.paneldejuego0 = new System.Windows.Forms.Panel();
            this.paneltiempo = new System.Windows.Forms.Panel();
            this.label1min = new System.Windows.Forms.Label();
            this.label30seg = new System.Windows.Forms.Label();
            this.label10seg = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelpalabra = new System.Windows.Forms.Label();
            this.gridviewplabraparajuego = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.palabraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.palabrasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.juegoDataSet = new Ahorcado.JuegoDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.palabrasTableAdapter = new Ahorcado.JuegoDataSetTableAdapters.PalabrasTableAdapter();
            this.coordenadas = new System.Windows.Forms.Label();
            this.labeljuegoletra = new System.Windows.Forms.Label();
            this.textBoxjuegoletra = new System.Windows.Forms.TextBox();
            this.labeljuegopalabra = new System.Windows.Forms.Label();
            this.textBoxjuegopalabra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelpalabracompleta = new System.Windows.Forms.Label();
            this.labelreinicio = new System.Windows.Forms.Label();
            this.pistasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pistasTableAdapter = new Ahorcado.JuegoDataSetTableAdapters.PistasTableAdapter();
            this.pistasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.GridViewpista = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pistaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPalabraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pistasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.labelpista = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelfallos = new System.Windows.Forms.Label();
            this.progresb = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labeltime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.paneldejuego0.SuspendLayout();
            this.paneltiempo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewplabraparajuego)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palabrasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.juegoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pistasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pistasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewpista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pistasBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // paneldejuego0
            // 
            this.paneldejuego0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paneldejuego0.BackgroundImage")));
            this.paneldejuego0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.paneldejuego0.Controls.Add(this.label6);
            this.paneldejuego0.Controls.Add(this.labelpalabra);
            this.paneldejuego0.Controls.Add(this.gridviewplabraparajuego);
            this.paneldejuego0.Controls.Add(this.label1);
            this.paneldejuego0.Location = new System.Drawing.Point(186, 87);
            this.paneldejuego0.Name = "paneldejuego0";
            this.paneldejuego0.Size = new System.Drawing.Size(448, 237);
            this.paneldejuego0.TabIndex = 0;
            this.paneldejuego0.Paint += new System.Windows.Forms.PaintEventHandler(this.paneldejuego0_Paint);
            this.paneldejuego0.MouseClick += new System.Windows.Forms.MouseEventHandler(this.paneldejuego0_MouseClick);
            this.paneldejuego0.MouseMove += new System.Windows.Forms.MouseEventHandler(this.paneldejuego0_MouseMove);
            // 
            // paneltiempo
            // 
            this.paneltiempo.BackgroundImage = global::Ahorcado.Properties.Resources.maderaobs;
            this.paneltiempo.Controls.Add(this.label9);
            this.paneltiempo.Controls.Add(this.label1min);
            this.paneltiempo.Controls.Add(this.label30seg);
            this.paneltiempo.Controls.Add(this.label10seg);
            this.paneltiempo.Controls.Add(this.label7);
            this.paneltiempo.Location = new System.Drawing.Point(186, 87);
            this.paneltiempo.Name = "paneltiempo";
            this.paneltiempo.Size = new System.Drawing.Size(448, 237);
            this.paneltiempo.TabIndex = 21;
            this.paneltiempo.Paint += new System.Windows.Forms.PaintEventHandler(this.paneltiempo_Paint);
            this.paneltiempo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.paneltiempo_MouseClick);
            this.paneltiempo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.paneltiempo_MouseMove);
            // 
            // label1min
            // 
            this.label1min.AutoSize = true;
            this.label1min.BackColor = System.Drawing.Color.LightBlue;
            this.label1min.Enabled = false;
            this.label1min.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1min.Location = new System.Drawing.Point(332, 100);
            this.label1min.Name = "label1min";
            this.label1min.Size = new System.Drawing.Size(74, 45);
            this.label1min.TabIndex = 22;
            this.label1min.Text = "          2\r\nMinutos para\r\n  Contestar ";
            // 
            // label30seg
            // 
            this.label30seg.AutoSize = true;
            this.label30seg.BackColor = System.Drawing.Color.LightBlue;
            this.label30seg.Enabled = false;
            this.label30seg.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30seg.Location = new System.Drawing.Point(191, 100);
            this.label30seg.Name = "label30seg";
            this.label30seg.Size = new System.Drawing.Size(77, 45);
            this.label30seg.TabIndex = 23;
            this.label30seg.Text = "          1.5\r\nMinutos para \r\n   Contestar ";
            // 
            // label10seg
            // 
            this.label10seg.AutoSize = true;
            this.label10seg.BackColor = System.Drawing.Color.LightBlue;
            this.label10seg.Enabled = false;
            this.label10seg.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10seg.Location = new System.Drawing.Point(42, 100);
            this.label10seg.Name = "label10seg";
            this.label10seg.Size = new System.Drawing.Size(69, 45);
            this.label10seg.TabIndex = 22;
            this.label10seg.Text = "         1\r\nMinuto para\r\n   Contestar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(71, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(317, 30);
            this.label7.TabIndex = 22;
            this.label7.Text = "Seleccione el Tiempo para jugar  ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightBlue;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(221, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Regresar";
            // 
            // labelpalabra
            // 
            this.labelpalabra.AutoSize = true;
            this.labelpalabra.BackColor = System.Drawing.Color.LightBlue;
            this.labelpalabra.Enabled = false;
            this.labelpalabra.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpalabra.Location = new System.Drawing.Point(195, 115);
            this.labelpalabra.Name = "labelpalabra";
            this.labelpalabra.Size = new System.Drawing.Size(110, 30);
            this.labelpalabra.TabIndex = 9;
            this.labelpalabra.Text = "Seleccionar Palabra\r\n       y Comenzar";
            // 
            // gridviewplabraparajuego
            // 
            this.gridviewplabraparajuego.AllowUserToAddRows = false;
            this.gridviewplabraparajuego.AllowUserToDeleteRows = false;
            this.gridviewplabraparajuego.AutoGenerateColumns = false;
            this.gridviewplabraparajuego.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewplabraparajuego.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.palabraDataGridViewTextBoxColumn});
            this.gridviewplabraparajuego.DataSource = this.palabrasBindingSource;
            this.gridviewplabraparajuego.Location = new System.Drawing.Point(139, 41);
            this.gridviewplabraparajuego.Name = "gridviewplabraparajuego";
            this.gridviewplabraparajuego.ReadOnly = true;
            this.gridviewplabraparajuego.Size = new System.Drawing.Size(204, 59);
            this.gridviewplabraparajuego.TabIndex = 2;
            this.gridviewplabraparajuego.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // palabraDataGridViewTextBoxColumn
            // 
            this.palabraDataGridViewTextBoxColumn.DataPropertyName = "Palabra";
            this.palabraDataGridViewTextBoxColumn.HeaderText = "Palabra";
            this.palabraDataGridViewTextBoxColumn.Name = "palabraDataGridViewTextBoxColumn";
            this.palabraDataGridViewTextBoxColumn.ReadOnly = true;
            this.palabraDataGridViewTextBoxColumn.Width = 170;
            // 
            // palabrasBindingSource
            // 
            this.palabrasBindingSource.DataMember = "Palabras";
            this.palabrasBindingSource.DataSource = this.juegoDataSet;
            // 
            // juegoDataSet
            // 
            this.juegoDataSet.DataSetName = "JuegoDataSet";
            this.juegoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(49, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione la palabra para el Jugador";
            // 
            // palabrasTableAdapter
            // 
            this.palabrasTableAdapter.ClearBeforeFill = true;
            // 
            // coordenadas
            // 
            this.coordenadas.AutoSize = true;
            this.coordenadas.Location = new System.Drawing.Point(116, 22);
            this.coordenadas.Name = "coordenadas";
            this.coordenadas.Size = new System.Drawing.Size(35, 13);
            this.coordenadas.TabIndex = 1;
            this.coordenadas.Text = "label2";
            // 
            // labeljuegoletra
            // 
            this.labeljuegoletra.AutoSize = true;
            this.labeljuegoletra.BackColor = System.Drawing.Color.Transparent;
            this.labeljuegoletra.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeljuegoletra.ForeColor = System.Drawing.SystemColors.Control;
            this.labeljuegoletra.Location = new System.Drawing.Point(521, 9);
            this.labeljuegoletra.Name = "labeljuegoletra";
            this.labeljuegoletra.Size = new System.Drawing.Size(181, 30);
            this.labeljuegoletra.TabIndex = 10;
            this.labeljuegoletra.Text = "Introdusca la Letra";
            this.labeljuegoletra.Visible = false;
            // 
            // textBoxjuegoletra
            // 
            this.textBoxjuegoletra.Location = new System.Drawing.Point(584, 42);
            this.textBoxjuegoletra.MaxLength = 1;
            this.textBoxjuegoletra.Name = "textBoxjuegoletra";
            this.textBoxjuegoletra.Size = new System.Drawing.Size(47, 20);
            this.textBoxjuegoletra.TabIndex = 11;
            this.textBoxjuegoletra.Visible = false;
            this.textBoxjuegoletra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxjuegoletra_KeyPress);
            // 
            // labeljuegopalabra
            // 
            this.labeljuegopalabra.AutoSize = true;
            this.labeljuegopalabra.BackColor = System.Drawing.Color.Transparent;
            this.labeljuegopalabra.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeljuegopalabra.ForeColor = System.Drawing.SystemColors.Control;
            this.labeljuegopalabra.Location = new System.Drawing.Point(519, 87);
            this.labeljuegopalabra.Name = "labeljuegopalabra";
            this.labeljuegopalabra.Size = new System.Drawing.Size(198, 30);
            this.labeljuegopalabra.TabIndex = 12;
            this.labeljuegopalabra.Text = "Introdusca la Palabra";
            this.labeljuegopalabra.Visible = false;
            // 
            // textBoxjuegopalabra
            // 
            this.textBoxjuegopalabra.Location = new System.Drawing.Point(541, 121);
            this.textBoxjuegopalabra.MaxLength = 50;
            this.textBoxjuegopalabra.Name = "textBoxjuegopalabra";
            this.textBoxjuegopalabra.Size = new System.Drawing.Size(144, 20);
            this.textBoxjuegopalabra.TabIndex = 13;
            this.textBoxjuegopalabra.Visible = false;
            this.textBoxjuegopalabra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxjuegopalabra_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightBlue;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Letra x Letra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightBlue;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(157, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Palabra Completa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightBlue;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(553, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Comprobar";
            // 
            // labelpalabracompleta
            // 
            this.labelpalabracompleta.AutoSize = true;
            this.labelpalabracompleta.Location = new System.Drawing.Point(691, 128);
            this.labelpalabracompleta.Name = "labelpalabracompleta";
            this.labelpalabracompleta.Size = new System.Drawing.Size(0, 13);
            this.labelpalabracompleta.TabIndex = 15;
            this.labelpalabracompleta.Visible = false;
            // 
            // labelreinicio
            // 
            this.labelreinicio.AutoSize = true;
            this.labelreinicio.BackColor = System.Drawing.Color.LightBlue;
            this.labelreinicio.Enabled = false;
            this.labelreinicio.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelreinicio.Location = new System.Drawing.Point(563, 244);
            this.labelreinicio.Name = "labelreinicio";
            this.labelreinicio.Size = new System.Drawing.Size(85, 26);
            this.labelreinicio.TabIndex = 16;
            this.labelreinicio.Text = "Reiniciar";
            // 
            // pistasBindingSource
            // 
            this.pistasBindingSource.DataMember = "Pistas";
            this.pistasBindingSource.DataSource = this.juegoDataSet;
            // 
            // pistasTableAdapter
            // 
            this.pistasTableAdapter.ClearBeforeFill = true;
            // 
            // pistasBindingSource1
            // 
            this.pistasBindingSource1.DataMember = "Pistas";
            this.pistasBindingSource1.DataSource = this.juegoDataSet;
            // 
            // GridViewpista
            // 
            this.GridViewpista.AllowUserToAddRows = false;
            this.GridViewpista.AllowUserToDeleteRows = false;
            this.GridViewpista.AutoGenerateColumns = false;
            this.GridViewpista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewpista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.pistaDataGridViewTextBoxColumn,
            this.iDPalabraDataGridViewTextBoxColumn});
            this.GridViewpista.DataSource = this.pistasBindingSource2;
            this.GridViewpista.Location = new System.Drawing.Point(12, 138);
            this.GridViewpista.Name = "GridViewpista";
            this.GridViewpista.ReadOnly = true;
            this.GridViewpista.Size = new System.Drawing.Size(140, 150);
            this.GridViewpista.TabIndex = 17;
            this.GridViewpista.Visible = false;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // pistaDataGridViewTextBoxColumn
            // 
            this.pistaDataGridViewTextBoxColumn.DataPropertyName = "Pista";
            this.pistaDataGridViewTextBoxColumn.HeaderText = "Pista";
            this.pistaDataGridViewTextBoxColumn.Name = "pistaDataGridViewTextBoxColumn";
            this.pistaDataGridViewTextBoxColumn.ReadOnly = true;
            this.pistaDataGridViewTextBoxColumn.Width = 130;
            // 
            // iDPalabraDataGridViewTextBoxColumn
            // 
            this.iDPalabraDataGridViewTextBoxColumn.DataPropertyName = "ID_Palabra";
            this.iDPalabraDataGridViewTextBoxColumn.HeaderText = "ID_Palabra";
            this.iDPalabraDataGridViewTextBoxColumn.Name = "iDPalabraDataGridViewTextBoxColumn";
            this.iDPalabraDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDPalabraDataGridViewTextBoxColumn.Visible = false;
            // 
            // pistasBindingSource2
            // 
            this.pistasBindingSource2.DataMember = "Pistas";
            this.pistasBindingSource2.DataSource = this.juegoDataSet;
            // 
            // labelpista
            // 
            this.labelpista.AutoSize = true;
            this.labelpista.BackColor = System.Drawing.Color.LightBlue;
            this.labelpista.Enabled = false;
            this.labelpista.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpista.Location = new System.Drawing.Point(39, 107);
            this.labelpista.Name = "labelpista";
            this.labelpista.Size = new System.Drawing.Size(32, 15);
            this.labelpista.TabIndex = 10;
            this.labelpista.Text = "Pista";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightBlue;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(289, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "FALLOS RESTANTES:";
            // 
            // labelfallos
            // 
            this.labelfallos.AutoSize = true;
            this.labelfallos.BackColor = System.Drawing.Color.LightBlue;
            this.labelfallos.Enabled = false;
            this.labelfallos.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfallos.Location = new System.Drawing.Point(419, 13);
            this.labelfallos.Name = "labelfallos";
            this.labelfallos.Size = new System.Drawing.Size(24, 26);
            this.labelfallos.TabIndex = 19;
            this.labelfallos.Text = "...";
            // 
            // progresb
            // 
            this.progresb.Location = new System.Drawing.Point(12, 445);
            this.progresb.Name = "progresb";
            this.progresb.Size = new System.Drawing.Size(776, 23);
            this.progresb.TabIndex = 20;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // labeltime
            // 
            this.labeltime.AutoSize = true;
            this.labeltime.BackColor = System.Drawing.Color.LightBlue;
            this.labeltime.Enabled = false;
            this.labeltime.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltime.Location = new System.Drawing.Point(469, 347);
            this.labeltime.Name = "labeltime";
            this.labeltime.Size = new System.Drawing.Size(22, 23);
            this.labeltime.TabIndex = 22;
            this.labeltime.Text = "...";
            this.labeltime.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LightBlue;
            this.label9.Enabled = false;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(191, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "REGRESAR";
            // 
            // Juego
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.labeltime);
            this.Controls.Add(this.paneltiempo);
            this.Controls.Add(this.progresb);
            this.Controls.Add(this.labelfallos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelpista);
            this.Controls.Add(this.GridViewpista);
            this.Controls.Add(this.paneldejuego0);
            this.Controls.Add(this.labelreinicio);
            this.Controls.Add(this.labelpalabracompleta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxjuegopalabra);
            this.Controls.Add(this.labeljuegopalabra);
            this.Controls.Add(this.textBoxjuegoletra);
            this.Controls.Add(this.labeljuegoletra);
            this.Controls.Add(this.coordenadas);
            this.MaximizeBox = false;
            this.Name = "Juego";
            this.Text = "Ahorcado C#";
            this.Load += new System.EventHandler(this.Juego_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Juego_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Juego_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Juego_MouseMove);
            this.paneldejuego0.ResumeLayout(false);
            this.paneldejuego0.PerformLayout();
            this.paneltiempo.ResumeLayout(false);
            this.paneltiempo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewplabraparajuego)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palabrasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.juegoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pistasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pistasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewpista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pistasBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel paneldejuego0;
        private System.Windows.Forms.DataGridView gridviewplabraparajuego;
        private System.Windows.Forms.Label label1;
        private JuegoDataSet juegoDataSet;
        private System.Windows.Forms.BindingSource palabrasBindingSource;
        private JuegoDataSetTableAdapters.PalabrasTableAdapter palabrasTableAdapter;
        private System.Windows.Forms.Label labelpalabra;
        private System.Windows.Forms.Label coordenadas;
        private System.Windows.Forms.Label labeljuegoletra;
        private System.Windows.Forms.TextBox textBoxjuegoletra;
        private System.Windows.Forms.Label labeljuegopalabra;
        private System.Windows.Forms.TextBox textBoxjuegopalabra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelpalabracompleta;
        private System.Windows.Forms.Label labelreinicio;
        private System.Windows.Forms.BindingSource pistasBindingSource;
        private JuegoDataSetTableAdapters.PistasTableAdapter pistasTableAdapter;
        private System.Windows.Forms.BindingSource pistasBindingSource1;
        private System.Windows.Forms.DataGridView GridViewpista;
        private System.Windows.Forms.BindingSource pistasBindingSource2;
        private System.Windows.Forms.Label labelpista;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelfallos;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn palabraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pistaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPalabraDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progresb;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel paneltiempo;
        private System.Windows.Forms.Label label1min;
        private System.Windows.Forms.Label label30seg;
        private System.Windows.Forms.Label label10seg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labeltime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label9;
    }
}