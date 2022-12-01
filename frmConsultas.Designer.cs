namespace pryDataFire
{
    partial class frmConsultas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.gpbTipoConsulta = new System.Windows.Forms.GroupBox();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.rdbProvincia = new System.Windows.Forms.RadioButton();
            this.rdbAño = new System.Windows.Forms.RadioButton();
            this.nudAño = new System.Windows.Forms.NumericUpDown();
            this.cmbGrafico = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvIncendios = new System.Windows.Forms.DataGridView();
            this.anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.negligencia_numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intencional_numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.natural_numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desconocida_numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chtGrafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gpbTipoGrafico = new System.Windows.Forms.GroupBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gpbTipoConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAño)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncendios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtGrafico)).BeginInit();
            this.gpbTipoGrafico.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbTipoConsulta
            // 
            this.gpbTipoConsulta.Controls.Add(this.cmbProvincia);
            this.gpbTipoConsulta.Controls.Add(this.rdbProvincia);
            this.gpbTipoConsulta.Controls.Add(this.rdbAño);
            this.gpbTipoConsulta.Controls.Add(this.nudAño);
            this.gpbTipoConsulta.Location = new System.Drawing.Point(12, 12);
            this.gpbTipoConsulta.Name = "gpbTipoConsulta";
            this.gpbTipoConsulta.Size = new System.Drawing.Size(302, 121);
            this.gpbTipoConsulta.TabIndex = 0;
            this.gpbTipoConsulta.TabStop = false;
            this.gpbTipoConsulta.Text = "Tipo de consulta";
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Location = new System.Drawing.Point(158, 71);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(121, 21);
            this.cmbProvincia.TabIndex = 3;
            // 
            // rdbProvincia
            // 
            this.rdbProvincia.AutoSize = true;
            this.rdbProvincia.Location = new System.Drawing.Point(6, 75);
            this.rdbProvincia.Name = "rdbProvincia";
            this.rdbProvincia.Size = new System.Drawing.Size(88, 17);
            this.rdbProvincia.TabIndex = 2;
            this.rdbProvincia.Text = "Por Provincia";
            this.rdbProvincia.UseVisualStyleBackColor = true;
            // 
            // rdbAño
            // 
            this.rdbAño.AutoSize = true;
            this.rdbAño.Location = new System.Drawing.Point(6, 31);
            this.rdbAño.Name = "rdbAño";
            this.rdbAño.Size = new System.Drawing.Size(63, 17);
            this.rdbAño.TabIndex = 1;
            this.rdbAño.Text = "Por Año";
            this.rdbAño.UseVisualStyleBackColor = true;
            // 
            // nudAño
            // 
            this.nudAño.Location = new System.Drawing.Point(158, 28);
            this.nudAño.Name = "nudAño";
            this.nudAño.Size = new System.Drawing.Size(59, 20);
            this.nudAño.TabIndex = 0;
            // 
            // cmbGrafico
            // 
            this.cmbGrafico.FormattingEnabled = true;
            this.cmbGrafico.Location = new System.Drawing.Point(84, 51);
            this.cmbGrafico.Name = "cmbGrafico";
            this.cmbGrafico.Size = new System.Drawing.Size(121, 21);
            this.cmbGrafico.TabIndex = 4;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(633, 12);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(124, 54);
            this.btnConsultar.TabIndex = 5;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(633, 132);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(124, 54);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvIncendios
            // 
            this.dgvIncendios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncendios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.anio,
            this.provincia,
            this.total_numero,
            this.negligencia_numero,
            this.intencional_numero,
            this.natural_numero,
            this.desconocida_numero});
            this.dgvIncendios.Location = new System.Drawing.Point(12, 139);
            this.dgvIncendios.Name = "dgvIncendios";
            this.dgvIncendios.Size = new System.Drawing.Size(615, 174);
            this.dgvIncendios.TabIndex = 7;
            // 
            // anio
            // 
            this.anio.HeaderText = "anio";
            this.anio.Name = "anio";
            // 
            // provincia
            // 
            this.provincia.HeaderText = "provincia";
            this.provincia.Name = "provincia";
            // 
            // total_numero
            // 
            this.total_numero.HeaderText = "total_numero";
            this.total_numero.Name = "total_numero";
            // 
            // negligencia_numero
            // 
            this.negligencia_numero.HeaderText = "negligencia_numero";
            this.negligencia_numero.Name = "negligencia_numero";
            // 
            // intencional_numero
            // 
            this.intencional_numero.HeaderText = "intencional_numero";
            this.intencional_numero.Name = "intencional_numero";
            // 
            // natural_numero
            // 
            this.natural_numero.HeaderText = "natural_numero";
            this.natural_numero.Name = "natural_numero";
            // 
            // desconocida_numero
            // 
            this.desconocida_numero.HeaderText = "desconocida_numero";
            this.desconocida_numero.Name = "desconocida_numero";
            // 
            // chtGrafico
            // 
            chartArea3.AxisX.Crossing = -1.7976931348623157E+308D;
            chartArea3.AxisX.LineWidth = 0;
            chartArea3.AxisX.LogarithmBase = 5D;
            chartArea3.AxisX.ScaleBreakStyle.BreakLineStyle = System.Windows.Forms.DataVisualization.Charting.BreakLineStyle.Wave;
            chartArea3.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea3.CursorX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea3.Name = "ChartArea1";
            this.chtGrafico.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chtGrafico.Legends.Add(legend3);
            this.chtGrafico.Location = new System.Drawing.Point(12, 319);
            this.chtGrafico.Name = "chtGrafico";
            this.chtGrafico.Size = new System.Drawing.Size(615, 358);
            this.chtGrafico.TabIndex = 8;
            this.chtGrafico.Text = "chart1";
            title3.Name = "hola";
            this.chtGrafico.Titles.Add(title3);
            // 
            // gpbTipoGrafico
            // 
            this.gpbTipoGrafico.Controls.Add(this.cmbGrafico);
            this.gpbTipoGrafico.Location = new System.Drawing.Point(320, 12);
            this.gpbTipoGrafico.Name = "gpbTipoGrafico";
            this.gpbTipoGrafico.Size = new System.Drawing.Size(307, 121);
            this.gpbTipoGrafico.TabIndex = 9;
            this.gpbTipoGrafico.TabStop = false;
            this.gpbTipoGrafico.Text = "Tipo de Grafico";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(633, 72);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(124, 54);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 689);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.gpbTipoGrafico);
            this.Controls.Add(this.chtGrafico);
            this.Controls.Add(this.dgvIncendios);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gpbTipoConsulta);
            this.Name = "frmConsultas";
            this.Text = "Consulta de incendios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmConsultas_Load);
            this.gpbTipoConsulta.ResumeLayout(false);
            this.gpbTipoConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAño)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncendios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtGrafico)).EndInit();
            this.gpbTipoGrafico.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbTipoConsulta;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.RadioButton rdbProvincia;
        private System.Windows.Forms.RadioButton rdbAño;
        private System.Windows.Forms.NumericUpDown nudAño;
        private System.Windows.Forms.ComboBox cmbGrafico;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvIncendios;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtGrafico;
        private System.Windows.Forms.GroupBox gpbTipoGrafico;
        private System.Windows.Forms.DataGridViewTextBoxColumn anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn provincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn negligencia_numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn intencional_numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn natural_numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn desconocida_numero;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Timer timer1;
    }
}

