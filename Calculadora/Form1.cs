using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Font;
using iText.IO.Font.Constants;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private Conexion con;
        private Metodos metodos;
        private SqlDataReader registro;
        private SqlConnection conexion;
        string s = System.Configuration.ConfigurationManager.ConnectionStrings["conectar1"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) //al iniciar carga el DataGridView con los datos
        {
            this.con = new Conexion();
            this.con.conectar();
            string consulta = "select * from mensual;";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, s);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            DGVMes.AutoGenerateColumns= false;
            DataGridViewColumn cID = new DataGridViewTextBoxColumn();
            cID.DataPropertyName = "id";
            cID.HeaderText = "ID";
            DGVMes.Columns.Add(cID);
            DataGridViewColumn cAnio = new DataGridViewTextBoxColumn();
            cAnio.DataPropertyName = "anio";
            cAnio.HeaderText = "Año";
            DGVMes.Columns.Add(cAnio);
            DataGridViewColumn cMes = new DataGridViewTextBoxColumn();
            cMes.DataPropertyName = "mes";
            cMes.HeaderText = "Mes";
            DGVMes.Columns.Add(cMes);
            DataGridViewColumn cArboles = new DataGridViewTextBoxColumn();
            cArboles.DataPropertyName = "arboles";
            cArboles.HeaderText = "Árboles Salvados";
            DGVMes.Columns.Add(cArboles);
            DataGridViewColumn cAgua = new DataGridViewTextBoxColumn();
            cAgua.DataPropertyName = "agua";
            cAgua.HeaderText = "Litros de Agua Ahorrados";
            DGVMes.Columns.Add(cAgua);
            DataGridViewColumn cKWH = new DataGridViewTextBoxColumn();
            cKWH.DataPropertyName = "kwh";
            cKWH.HeaderText = "KWH de Energía Ahorrados";
            DGVMes.Columns.Add(cKWH);
            DataGridViewColumn cRelleno = new DataGridViewTextBoxColumn();
            cRelleno.DataPropertyName = "relleno";
            cRelleno.HeaderText = "Espacio de relleno sanitario ahorrado";
            DGVMes.Columns.Add(cRelleno);
            DataGridViewColumn cCO2 = new DataGridViewTextBoxColumn();
            cCO2.DataPropertyName = "co2";
            cCO2.HeaderText = "Toneladas de CO2 Ahorrado";
            DGVMes.Columns.Add(cCO2);
            DataGridViewColumn cPetroleo = new DataGridViewTextBoxColumn();
            cPetroleo.DataPropertyName = "petroleo";
            cPetroleo.HeaderText = "Litros de Petroleo Ahorrados";
            DGVMes.Columns.Add(cPetroleo);
            DataGridViewColumn cBauxita = new DataGridViewTextBoxColumn();
            cBauxita.DataPropertyName = "bauxita";
            cBauxita.HeaderText = "Toneladas de Bauxita Ahorrados";
            DGVMes.Columns.Add(cBauxita);
            DataGridViewColumn cKG = new DataGridViewTextBoxColumn();
            cKG.DataPropertyName = "kg";
            cKG.HeaderText = "Total en Kilos";
            DGVMes.Columns.Add(cKG);
            DGVMes.DataSource = dt;
        }

        public void TBPyC_KeyPress(object sender, KeyPressEventArgs e) //Verifica que solo haya numeros en el textbox
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void TBAyE_KeyPress(object sender, KeyPressEventArgs e) //Verifica que solo haya numeros en el textbox
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void TBPET_KeyPress(object sender, KeyPressEventArgs e) //Verifica que solo haya numeros en el textbox
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void TBPIDEliminar_KeyPress(object sender, KeyPressEventArgs e) //Verifica que solo haya numeros en el textbox
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public (int arb, int lit, int kw, int rel, int co, int petro, int bau, int kil) Calculos() //Hace los calculos con los datos introducidos
        {
            string vt1 = TBPyC.Text;
            string vt2 = TBAyE.Text;
            string vt3 = TBPET.Text;
            int v1, v2, v3;
            if (string.IsNullOrEmpty(vt1))
            {
                v1 = 0;
            }
            else
            {
                v1 = int.Parse(TBPyC.Text);
            }
            if (string.IsNullOrEmpty(vt2))
            {
                v2 = 0;
            }
            else
            {
                v2 = int.Parse(TBAyE.Text);
            }
            if (string.IsNullOrEmpty(vt3))
            {
                v3 = 0;
            }
            else
            {
                v3 = int.Parse(TBPET.Text);
            }
            int arb = (int)(v1 * 0.0017);
            int lit = (int)((v1 * 27) + (v2 * 91.2) + (v3 * 40));
            int kw = (int)((v1 * 4.1) + (v2 * 14.63) + (v3 * 5.04));
            int rel = (int)((v1 * 0.0024) + (v2 * 0.0057) + (v3 * 0.0054));
            int co = (int)((v1 * 0.0033) + (v2 * 0.0015) + (v3 * 0.0017));
            int petro = (int)(v3 * 1.431);
            int bau = (int)(v2 * 0.004);
            int kil = v1 + v2 + v3;
            return (arb, lit, kw, rel, co, petro, bau, kil);
        }

        private void btnGuardar_Click(object sender, EventArgs e) //Guarda los datos en la base de datos
        {
            int anio = Convert.ToInt32(NUDAnio.Value);
            int mes = Convert.ToInt32(NUDMes.Value);
            int arb, lit, kw, rel, co, petro, bau, kil;
            (arb, lit, kw, rel, co, petro, bau, kil) = Calculos();
            this.conexion = new SqlConnection(s);
            this.conexion.Open();
            String sql = "insert into mensual " + "values" + "('" + anio + "','" + mes + "','" + arb + "','" + lit + "','" + kw + "','" + rel + "','" + co + "','" + petro + "','" + bau + "','" + kil + "')";
            SqlCommand comando = new SqlCommand(sql,this.conexion);
            comando.ExecuteNonQuery();
            this.conexion.Close();
            Process.Start(Application.ExecutablePath);
            Application.Exit();
        }

        private void btnEliminar_Click(object sender, EventArgs e) //elimina los datos de la ID seleccionada
        {
            int id = int.Parse(TBIDEliminar.Text);
            this.conexion = new SqlConnection(s);
            this.conexion.Open();
            String sql = "delete from mensual where id ='" + id + "'";
            SqlCommand comando = new SqlCommand(sql, this.conexion);
            comando.ExecuteNonQuery();
            this.conexion.Close();
            Process.Start(Application.ExecutablePath);
            Application.Exit();
        }

        private void btnRepMensual_Click(object sender, EventArgs e)
        {
            int anio = Convert.ToInt32(NUDanioRepMen.Value);
            int mes = Convert.ToInt32(NUDmesRepMen.Value);
            this.conexion = new SqlConnection(s);
            this.conexion.Open();
            string sql = string.Format("INSERT INTO RepMensual (anio, mes, arboles, agua, kwh, relleno, co2, petroleo, bauxita, kg) " +
                             "SELECT anio =" + anio+ ", mes =" +mes + ", " + "SUM(arboles), SUM(agua), SUM(kwh), SUM(relleno), SUM(co2), SUM(petroleo), SUM(bauxita), SUM(kg) " +
                             "FROM mensual " +
                             "WHERE anio = " + anio + " AND mes = " + mes +
                             "GROUP BY anio, mes;");
            SqlCommand comando = new SqlCommand(sql, this.conexion);
            comando.ExecuteNonQuery();
            this.conexion.Close();
            Process.Start(Application.ExecutablePath);
            Application.Exit();
        }//guarda el reporte mensual

        private void btnRepAnual_Click(object sender, EventArgs e)
        {
            int anio = Convert.ToInt32(nudRepAnual.Value);
            this.conexion = new SqlConnection(s);
            this.conexion.Open();
            string sql = string.Format("INSERT INTO RepAnual (anio, mes, arboles, agua, kwh, relleno, co2, petroleo, bauxita, kg) " +
                             "SELECT anio =" + anio + ", SUM(mes), " + "SUM(arboles), SUM(agua), SUM(kwh), SUM(relleno), SUM(co2), SUM(petroleo), SUM(bauxita), SUM(kg) " +
                             "FROM mensual " +
                             "WHERE anio = " + anio +
                             "GROUP BY anio;");
            SqlCommand comando = new SqlCommand(sql, this.conexion);
            comando.ExecuteNonQuery();
            this.conexion.Close();
            Process.Start(Application.ExecutablePath);
            Application.Exit();
        }//guarda el reporte anual

        private void generarRepMen_Click(object sender, EventArgs e)
        {
            int anio = Convert.ToInt32(NUDanioRepMen.Value);
            int mes = Convert.ToInt32(NUDmesRepMen.Value);
            this.conexion = new SqlConnection(s);
            string query = "SELECT anio as 'Año', mes as 'Mes', arboles as 'Árboles salvados', agua as 'Litros de agua ahorrados', kwh as 'KWH de energía ahorrados', relleno as 'Espacio de relleno sanitario ahorrados', co2 as 'Toneladas de CO2 ahorrados', petroleo as 'Litros de petroleo ahorrado', bauxita as 'Toneladas de bauxita ahorradas', kg as 'Total en kilos' from RepMensual where anio = " + anio + " and mes = " + mes + " and id=(SELECT MAX(Id) from RepMensual)";
            using (SqlConnection connection = new SqlConnection(s))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivo PDF (*.pdf)|*.pdf";
                saveFileDialog.Title = "Guardar archivo PDF";
                saveFileDialog.ShowDialog();
                if (saveFileDialog.FileName != "")
                {
                    PdfWriter writer = new PdfWriter(saveFileDialog.FileName);
                    PdfDocument pdfDocument = new PdfDocument(writer);
                    Document document = new Document(pdfDocument);
                    Paragraph header = new Paragraph("Reporte Mensual").SetFont(PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD))
                .SetFontSize(24)
                .SetTextAlignment(TextAlignment.CENTER);
                    document.Add(header);
                    document.Add(new Paragraph("\n"));
                    iText.Layout.Element.Table table = new iText.Layout.Element.Table(dataTable.Columns.Count);
                    foreach (DataColumn column in dataTable.Columns)
                    {
                        table.AddHeaderCell(new Cell().Add(new Paragraph(column.Caption)));
                    }
                    foreach (DataRow row in dataTable.Rows)
                    {
                        foreach (DataColumn column in dataTable.Columns)
                        {
                            table.AddCell(new Cell().Add(new Paragraph(row[column].ToString())));
                        }
                    }
                    document.Add(table);
                    document.Close();
                    MessageBox.Show("El archivo se guardó correctamente en la ubicación: " + saveFileDialog.FileName);
                }
            }
        }//genera el reporte mensual en pdf

        private void generarRepAnual_Click(object sender, EventArgs e)
        {
            int anio = Convert.ToInt32(nudRepAnual.Value);
            this.conexion = new SqlConnection(s);
            string query = "SELECT anio as 'Año', arboles as 'Árboles salvados', agua as 'Litros de agua ahorrados', kwh as 'KWH de energía ahorrados', relleno as 'Espacio de relleno sanitario ahorrados', co2 as 'Toneladas de CO2 ahorrados', petroleo as 'Litros de petroleo ahorrado', bauxita as 'Toneladas de bauxita ahorradas', kg as 'Total en kilos' from RepAnual where anio = " + anio + "and id=(SELECT MAX(Id) from RepAnual)";
            using (SqlConnection connection = new SqlConnection(s))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivo PDF (*.pdf)|*.pdf";
                saveFileDialog.Title = "Guardar archivo PDF";
                saveFileDialog.ShowDialog();
                if (saveFileDialog.FileName != "")
                {
                    PdfWriter writer = new PdfWriter(saveFileDialog.FileName);
                    PdfDocument pdfDocument = new PdfDocument(writer);
                    Document document = new Document(pdfDocument);
                    Paragraph header = new Paragraph("Reporte Anual").SetFont(PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD))
                .SetFontSize(24)
                .SetTextAlignment(TextAlignment.CENTER);
                    document.Add(header);
                    document.Add(new Paragraph("\n"));
                    iText.Layout.Element.Table table = new iText.Layout.Element.Table(dataTable.Columns.Count);
                    foreach (DataColumn column in dataTable.Columns)
                    {
                        table.AddHeaderCell(new Cell().Add(new Paragraph(column.Caption)));
                    }
                    foreach (DataRow row in dataTable.Rows)
                    {
                        foreach (DataColumn column in dataTable.Columns)
                        {
                            table.AddCell(new Cell().Add(new Paragraph(row[column].ToString())));
                        }
                    }
                    document.Add(table);
                    document.Close();
                    MessageBox.Show("El archivo se guardó correctamente en la ubicación: " + saveFileDialog.FileName);
                }
            }
        }//genera el reporte anual en pdf
    }
}
