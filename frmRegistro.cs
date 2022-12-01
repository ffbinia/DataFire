using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryDataFire
{
    public partial class frmRegistro : Form
    {
        DataSet DS;
        OleDbCommand comando = new OleDbCommand("incendios");
        OleDbDataAdapter adaptIncendios;


        public frmRegistro(DataSet ds, OleDbDataAdapter adaptIncendios)
        {
            InitializeComponent();
            this.DS = ds;
            this.adaptIncendios = adaptIncendios;

        }        


        private void frmRegistro_Load(object sender, EventArgs e)
        {
            cmbRegistro.DisplayMember = "provincia";
            cmbRegistro.ValueMember = "numero";
            cmbRegistro.DataSource = DS.Tables["provincias"];

            txtTotal.Enabled =false;
            //nupRegistro.Minimum = 1993;
            nupRegistro.Maximum = 2022;

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Registrar();
        }


        public void Registrar()
        {
            try
            {
                if (txtNegligencia.Text != "" & cmbRegistro.Text != "" & txtDesconocido.Text != "" & txtNatural.Text != "" & txtIntencional.Text != "") {

                    
                    int total;
                    int año = (int)nupRegistro.Value;
                    string provincia = cmbRegistro.Text;
                    int negligencia = Convert.ToInt32(txtNatural.Text);
                    int desconocida = Convert.ToInt32(txtNegligencia.Text);
                    int natural = Convert.ToInt32(txtDesconocido.Text);
                    int intencional = Convert.ToInt32(txtIntencional.Text);

                    foreach(DataRow dr in DS.Tables["incendios"].Rows)
                    {
                        if (año.ToString() == dr["anio"].ToString() && provincia == dr["provincia"].ToString())
                        {
                            MessageBox.Show("DATO YA REGISTRADO, ELIJA OTRO AÑO O PROVINCIA");
                            break;
                        }
                        else
                        {
                            total = negligencia + desconocida + natural + intencional;

                            txtTotal.Text = total.ToString();

                            DataRow nuevaFila = DS.Tables["incendios"].NewRow();
                            nuevaFila["anio"] = año;
                            nuevaFila["provincia"] = provincia;
                            nuevaFila["total_numero"] = total;
                            nuevaFila["negligencia_numero"] = negligencia;
                            nuevaFila["desconocida_numero"] = desconocida;
                            nuevaFila["natural_numero"] = natural;
                            nuevaFila["intencional_numero"] = intencional;
                            DS.Tables["incendios"].Rows.Add(nuevaFila);

                            adaptIncendios.Update(DS, "incendios");

                            MessageBox.Show("Datos Cargados", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error: Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                string ruta = Application.StartupPath + "\\LogErrores.txt";
                StreamWriter sw = new StreamWriter(ruta, true);
                sw.WriteLine("-" + "Fecha:" + DateTime.Now + " Error: " + ex);
                sw.Close();
            }    
        }

        private void rdbDesconocida_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

            
        }
    }
}
