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
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        private void Inventario_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Server=localhost; database=INVERSEC_3; integrated security=yes"))
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("Select p.cod_pro Codigo,p.nombre Nombre,c.nombre Clasificacion,m.nombre Marca,p.modelo Modelo,p.descripcion Descripción,p.stock Stock,b.nombre Bodega,p.precio Precio,p.USprecio US$ from PRODUCTO p, MARCA m,CLASIFICACION c,BODEGA b WHERE m.cod_marca=p.cod_marca AND c.cod_clasif=p.cod_clasif AND b.cod_bodega=p.cod_bodega", con);
                    da.Fill(dt);
                    dgvv.DataSource = dt;
                }
                catch (Exception ev)
                {
                    MessageBox.Show("Error:" + ev.ToString());
                }
                SqlCommand comando;
                String com = "SELECT cod_clasif,nombre,nueva_classif FROM CLASIFICACION";
                try
                {
                    con.Open();
                    comando = new SqlCommand(com, con);
                    SqlDataAdapter da_p = new SqlDataAdapter(comando);
                    DataTable dtclasif = new DataTable();
                    DataTable dtbodega = new DataTable();
                    da_p.Fill(dtclasif);
                    Boolean b = true;
                    foreach(DataRow r in dtclasif.Rows)
                    {
                        foreach (DataRow w in dtclasif.Rows)
                        {
                            if (r["cod_clasif"].ToString() == w["nueva_classif"].ToString() && r["nombre"].ToString() != w["nombre"].ToString())
                            {
                                b = false;
                            }
                        }
                        if (b)
                        {
                            Clasificacion.Items.Add(r["nombre"].ToString());
                        }
                        b = true;
                    }

                    comando.CommandText = "SELECT nombre FROM BODEGA";
                    da_p.SelectCommand = comando;
                    da_p.Fill(dtbodega);
                    foreach (DataRow r in dtbodega.Rows)
                    {
                        Bodega.Items.Add(r["nombre"].ToString());
                    }
                    con.Close();
                }
                catch (Exception ev)
                {
                    MessageBox.Show("Error en DataGridView " + ev.ToString());
                }
            }

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void Inventario_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void Clasificacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bodega.Text = "";
            dt.Clear();
            using (SqlConnection con = new SqlConnection("Server=localhost; database=INVERSEC_3; integrated security=yes"))
            {
                try
                {
                    SqlCommand comando = new SqlCommand("Select p.cod_pro Codigo,p.nombre Nombre,c.nombre Clasificacion,m.nombre Marca,p.modelo Modelo,p.descripcion Descripción,p.stock Stock,b.nombre Bodega,p.precio Precio,p.USprecio US$ from PRODUCTO p join MARCA m on m.cod_marca=p.cod_marca join CLASIFICACION c on p.cod_clasif=(select cod_clasif from clasificacion where nombre=@nombre) and c.nombre=@nombre join BODEGA b on p.cod_bodega=b.cod_bodega", con);
                    comando.Parameters.AddWithValue("@nombre", Convert.ToString(Clasificacion.SelectedItem.ToString()));
                    SqlDataAdapter da = new SqlDataAdapter(comando);

                    da.Fill(dt);
                    dgvv.DataSource = dt;
                }
                catch (Exception ev)
                {
                    MessageBox.Show("Error En Clasificacion: " + ev.ToString());
                }
            }
        }

        private void Bodega_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clasificacion.Text = "";
            dt.Clear();
            using (SqlConnection con = new SqlConnection("Server=localhost; database=INVERSEC_3; integrated security=yes"))
            {
                try
                {
                    SqlCommand comando = new SqlCommand("Select p.cod_pro Codigo,p.nombre Nombre,c.nombre Clasificacion,m.nombre Marca,p.modelo Modelo,p.descripcion Descripción,p.stock Stock,b.nombre Bodega,p.precio Precio,p.USprecio US$ from PRODUCTO p join MARCA m on m.cod_marca=p.cod_marca join CLASIFICACION c on c.cod_clasif=p.cod_clasif join BODEGA b on @nombre=b.nombre and p.cod_bodega=(select cod_bodega from bodega where nombre=@nombre)", con);
                    comando.Parameters.AddWithValue("@nombre", Bodega.SelectedItem.ToString());
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    da.Fill(dt);
                    dgvv.DataSource = dt;
                }
                catch (Exception ev)
                {
                    MessageBox.Show("Error en Bodega:" + ev.ToString());
                }
            }
        }

        private void Inventario_Paint(object sender, PaintEventArgs e)
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
