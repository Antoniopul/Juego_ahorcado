namespace Ahorcado
{
    partial class Guardado
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBpalabra = new System.Windows.Forms.TextBox();
            this.textBpista = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.coordenadas = new System.Windows.Forms.Label();
            this.palabrasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.juegoDataSet = new Ahorcado.JuegoDataSet();
            this.juegoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.palabrasTableAdapter = new Ahorcado.JuegoDataSetTableAdapters.PalabrasTableAdapter();
            this.palabrasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.palabrasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.palabrasBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.gridviewpalabra = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.palabraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelpalabra = new System.Windows.Forms.Label();
            this.labelpista = new System.Windows.Forms.Label();
            this.labeljugar = new System.Windows.Forms.Label();
            this.gridviewpistas = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pistaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPalabraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pistasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pistasTableAdapter = new Ahorcado.JuegoDataSetTableAdapters.PistasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.palabrasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.juegoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.juegoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palabrasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palabrasBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palabrasBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewpalabra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewpistas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pistasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduce la plabra:";
            // 
            // textBpalabra
            // 
            this.textBpalabra.Location = new System.Drawing.Point(12, 38);
            this.textBpalabra.MaxLength = 50;
            this.textBpalabra.Name = "textBpalabra";
            this.textBpalabra.Size = new System.Drawing.Size(166, 20);
            this.textBpalabra.TabIndex = 1;
            this.textBpalabra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBpalabra_KeyPress);
            // 
            // textBpista
            // 
            this.textBpista.Location = new System.Drawing.Point(161, 105);
            this.textBpista.MaxLength = 50;
            this.textBpista.Multiline = true;
            this.textBpista.Name = "textBpista";
            this.textBpista.Size = new System.Drawing.Size(199, 130);
            this.textBpista.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(7, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selecciona la palabra y genera una pista:";
            // 
            // coordenadas
            // 
            this.coordenadas.AutoSize = true;
            this.coordenadas.Location = new System.Drawing.Point(437, 136);
            this.coordenadas.Name = "coordenadas";
            this.coordenadas.Size = new System.Drawing.Size(35, 13);
            this.coordenadas.TabIndex = 5;
            this.coordenadas.Text = "label3";
            this.coordenadas.Visible = false;
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
            // juegoDataSetBindingSource
            // 
            this.juegoDataSetBindingSource.DataSource = this.juegoDataSet;
            this.juegoDataSetBindingSource.Position = 0;
            // 
            // palabrasTableAdapter
            // 
            this.palabrasTableAdapter.ClearBeforeFill = true;
            // 
            // palabrasBindingSource1
            // 
            this.palabrasBindingSource1.DataMember = "Palabras";
            this.palabrasBindingSource1.DataSource = this.juegoDataSetBindingSource;
            // 
            // palabrasBindingSource2
            // 
            this.palabrasBindingSource2.DataMember = "Palabras";
            this.palabrasBindingSource2.DataSource = this.juegoDataSetBindingSource;
            // 
            // palabrasBindingSource3
            // 
            this.palabrasBindingSource3.DataMember = "Palabras";
            this.palabrasBindingSource3.DataSource = this.juegoDataSetBindingSource;
            // 
            // gridviewpalabra
            // 
            this.gridviewpalabra.AllowUserToAddRows = false;
            this.gridviewpalabra.AllowUserToDeleteRows = false;
            this.gridviewpalabra.AllowUserToResizeColumns = false;
            this.gridviewpalabra.AllowUserToResizeRows = false;
            this.gridviewpalabra.AutoGenerateColumns = false;
            this.gridviewpalabra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewpalabra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.palabraDataGridViewTextBoxColumn});
            this.gridviewpalabra.DataSource = this.palabrasBindingSource;
            this.gridviewpalabra.Location = new System.Drawing.Point(12, 106);
            this.gridviewpalabra.MultiSelect = false;
            this.gridviewpalabra.Name = "gridviewpalabra";
            this.gridviewpalabra.ReadOnly = true;
            this.gridviewpalabra.Size = new System.Drawing.Size(143, 130);
            this.gridviewpalabra.TabIndex = 0;
            this.gridviewpalabra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewpalabra_CellClick);
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
            // 
            // labelpalabra
            // 
            this.labelpalabra.AutoSize = true;
            this.labelpalabra.BackColor = System.Drawing.Color.LightBlue;
            this.labelpalabra.Enabled = false;
            this.labelpalabra.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpalabra.Location = new System.Drawing.Point(382, 25);
            this.labelpalabra.Name = "labelpalabra";
            this.labelpalabra.Size = new System.Drawing.Size(49, 30);
            this.labelpalabra.TabIndex = 8;
            this.labelpalabra.Text = "Guardar\r\nPalabra ";
            // 
            // labelpista
            // 
            this.labelpista.AutoSize = true;
            this.labelpista.BackColor = System.Drawing.Color.LightBlue;
            this.labelpista.Enabled = false;
            this.labelpista.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpista.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelpista.Location = new System.Drawing.Point(385, 205);
            this.labelpista.Name = "labelpista";
            this.labelpista.Size = new System.Drawing.Size(49, 30);
            this.labelpista.TabIndex = 9;
            this.labelpista.Text = "Guardar\r\n  Pista";
            // 
            // labeljugar
            // 
            this.labeljugar.AutoSize = true;
            this.labeljugar.BackColor = System.Drawing.Color.LightBlue;
            this.labeljugar.Enabled = false;
            this.labeljugar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeljugar.Location = new System.Drawing.Point(424, 290);
            this.labeljugar.Name = "labeljugar";
            this.labeljugar.Size = new System.Drawing.Size(48, 30);
            this.labeljugar.TabIndex = 10;
            this.labeljugar.Text = "JUGAR \r\n  UwU";
            // 
            // gridviewpistas
            // 
            this.gridviewpistas.AllowUserToAddRows = false;
            this.gridviewpistas.AllowUserToDeleteRows = false;
            this.gridviewpistas.AutoGenerateColumns = false;
            this.gridviewpistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewpistas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.pistaDataGridViewTextBoxColumn,
            this.iDPalabraDataGridViewTextBoxColumn});
            this.gridviewpistas.DataSource = this.pistasBindingSource;
            this.gridviewpistas.Location = new System.Drawing.Point(12, 253);
            this.gridviewpistas.MultiSelect = false;
            this.gridviewpistas.Name = "gridviewpistas";
            this.gridviewpistas.ReadOnly = true;
            this.gridviewpistas.Size = new System.Drawing.Size(348, 114);
            this.gridviewpistas.TabIndex = 11;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // pistaDataGridViewTextBoxColumn
            // 
            this.pistaDataGridViewTextBoxColumn.DataPropertyName = "Pista";
            this.pistaDataGridViewTextBoxColumn.HeaderText = "Pista";
            this.pistaDataGridViewTextBoxColumn.Name = "pistaDataGridViewTextBoxColumn";
            this.pistaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDPalabraDataGridViewTextBoxColumn
            // 
            this.iDPalabraDataGridViewTextBoxColumn.DataPropertyName = "ID_Palabra";
            this.iDPalabraDataGridViewTextBoxColumn.HeaderText = "ID_Palabra";
            this.iDPalabraDataGridViewTextBoxColumn.Name = "iDPalabraDataGridViewTextBoxColumn";
            this.iDPalabraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pistasBindingSource
            // 
            this.pistasBindingSource.DataMember = "Pistas";
            this.pistasBindingSource.DataSource = this.juegoDataSetBindingSource;
            // 
            // pistasTableAdapter
            // 
            this.pistasTableAdapter.ClearBeforeFill = true;
            // 
            // Guardado
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Ahorcado.Properties.Resources.descarga;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(516, 379);
            this.Controls.Add(this.gridviewpistas);
            this.Controls.Add(this.labeljugar);
            this.Controls.Add(this.labelpista);
            this.Controls.Add(this.labelpalabra);
            this.Controls.Add(this.gridviewpalabra);
            this.Controls.Add(this.coordenadas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBpista);
            this.Controls.Add(this.textBpalabra);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Guardado";
            this.Text = "Guardado de Datos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Guardado_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.palabrasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.juegoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.juegoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palabrasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palabrasBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palabrasBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewpalabra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewpistas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pistasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBpalabra;
        private System.Windows.Forms.TextBox textBpista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label coordenadas;
        private System.Windows.Forms.BindingSource juegoDataSetBindingSource;
        private JuegoDataSet juegoDataSet;
        private System.Windows.Forms.BindingSource palabrasBindingSource;
        private JuegoDataSetTableAdapters.PalabrasTableAdapter palabrasTableAdapter;
        private System.Windows.Forms.BindingSource palabrasBindingSource1;
        private System.Windows.Forms.BindingSource palabrasBindingSource2;
        private System.Windows.Forms.BindingSource palabrasBindingSource3;
        private System.Windows.Forms.DataGridView gridviewpalabra;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn palabraDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labelpalabra;
        private System.Windows.Forms.Label labelpista;
        private System.Windows.Forms.Label labeljugar;
        private System.Windows.Forms.DataGridView gridviewpistas;
        private System.Windows.Forms.BindingSource pistasBindingSource;
        private JuegoDataSetTableAdapters.PistasTableAdapter pistasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pistaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPalabraDataGridViewTextBoxColumn;
    }
}

