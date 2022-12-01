namespace pryDataFire
{
    partial class frmRegistro
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.lblProv = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblNeglig = new System.Windows.Forms.Label();
            this.lblNatu = new System.Windows.Forms.Label();
            this.lblDesconocida = new System.Windows.Forms.Label();
            this.nupRegistro = new System.Windows.Forms.NumericUpDown();
            this.cmbRegistro = new System.Windows.Forms.ComboBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.gpbMotivo = new System.Windows.Forms.GroupBox();
            this.txtIntencional = new System.Windows.Forms.TextBox();
            this.txtDesconocido = new System.Windows.Forms.TextBox();
            this.txtNegligencia = new System.Windows.Forms.TextBox();
            this.txtNatural = new System.Windows.Forms.TextBox();
            this.lblIntencional = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nupRegistro)).BeginInit();
            this.gpbMotivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(64, 26);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(264, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Registro de incendios";
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.Location = new System.Drawing.Point(75, 107);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(32, 13);
            this.lblRegistro.TabIndex = 1;
            this.lblRegistro.Text = "Año";
            // 
            // lblProv
            // 
            this.lblProv.AutoSize = true;
            this.lblProv.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProv.Location = new System.Drawing.Point(75, 145);
            this.lblProv.Name = "lblProv";
            this.lblProv.Size = new System.Drawing.Size(68, 13);
            this.lblProv.TabIndex = 2;
            this.lblProv.Text = "Provincia";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(75, 326);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(40, 13);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total";
            // 
            // lblNeglig
            // 
            this.lblNeglig.AutoSize = true;
            this.lblNeglig.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNeglig.Location = new System.Drawing.Point(13, 52);
            this.lblNeglig.Name = "lblNeglig";
            this.lblNeglig.Size = new System.Drawing.Size(83, 13);
            this.lblNeglig.TabIndex = 4;
            this.lblNeglig.Text = "Negligencia";
            // 
            // lblNatu
            // 
            this.lblNatu.AutoSize = true;
            this.lblNatu.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNatu.Location = new System.Drawing.Point(13, 23);
            this.lblNatu.Name = "lblNatu";
            this.lblNatu.Size = new System.Drawing.Size(55, 13);
            this.lblNatu.TabIndex = 5;
            this.lblNatu.Text = "Natural";
            // 
            // lblDesconocida
            // 
            this.lblDesconocida.AutoSize = true;
            this.lblDesconocida.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesconocida.Location = new System.Drawing.Point(13, 81);
            this.lblDesconocida.Name = "lblDesconocida";
            this.lblDesconocida.Size = new System.Drawing.Size(89, 13);
            this.lblDesconocida.TabIndex = 6;
            this.lblDesconocida.Text = "Desconocido";
            // 
            // nupRegistro
            // 
            this.nupRegistro.Location = new System.Drawing.Point(178, 100);
            this.nupRegistro.Name = "nupRegistro";
            this.nupRegistro.Size = new System.Drawing.Size(51, 20);
            this.nupRegistro.TabIndex = 7;
            // 
            // cmbRegistro
            // 
            this.cmbRegistro.FormattingEnabled = true;
            this.cmbRegistro.Location = new System.Drawing.Point(178, 137);
            this.cmbRegistro.Name = "cmbRegistro";
            this.cmbRegistro.Size = new System.Drawing.Size(121, 21);
            this.cmbRegistro.TabIndex = 12;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(178, 319);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(121, 20);
            this.txtTotal.TabIndex = 13;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(224, 356);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 14;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(118, 356);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 15;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // gpbMotivo
            // 
            this.gpbMotivo.Controls.Add(this.txtIntencional);
            this.gpbMotivo.Controls.Add(this.txtDesconocido);
            this.gpbMotivo.Controls.Add(this.txtNegligencia);
            this.gpbMotivo.Controls.Add(this.txtNatural);
            this.gpbMotivo.Controls.Add(this.lblIntencional);
            this.gpbMotivo.Controls.Add(this.lblNeglig);
            this.gpbMotivo.Controls.Add(this.lblNatu);
            this.gpbMotivo.Controls.Add(this.lblDesconocida);
            this.gpbMotivo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbMotivo.Location = new System.Drawing.Point(78, 168);
            this.gpbMotivo.Name = "gpbMotivo";
            this.gpbMotivo.Size = new System.Drawing.Size(221, 142);
            this.gpbMotivo.TabIndex = 16;
            this.gpbMotivo.TabStop = false;
            this.gpbMotivo.Text = "Motivo";
            // 
            // txtIntencional
            // 
            this.txtIntencional.Location = new System.Drawing.Point(107, 108);
            this.txtIntencional.Name = "txtIntencional";
            this.txtIntencional.Size = new System.Drawing.Size(65, 23);
            this.txtIntencional.TabIndex = 16;
            // 
            // txtDesconocido
            // 
            this.txtDesconocido.Location = new System.Drawing.Point(107, 78);
            this.txtDesconocido.Name = "txtDesconocido";
            this.txtDesconocido.Size = new System.Drawing.Size(65, 23);
            this.txtDesconocido.TabIndex = 15;
            // 
            // txtNegligencia
            // 
            this.txtNegligencia.Location = new System.Drawing.Point(107, 45);
            this.txtNegligencia.Name = "txtNegligencia";
            this.txtNegligencia.Size = new System.Drawing.Size(65, 23);
            this.txtNegligencia.TabIndex = 14;
            // 
            // txtNatural
            // 
            this.txtNatural.Location = new System.Drawing.Point(107, 16);
            this.txtNatural.Name = "txtNatural";
            this.txtNatural.Size = new System.Drawing.Size(65, 23);
            this.txtNatural.TabIndex = 13;
            this.txtNatural.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtNatural.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lblIntencional
            // 
            this.lblIntencional.AutoSize = true;
            this.lblIntencional.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntencional.Location = new System.Drawing.Point(13, 111);
            this.lblIntencional.Name = "lblIntencional";
            this.lblIntencional.Size = new System.Drawing.Size(81, 13);
            this.lblIntencional.TabIndex = 12;
            this.lblIntencional.Text = "Intencional";
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 391);
            this.Controls.Add(this.gpbMotivo);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.cmbRegistro);
            this.Controls.Add(this.nupRegistro);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblProv);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmRegistro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.frmRegistro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupRegistro)).EndInit();
            this.gpbMotivo.ResumeLayout(false);
            this.gpbMotivo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.Label lblProv;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblNeglig;
        private System.Windows.Forms.Label lblNatu;
        private System.Windows.Forms.Label lblDesconocida;
        private System.Windows.Forms.NumericUpDown nupRegistro;
        private System.Windows.Forms.ComboBox cmbRegistro;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.GroupBox gpbMotivo;
        private System.Windows.Forms.Label lblIntencional;
        private System.Windows.Forms.TextBox txtNatural;
        private System.Windows.Forms.TextBox txtIntencional;
        private System.Windows.Forms.TextBox txtDesconocido;
        private System.Windows.Forms.TextBox txtNegligencia;
    }
}