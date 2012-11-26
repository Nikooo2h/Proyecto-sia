using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Drawing.Drawing2D;

namespace WindowsFormsApplication1
{
    public partial class FacturaProveedor : Form
    {
        public FacturaProveedor()
        {
            InitializeComponent();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void FacturaProveedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }
        public String rut;
        public int numerof;
        private void FacturaProveedor_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Server=localhost; database=INVERSEC_3; integrated security=yes"))
            {
                SqlCommand comando;
                SqlDataAdapter da;
                DataRowCollection DTR;
                try
                {

                    comando = new SqlCommand("select p.titular,p.rut_emp,p.nombre,g.nombre giro,p.direccion,p.fono,p.fax,p.e_mail FROM PROVEEDOR p,giro g WHERE p.rut_emp=@rut AND p.codigo_giro=g.codigo", con);
                    comando.Parameters.Add("@rut", SqlDbType.VarChar);
                    comando.Parameters["@rut"].Value = rut;
                    da = new SqlDataAdapter(comando);
                    DataTable dtproveedor = new DataTable();
                    DataTable dtfactura = new DataTable();
                    DataTable dtfp = new DataTable();

                    da.Fill(dtproveedor);
                    DTR = dtproveedor.Rows;
                    foreach (DataRow r in DTR)
                    {
                        titular_p.Text = r["titular"].ToString();
                        rut_p.Text = r["rut_emp"].ToString();
                        nombre_p.Text = r["nombre"].ToString();
                        direccion_p.Text = r["direccion"].ToString();
                        fono_p.Text = r["fono"].ToString();
                        fax_p.Text = r["fax"].ToString();
                        email_p.Text = r["e_mail"].ToString();
                        giro_p.Text = r["giro"].ToString();
                    }

                    comando.CommandText = "select CONVERT(VARCHAR,fecha,105) fecha,iva,neto,total  from FACTURA where numero_fact=@n and rut_pro=@rut";
                    comando.Parameters.Add("@n", SqlDbType.Int);
                    comando.Parameters["@n"].Value = numerof.ToString();
                    da.SelectCommand = comando;
                    da.Fill(dtfactura);

                    DTR = dtfactura.Rows;
                    foreach (DataRow r in DTR)
                    {
                        fecha_p.Text = r["fecha"].ToString();
                        neto.Text = r["neto"].ToString();
                        iva.Text = r["iva"].ToString();
                        total.Text = r["total"].ToString();
                    }
                    nfactura_p.Text = numerof.ToString();

                    comando.CommandText = "select fp.cod_pro,p.nombre,fp.descripcion,fp.cantidad,fp.precio from   FACTURA f join FACT_PRODUCTO fp on f.rut_pro=@rut and numero_fact=@n  and guia='factura' and fp.num_fact=f.num_fact join PRODUCTO p on fp.cod_pro=p.cod_pro";
                    da.SelectCommand = comando;
                    da.Fill(dtfp);

                    foreach (DataRow r in dtfp.Rows)
                    {
                        dgv.Rows.Add(r["cod_pro"].ToString(), r["nombre"].ToString(), r["descripcion"].ToString(), r["cantidad"].ToString(), r["precio"].ToString());
                    }


                }
                catch (Exception ev)
                {
                    MessageBox.Show("Error al ingresar datos de Guia" + ev.ToString());
                }
            }
        }

        private void FacturaProveedor_Paint(object sender, PaintEventArgs e)
        {
            Rectangle fromcolor = new Rectangle(0, 0, this.Width, this.Height);
            Brush gbrush = new LinearGradientBrush(fromcolor, Color.Gold, Color.Maroon, LinearGradientMode.Vertical);
            e.Graphics.FillRectangle(gbrush, fromcolor);
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
