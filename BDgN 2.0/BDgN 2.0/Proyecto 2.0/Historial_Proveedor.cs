using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;

namespace WindowsFormsApplication1
{
    public partial class Historial_Proveedor : Form
    {
        public Historial_Proveedor()
        {
            InitializeComponent();
        }
        private SqlDataAdapter da;
        private DataTable dt = new DataTable();
        Boolean ini=false;
        Boolean fin=false;

        private void Historial_Proveedor_Load(object sender, EventArgs e)
        {
            rtb.Text = TextoAyuda.Historial_Proveedor;
            fecha_ini.Mask = "aa-aa-aaaa";
            fecha_fin.Mask = "aa-aa-aaaa";
        }

        private void Salir_Click_1(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            if (ini && fin)
            {
                dt.Clear();
                using (SqlConnection con = new SqlConnection("Server=localhost; database=INVERSEC_3; integrated security=yes"))
                {
                    try
                    {


                        SqlCommand comando = new SqlCommand("SELECT p.nombre Nombre,p.rut_emp Rut,f.numero_fact Factura,f.fecha,sum(fb.cantidad) Cantidad,f.total Total FROM PROVEEDOR p join FACTURA f on p.rut_emp=f.rut_pro and f.guia='factura' join FACT_PRODUCTO fb on fb.num_fact=f.num_fact and  f.fecha  between @fechaini and @fechafin group by p.nombre,p.rut_emp,f.numero_fact,f.fecha,f.total ", con);
                        comando.Parameters.Add("@fechaini", SqlDbType.Date);
                        comando.Parameters["@fechaini"].Value = fecha_ini.Text;
                        comando.Parameters.Add("@fechafin", SqlDbType.Date);
                        comando.Parameters["@fechafin"].Value = fecha_fin.Text;


                        da = new SqlDataAdapter(comando);

                        da.Fill(dt);


                        int suma = 0;

                        if (dt.Rows.Count > 0)
                        {
                            DataRowCollection dtr = dt.Rows;
                            foreach (DataRow r in dtr)
                            {
                                suma = Convert.ToInt32(r["total"]) + suma;
                            }
                            total.Text = suma.ToString();
                            dgv.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("No se encontro Facturas");
                        }
                        con.Close();

                    }
                    catch (Exception ev)
                    {
                        MessageBox.Show("Error: " + ev.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar dos fechas para buscar una factura");
            }
        }

        private void Historial_Proveedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void fecha_ini_Validated(object sender, EventArgs e)
        {
            DateTime a;
            if (!DateTime.TryParse(fecha_ini.Text, out a))
            {
                fecha_ini.Text = "";
                ini = false;
                MessageBox.Show("Fecha ingresada no es valida", "ERRORRRRSSSS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ini = true;
            }
        }

        private void fecha_fin_Validated(object sender, EventArgs e)
        {
            DateTime a;
            if (!DateTime.TryParse(fecha_fin.Text, out a))
            {
                fecha_fin.Text = "";
                fin = false;
                MessageBox.Show("Fecha ingresada no es valida", "ERRORRRRSSSS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                fin = true;
            }
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FacturaProveedor fp = new FacturaProveedor();
            fp.rut=dgv.CurrentRow.Cells[1].Value.ToString();
            fp.numerof = Convert.ToInt32(dgv.CurrentRow.Cells[2].Value.ToString());
            this.AddOwnedForm(fp);
            fp.Hide();
            fp.Show();
        }

        private void Historial_Proveedor_Paint(object sender, PaintEventArgs e)
        {
            Rectangle fromcolor = new Rectangle(0, 0, this.Width, this.Height);
            Brush gbrush = new LinearGradientBrush(fromcolor, Color.Gold, Color.Maroon, LinearGradientMode.Vertical);
            e.Graphics.FillRectangle(gbrush, fromcolor);
        }

        private void Buscar_MouseMove(object sender, MouseEventArgs e)
        {
            Buscar.BackColor = Color.Maroon;
        }

        private void Buscar_MouseLeave(object sender, EventArgs e)
        {
            Buscar.BackColor = Color.White;
        }

        private void Salir_MouseMove(object sender, MouseEventArgs e)
        {
            Salir.BackColor = Color.Maroon;
        }

        private void Salir_MouseLeave(object sender, EventArgs e)
        {
            Salir.BackColor = Color.White;
        }

       

    }
}
