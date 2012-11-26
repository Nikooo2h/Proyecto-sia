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
    public partial class Historial_Producto : Form
    {
        public Historial_Producto()
        {
            InitializeComponent();
        }
        DataTable dtingresos= new DataTable();
        DataTable dtsalidas=new DataTable();
        DataTable nproducto = new DataTable();
        Boolean ini = false;
        Boolean fin = false;
        AutoCompleteStringCollection autoproducto = new AutoCompleteStringCollection();
        private void Historial_Producto_Load(object sender, EventArgs e)
        {
            fecha_ini.Mask = "aa-aa-aaaa";
            fecha_fin.Mask = "aa-aa-aaaa";
            using (SqlConnection con = new SqlConnection("Server=localhost; database=INVERSEC_3; integrated security=yes"))
            {
                try
                {
                    SqlCommand comando = new SqlCommand("SELECT nombre from PRODUCTO",con);
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    da.Fill(nproducto);
                    foreach (DataRow r in nproducto.Rows)
                    {
                        autoproducto.Add(r["nombre"].ToString());
                    }
                    producto.AutoCompleteCustomSource = autoproducto;
                    producto.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    producto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                }
                catch(Exception ev)
                {
                    MessageBox.Show("Error al conectarse a producto para el autocompletar: "+ev.ToString());
                }
            }
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            if (ini && fin)
            {
                dtingresos.Clear();
                dtsalidas.Clear();
                using (SqlConnection con = new SqlConnection("Server=localhost; database=INVERSEC_3; integrated security=yes"))
                {
                    try
                    {
                        SqlCommand comando = new SqlCommand("SELECT pro.nombre Proveedor,p.cod_pro Codigo,p.nombre Nombre,p.descripcion Descripcion,b.nombre Bodega, CONVERT(VARCHAR,f.fecha,105) Fecha, sum(fp.cantidad) Cantidad from PRODUCTO p join FACT_PRODUCTO fp on p.cod_pro=fp.cod_pro join FACTURA f on f.num_fact=fp.num_fact and f.fecha between @fechaini and @fechafin join bodega b on p.cod_bodega=b.cod_bodega join PROVEEDOR pro on pro.rut_emp=f.rut_pro group by f.fecha,p.cod_pro,p.nombre,p.descripcion,b.nombre,pro.nombre ", con);
                        comando.Parameters.AddWithValue("@fechaini", Convert.ToString(fecha_ini.Text));
                        comando.Parameters.AddWithValue("@fechafin", Convert.ToString(fecha_fin.Text));
                        SqlDataAdapter da = new SqlDataAdapter(comando);
                        da.Fill(dtingresos);
                        dgvi.DataSource = dtingresos;
                        comando.CommandText = "SELECT cli.nombre Cliente,p.cod_pro Codigo,p.nombre Nombre,p.descripcion Descripcion,b.nombre Bodega, CONVERT(VARCHAR,f.fecha,105) Fecha, sum(fp.cantidad) Cantidad from PRODUCTO p join FACT_PRODUCTO fp on p.cod_pro=fp.cod_pro join FACTURA f on f.num_fact=fp.num_fact and f.fecha between @fechaini and @fechafin join bodega b on p.cod_bodega=b.cod_bodega join Cliente cli on cli.rut_emp=f.rut_cli group by f.fecha,p.cod_pro,p.nombre,p.descripcion,b.nombre,cli.nombre";
                        da.Fill(dtsalidas);
                        dgvs.DataSource = dtsalidas;
                    }
                    catch (Exception ev)
                    {
                        MessageBox.Show("Error al intentar consultar la base de datos: " + ev.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar dos fechas validas");
            }
        }

        private void buscarP_Click(object sender, EventArgs e)
        {
            if(producto.TextLength>0)
            {
            dtingresos.Clear();
            dtsalidas.Clear();
            using (SqlConnection con = new SqlConnection("Server=localhost; database=INVERSEC_3; integrated security=yes"))
            {
                try
                {
                    SqlCommand comando = new SqlCommand("SELECT pro.nombre Proveedor,p.cod_pro Codigo,p.nombre Nombre,p.descripcion Descripcion,b.nombre Bodega, CONVERT(VARCHAR,f.fecha,105) Fecha, sum(fp.cantidad) Cantidad from PRODUCTO p join FACT_PRODUCTO fp on p.cod_pro=fp.cod_pro and p.nombre=@nombre join FACTURA f on f.num_fact=fp.num_fact  join bodega b on p.cod_bodega=b.cod_bodega join PROVEEDOR pro on pro.rut_emp=f.rut_pro group by f.fecha,p.cod_pro,p.nombre,p.descripcion,b.nombre,pro.nombre", con);
                    comando.Parameters.AddWithValue("@nombre", producto.Text);
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    da.Fill(dtingresos);
                    dgvi.DataSource = dtingresos;
                    comando.CommandText = "SELECT cli.nombre Cliente,p.cod_pro Codigo,p.nombre Nombre,p.descripcion Descripcion,b.nombre Bodega, CONVERT(VARCHAR,f.fecha,105) Fecha, sum(fp.cantidad) Cantidad from PRODUCTO p join FACT_PRODUCTO fp on p.cod_pro=fp.cod_pro and p.nombre=@nombre join FACTURA f on f.num_fact=fp.num_fact join bodega b on p.cod_bodega=b.cod_bodega join Cliente cli on cli.rut_emp=f.rut_cli group by f.fecha,p.cod_pro,p.nombre,p.descripcion,b.nombre,cli.nombre ";
                    da.Fill(dtsalidas);
                    dgvs.DataSource = dtsalidas;
                }
                catch (Exception ev)
                {
                    MessageBox.Show("Error al intentar consultar la base de datos: " + ev.ToString());
                }
            }
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre de prodcuto");
            }
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

        private void Historial_Producto_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void producto_Validated(object sender, EventArgs e)
        {
            Boolean verdad = false;
            foreach (DataRow r in nproducto.Rows)
            {
                if (r["nombre"].ToString().Equals(producto.Text))
                {
                    verdad = true;
                }
            }
            if (!verdad)
            {
                producto.Text = "";
                MessageBox.Show("Debe ingresar un nombre de producto válido");
            }
        }

        private void Historial_Producto_Paint(object sender, PaintEventArgs e)
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

        private void buscarP_MouseMove(object sender, MouseEventArgs e)
        {
            buscarP.BackColor = Color.Maroon;
        }

        private void buscarP_MouseLeave(object sender, EventArgs e)
        {
            buscarP.BackColor = Color.White;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Maroon;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }

       
        
            
            
    }
}
