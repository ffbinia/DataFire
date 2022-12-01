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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;

namespace pryDataFire
{
    public partial class frmConsultas : Form
    {

       private DataSet DS;
       private OleDbDataAdapter adaptIncendios;

        public frmConsultas()
        {
            InitializeComponent();
        }

        private void frmConsultas_Load(object sender, EventArgs e)
        {
            CargarBD();
            cmbGrafico.Items.Add("Grafico de columnas");
            cmbGrafico.Items.Add("Grafico de lineas");
            cmbGrafico.SelectedIndex = 0;

            rdbAño.Checked = true;
            nudAño.Minimum = 1993;
            nudAño.Maximum = 2022;
        }


        private void CargarBD()
        {
            try
            {
                DS = new DataSet();


                OleDbConnection conex = new OleDbConnection();
                string ruta = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =" + Application.StartupPath + "\\Incendios.mdb";
                conex.ConnectionString = ruta;

                conex.Open();

                //TABLA INCENDIOS
                OleDbCommand cmdIncendios = new OleDbCommand();
                cmdIncendios.Connection = conex;
                cmdIncendios.CommandType = CommandType.TableDirect;
                cmdIncendios.CommandText = "incendios";
                adaptIncendios = new OleDbDataAdapter(cmdIncendios);
                adaptIncendios.Fill(DS, "incendios");
                //CLAVE PRIMARIA
                DataColumn[] dcI = new DataColumn[2];
                dcI[0] = DS.Tables["incendios"].Columns["anio"];
                dcI[1] = DS.Tables["incendios"].Columns["provincia"];
                DS.Tables["incendios"].PrimaryKey = dcI;
                //CREO COMMANDBUILDER PARA REALIZAR CAMBIOS EN LA TABLA
                OleDbCommandBuilder cbIncendios = new OleDbCommandBuilder(adaptIncendios);


                //TABLA PROVINCIAS
                OleDbCommand cmdProvincias = new OleDbCommand();
                cmdProvincias.Connection = conex;
                cmdProvincias.CommandType = CommandType.TableDirect;
                cmdProvincias.CommandText = "Provincias";
                OleDbDataAdapter adaptProvincias = new OleDbDataAdapter(cmdProvincias);
                adaptProvincias.Fill(DS, "Provincias");
                //CLAVE PRIMARIA
                DataColumn[] dcP = new DataColumn[1];
                dcP[0] = DS.Tables["provincias"].Columns["numero"];
                DS.Tables["provincias"].PrimaryKey = dcP;


                cmbProvincia.DisplayMember = "provincia";
                cmbProvincia.ValueMember = "numero";
                cmbProvincia.DataSource = DS.Tables["provincias"];


                
                foreach(DataRow dr in DS.Tables["incendios"].Rows)
                {
                    dgvIncendios.Rows.Add(dr["anio"], dr["provincia"],
                    dr["total_numero"], dr["negligencia_numero"],
                    dr["intencional_numero"], dr["natural_numero"],
                    dr["desconocida_numero"]);
                }

                conex.Close();
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


        private void Validaciones()
        {
            int año = (int)nudAño.Value;
            string provincia = cmbProvincia.Text;


            try
                {

                if (rdbAño.Checked == true)
                {
                    dgvIncendios.Rows.Clear();
                    foreach (DataRow dr in DS.Tables["incendios"].Rows)
                    {
                        if (int.Parse(dr["anio"].ToString()) == año)
                        {
                            dgvIncendios.Rows.Add(dr["anio"], dr["provincia"],
                            dr["total_numero"], dr["negligencia_numero"],
                            dr["intencional_numero"], dr["natural_numero"],
                            dr["desconocida_numero"]);
                        }
                    }
                } }
                    catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    string ruta = Application.StartupPath + "\\LogErrores.txt";


                    StreamWriter sw = new StreamWriter(ruta, true);
                    sw.WriteLine("-" + "Fecha:" + DateTime.Now + " Error: " + ex);
                    sw.Close();
                }
            

            if (rdbProvincia.Checked == true)
            {
                dgvIncendios.Rows.Clear();
                try
                {
                    foreach (DataRow dr in DS.Tables["incendios"].Rows)
                    {
                        if ((dr["provincia"].ToString()) == provincia)
                        {
                            dgvIncendios.Rows.Add(dr["anio"], dr["provincia"],
                            dr["total_numero"], dr["negligencia_numero"],
                            dr["intencional_numero"], dr["natural_numero"],
                            dr["desconocida_numero"]);
                        }
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
        }

        private void CargarGraficoDeColumnas()
        {
            int año = (int)(nudAño.Value);
            string provincia = cmbProvincia.Text;
            try
            {
                if (cmbGrafico.Text == "Grafico de columnas")
                {

                    if (rdbAño.Checked == true)
                    {
                        DataTable dt = new DataTable();
                        dt.Columns.Add("total_numero");
                        dt.Columns.Add("provincia");

                        foreach (DataRow dr in DS.Tables["incendios"].Rows)
                        {
                            if (año.ToString() == dr["anio"].ToString())
                            {
                                DataRow nuevo = dt.NewRow();
                                nuevo["total_numero"] = dr["total_numero"].ToString();
                                nuevo["provincia"] = dr["provincia"].ToString();
                                dt.Rows.Add(nuevo);
                            }
                        }
                        chtGrafico.Series.Clear();

                        chtGrafico.Titles.Clear();
                        chtGrafico.Titles.Add("Grafico de incendios del año: " + año);
                        chtGrafico.Series.Add(año.ToString());
                        chtGrafico.ChartAreas["ChartArea1"].AxisX.LabelStyle.Angle = 90;
                        chtGrafico.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                        chtGrafico.ChartAreas["ChartArea1"].AxisY.Interval = 500;
                        chtGrafico.ChartAreas["ChartArea1"].AxisY.Maximum = 5000;

                        chtGrafico.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                        chtGrafico.DataBindTable(dt.DefaultView, "provincia");
                    }
                    else if (rdbProvincia.Checked == true)
                    {

                        DataTable dt = new DataTable();
                        dt.Columns.Add("total_numero");
                        dt.Columns.Add("anio");


                        foreach (DataRow dr in DS.Tables["incendios"].Rows)
                        {
                            if (provincia.ToString() == dr["provincia"].ToString())
                            {
                                DataRow nuevo = dt.NewRow();
                                nuevo["total_numero"] = dr["total_numero"].ToString();
                                nuevo["anio"] = dr["anio"].ToString();
                                dt.Rows.Add(nuevo);
                            }

                            chtGrafico.Series.Clear();

                            chtGrafico.Series.Add(provincia.ToString());
                            chtGrafico.DataBindTable(dt.DefaultView, "anio");
                            chtGrafico.Titles.Clear();
                            chtGrafico.Titles.Add("Grafico de incendios por año de la provincia de: " + provincia);
                            chtGrafico.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                            chtGrafico.ChartAreas["ChartArea1"].AxisX.LabelStyle.Angle = 90;
                            chtGrafico.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                            chtGrafico.ChartAreas["ChartArea1"].AxisY.Interval = 500;

                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                string ruta = Application.StartupPath + "\\LogErrores.txt";

                StreamWriter sw = new StreamWriter(ruta, true);
                sw.WriteLine("-" + "Fecha:" + DateTime.Now + " Error: " + ex);
                sw.Close();
            }
        }

        private void CargarGraficoDeLineas()
        {
            try
            {
                int año = (int)(nudAño.Value);
                string provincia = cmbProvincia.Text;
                if (cmbGrafico.Text == "Grafico de lineas")
                {
                    chtGrafico.Series.Clear();


                    if (rdbAño.Checked == true)
                    {

                        DataTable dt = new DataTable();
                        dt.Columns.Add("total_numero");
                        dt.Columns.Add("provincia");


                        foreach (DataRow dr in DS.Tables["incendios"].Rows)
                        {
                            if (año.ToString() == dr["anio"].ToString())
                            {
                                DataRow nuevo = dt.NewRow();
                                nuevo["total_numero"] = dr["total_numero"].ToString();
                                nuevo["provincia"] = dr["provincia"].ToString();
                                dt.Rows.Add(nuevo);
                            }
                        }
                        chtGrafico.DataBindTable(dt.DefaultView, "provincia");
                        chtGrafico.Series.Add(año.ToString());
                        chtGrafico.Titles.Clear();
                        chtGrafico.Titles.Add("Grafico de incendios por provincia ne el año: " + año);
                        chtGrafico.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                        chtGrafico.ChartAreas["ChartArea1"].AxisX.LabelStyle.Angle = 90;
                        chtGrafico.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                    }
                    else if(rdbProvincia.Checked == true)
                    {

                        DataTable dt = new DataTable();
                        dt.Columns.Add("total_numero");
                        dt.Columns.Add("anio");

                        foreach (DataRow dr in DS.Tables["incendios"].Rows)
                        {
                            if (provincia == dr["provincia"].ToString())
                            {
                                DataRow nuevo = dt.NewRow();
                                nuevo["total_numero"] = dr["total_numero"].ToString();
                                nuevo["anio"] = dr["anio"].ToString();
                                dt.Rows.Add(nuevo);
                            }
                            chtGrafico.Series.Clear();
                            chtGrafico.Series.Add(provincia.ToString());
                            chtGrafico.DataBindTable(dt.DefaultView, "anio");
                            chtGrafico.Titles.Clear();
                            chtGrafico.Titles.Add("Grafico de incendios por año de la provincia de: " + provincia);
                            chtGrafico.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                            chtGrafico.ChartAreas["ChartArea1"].AxisX.LabelStyle.Angle = 90;
                            chtGrafico.ChartAreas["ChartArea1"].AxisX.Interval = 1;

                        }

                    }
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Validaciones();
            CargarGraficoDeColumnas();
            CargarGraficoDeLineas();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmRegistro frm = new frmRegistro(DS, adaptIncendios);
            frm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dgvIncendios.Rows.Clear();
            CargarBD();
        }
    }
}
