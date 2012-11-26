using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace WindowsFormsApplication1
{
    public partial class Clasificaciones : Form
    {
        
        public Clasificaciones()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        String seleccion="";
        private void Form1_Load(object sender, EventArgs e)
        {
            rtb.Text = TextoAyuda.clasificacion + TextoAyuda.clasif_clasificacion + TextoAyuda.clasif_subclasificacion + TextoAyuda.clasif_bodega;
            using (SqlConnection con = new SqlConnection("server=localhost; database=INVERSEC_3; integrated security=True"))
            {
                try
                {
                    con.Open();
                    SqlCommand comando = new SqlCommand("SELECT * FROM CLASIFICACION", con);
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    da.Fill(dt);
                    con.Close();
                    bodega();
                }
                catch (Exception ev)
                {
                    MessageBox.Show("ERRORS"+ev.ToString());
                }

                CrearNodosDelPadre("", null);
                tv.ExpandAll();
            }
        }
        private void bodega()
        {
            using(SqlConnection con=new SqlConnection("server=localhost; database=INVERSEC_3; integrated security=True"))
            {
                try
                {
                     con.Open();
                    SqlCommand comando = new SqlCommand("SELECT nombre FROM BODEGA", con);
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    DataTable dtb = new DataTable();
                    da.Fill(dtb);
                    foreach (DataRow r in dtb.Rows)
                    {
                        list_b.Items.Add(r["nombre"].ToString());
                    }
                    con.Close();
                }
                catch(Exception ev)
                {
                    MessageBox.Show("Error al buscar bodegas: "+ev.ToString());
                }
            }
        }
        private void CrearNodosDelPadre(String indicePadre, TreeNode nodePadre)
        {
            // Crear un DataView con los Nodos que dependen del Nodo padre pasado como parámetro.

            // Agregar al TreeView los nodos Hijos que se han obtenido en el DataView.
            foreach (DataRow r in dt.Rows)
            {
                if (r["nueva_classif"].ToString() == indicePadre)
                {
                    TreeNode nuevoNodo = new TreeNode();
                    nuevoNodo.Text = r["nombre"].ToString().Trim();

                    // si el parámetro nodoPadre es nulo es porque es la primera llamada, son los Nodos
                    // del primer nivel que no dependen de otro nodo.
                    if (nodePadre == null)
                    {
                        tv.Nodes.Add(nuevoNodo);
                    }
                    // se añade el nuevo nodo al nodo padre.
                    else
                    {
                        nodePadre.Nodes.Add(nuevoNodo);
                    }

                    // Llamada recurrente al mismo método para agregar los Hijos del Nodo recién agregado.

                    CrearNodosDelPadre(r["cod_clasif"].ToString(), nuevoNodo);
                }
            }
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void Agregar1_Click(object sender, EventArgs e)
        {
            if (clasif!=null)
            {
                using (SqlConnection con = new SqlConnection("server=localhost; database=INVERSEC_3; integrated security=True"))
                {
                    try
                    {
                        con.Open();
                        SqlCommand comando = new SqlCommand("INSERT INTO CLASIFICACION (nombre) VALUES (@nombre)", con);
                        comando.Parameters.AddWithValue("@nombre", clasif.Text);
                        comando.ExecuteNonQuery();
                        clasif.Text = "";
                        comando.CommandText = "SELECT * from CLASIFICACION";
                        SqlDataAdapter da = new SqlDataAdapter(comando);
                        dt.Clear();
                        da.Fill(dt);
                        tv.Nodes.Clear();
                        CrearNodosDelPadre("", null);
                        tv.ExpandAll();
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
                MessageBox.Show("Debe ingresar una nueva clasificacion");
            }
        }

        private void Agregar2_Click(object sender, EventArgs e)
        {
            if (subclasif!=null)
            {
                using (SqlConnection con = new SqlConnection("server=localhost; database=INVERSEC_3; integrated security=True"))
                {
                    try
                    {
                        con.Open();
                        SqlCommand comando = new SqlCommand("INSERT INTO CLASIFICACION (nombre,nueva_classif) VALUES (@nombre,(SELECT cod_clasif from CLASIFICACION WHERE nombre=@clasificacion))", con);
                        comando.Parameters.AddWithValue("@clasificacion", seleccion);
                        comando.Parameters.AddWithValue("@nombre", subclasif.Text);
                        comando.ExecuteNonQuery();
                        subclasif.Text = "";
                        comando.CommandText = "SELECT * from CLASIFICACION";
                        SqlDataAdapter da = new SqlDataAdapter(comando);
                        dt.Clear();
                        da.Fill(dt);
                        tv.Nodes.Clear();
                        CrearNodosDelPadre("", null);
                        tv.ExpandAll();
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
                MessageBox.Show("Debe ingresar una nueva subclasificacion");
            }

        }

        private void Borrar1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("server=localhost; database=INVERSEC_3; integrated security=True"))
            {
                try
                {
                    con.Open();
                    SqlCommand comando = new SqlCommand("DELETE FROM CLASIFICACION WHERE @clasificacion=nombre", con);
                    comando.Parameters.AddWithValue("@clasificacion", seleccion);
                    comando.Parameters.AddWithValue("@nombre", clasif.Text);
                    comando.ExecuteNonQuery();
                    clasif.Text = "";
                    comando.CommandText = "SELECT * from CLASIFICACION";
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    dt.Clear();
                    da.Fill(dt);
                    tv.Nodes.Clear();
                    CrearNodosDelPadre("", null);
                    tv.ExpandAll();
                    con.Close();
                }
                catch (Exception ev)
                {
                    MessageBox.Show("Error: " + ev.ToString());
                }

            }

        }

        private void Borrar2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("server=localhost; database=INVERSEC_3; integrated security=True"))
            {
                try
                {
                    con.Open();
                    SqlCommand comando = new SqlCommand("DELETE FROM CLASIFICACION WHERE @clasificacion=nombre", con);
                    comando.Parameters.AddWithValue("@clasificacion", seleccion);
                    comando.Parameters.AddWithValue("@nombre", subclasif.Text);
                    comando.ExecuteNonQuery();
                    subclasif.Text = "";
                    comando.CommandText = "SELECT * from CLASIFICACION";
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    dt.Clear();
                    da.Fill(dt);
                    tv.Nodes.Clear();
                    CrearNodosDelPadre("", null);
                    tv.ExpandAll();
                    con.Close();
                }
                catch (Exception ev)
                {
                    MessageBox.Show("Error: " + ev.ToString());
                }

            }
        }


        private void Bodega_Click(object sender, EventArgs e)
        {
            if (bodega_p!=null)
            {
                using (SqlConnection con = new SqlConnection("server=localhost; database=INVERSEC_3; integrated security=True"))
                {
                    try
                    {
                        con.Open();
                        SqlCommand comando = new SqlCommand("INSERT INTO Bodega (nombre) VALUES (@nombre)", con);
                        comando.Parameters.AddWithValue("@nombre", bodega_p.Text);
                        comando.ExecuteNonQuery();
                        bodega_p.Text = "";
                        list_b.Items.Clear();
                        bodega();
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
                MessageBox.Show("Debe ingresa un nombre de bodega");
            }

        }

        private void tv_AfterSelect(object sender, TreeViewEventArgs e)
        {
            seleccion = tv.SelectedNode.Text;
        }

        private void Clasificaciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void Clasificaciones_Paint(object sender, PaintEventArgs e)
        {
            Rectangle fromcolor = new Rectangle(0, 0, this.Width, this.Height);
            Brush gbrush = new LinearGradientBrush(fromcolor, Color.Gold, Color.Maroon, LinearGradientMode.Vertical);
            e.Graphics.FillRectangle(gbrush, fromcolor);
        }

        private void Agregar1_MouseLeave(object sender, EventArgs e)
        {
            Agregar1.BackColor = Color.White;
        }

        private void Agregar1_MouseMove(object sender, MouseEventArgs e)
        {
            Agregar1.BackColor = Color.Maroon;
        }

        private void Borrar1_MouseMove(object sender, MouseEventArgs e)
        {
            Borrar1.BackColor = Color.Maroon;
        }

        private void Borrar1_MouseLeave(object sender, EventArgs e)
        {
            Borrar1.BackColor = Color.White;
        }

        private void Agregar2_MouseMove(object sender, MouseEventArgs e)
        {
            Agregar2.BackColor = Color.Maroon;
        }

        private void Agregar2_MouseLeave(object sender, EventArgs e)
        {
            Agregar2.BackColor = Color.White;
        }

        private void Borrar2_MouseMove(object sender, MouseEventArgs e)
        {
            Borrar2.BackColor = Color.Maroon;
        }

        private void Borrar2_MouseLeave(object sender, EventArgs e)
        {
            Borrar2.BackColor = Color.White;
        }

        private void Bodega_MouseMove(object sender, MouseEventArgs e)
        {
            Bodega.BackColor = Color.Maroon;
        }

        private void Bodega_MouseLeave(object sender, EventArgs e)
        {
            Bodega.BackColor = Color.White;
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
