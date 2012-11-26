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
    public partial class GuiasG : Form
    {
        public GuiasG()
        {
            InitializeComponent();
        }
         public String rut;
         public int numerof;
         int cont = 0;

        private void Guias_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=localhost; database=INVERSEC_3; integrated security=yes");
            SqlCommand comando;
            SqlDataAdapter da;
            DataRowCollection DTR;
            
            try
            {

                comando = new SqlCommand("select p.titular,p.rut_emp,p.nombre,g.nombre giro,p.direccion,p.fono,p.fax,p.e_mail FROM PROVEEDOR p,giro g WHERE p.rut_emp=@rut AND p.codigo_giro=g.codigo", con);
                comando.Parameters.Add("@rut", SqlDbType.VarChar);
                comando.Parameters["@rut"].Value=rut;
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
                    direccion_p.Text= r["direccion"].ToString();
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

                comando.CommandText = "select fp.cod_pro,p.nombre,fp.descripcion,fp.cantidad,fp.precio from   FACTURA f join FACT_PRODUCTO fp on f.rut_pro=@rut and numero_fact=@n  and guia='guia' and fp.num_fact=f.num_fact join PRODUCTO p on fp.cod_pro=p.cod_pro";
                da.SelectCommand = comando;
                da.Fill(dtfp);

                foreach (DataRow r in dtfp.Rows)
                {
                    dgv.Rows.Add(r["cod_pro"].ToString(),r["nombre"].ToString(),r["descripcion"].ToString(),r["cantidad"].ToString(),r["precio"].ToString());
                }
              

            }
            catch(Exception ev)
            {
                MessageBox.Show("Error al ingresar datos de Guia"+ev.ToString());
            }

        }
        private bool verificar_dgv()
        {

            foreach (DataGridViewRow r in dgv.Rows)
            {
                if (r.Cells[0].Value != null && r.Cells[1].Value != null)
                {
                    if (r.Cells[0].Value == null || r.Cells[1].Value == null || r.Cells[2].Value == null || r.Cells[3].Value == null || r.Cells[4].Value == null )
                        return false;
                }
            }
            return true;
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            if (nfactura_p.Text != numerof.ToString() && cont <2)
            {
                DateTime d;
                if (iva.TextLength != 0 && neto.TextLength != 0 && total.TextLength != 0 && titular_p.TextLength != 0 && rut_p != null && giro_p.TextLength != 0 && nombre_p.Text.Length != 0 && nfactura_p.TextLength != 0 && DateTime.TryParse(fecha_p.Text,out d) && direccion_p.TextLength != 0 && verificar_dgv())
                {
                    if (factura_p.Checked)
                    {
                        String conexion = "Server=localhost; database=INVERSEC_3; integrated security=yes";
                        SqlConnection con = new SqlConnection(conexion);
                        try
                        {
                            con.Open();
                            SqlTransaction trans = con.BeginTransaction();
                            SqlCommand comando = con.CreateCommand();
                            comando.Transaction = trans;
                            try
                            {


                                comando.CommandText = "SELECT nombre FROM GIRO WHERE nombre=@giro";
                                comando.Parameters.Add("@giro", SqlDbType.VarChar);
                                comando.Parameters["@giro"].Value = giro_p.Text;

                                SqlDataReader dr = comando.ExecuteReader();
                                if (!dr.Read())
                                {
                                    comando.CommandText = "INSERT INTO GIRO (nombre) VALUES (@giro)";
                                    dr.Close(); //Como datareader ocupa la conexion a sql server debo cerrarla antes de ejecutar el comando.
                                    comando.ExecuteNonQuery();
                                }
                                comando.Parameters.Clear();
                                dr.Close();

                                comando.CommandText = "SELECT rut_emp FROM PROVEEDOR WHERE rut_emp=@rut";
                                comando.Parameters.Add("@rut", SqlDbType.VarChar);
                                comando.Parameters["@rut"].Value = rut_p.Text;
                                dr = comando.ExecuteReader();
                                comando.Parameters.Clear();

                                if (!dr.Read())
                                {

                                    dr.Close();
                                    comando.CommandText = "UPDATE PROVEEDOR SET direccion=@direccion,fono=@fono,fax=@fax,e_mail=@email WHERE rut_emp=@rut";

                                    comando.Parameters.Add("@rut", SqlDbType.VarChar);
                                    comando.Parameters["@rut"].Value = rut_p.Text;
                                    comando.Parameters.Add("@titular", SqlDbType.VarChar);
                                    comando.Parameters["@titular"].Value = titular_p.Text;
                                    comando.Parameters.Add("@nombre", SqlDbType.VarChar);
                                    comando.Parameters["@nombre"].Value = nombre_p.Text;
                                    comando.Parameters.Add("@giro", SqlDbType.VarChar);
                                    comando.Parameters["@giro"].Value = giro_p.Text;
                                    comando.Parameters.Add("@direccion", SqlDbType.VarChar);
                                    comando.Parameters["@direccion"].Value = direccion_p.Text;
                                    comando.Parameters.Add("@fono", SqlDbType.Int);
                                    comando.Parameters["@fono"].Value = fono_p.Text;
                                    if (fax_p.Text.Length == 0)
                                    {
                                        comando.Parameters.Add("@fax", SqlDbType.Int);
                                        comando.Parameters["@fax"].Value = "0";
                                    }
                                    else
                                    {
                                        comando.Parameters.Add("@fax", SqlDbType.Int);
                                        comando.Parameters["@fax"].Value = fax_p.Text;
                                    }
                                    comando.Parameters.Add("@email", SqlDbType.VarChar);
                                    comando.Parameters["@email"].Value = email_p.Text;
                                    comando.ExecuteNonQuery();
                                }
                                dr.Close();

                                comando.Parameters.Clear();

                                //-----------------------------------------------------------------------------------



                                foreach (DataGridViewRow Rows in dgv.Rows)
                                {
                                    if (Rows.Cells[0].Value != null)
                                    {
                                        comando.Parameters.Clear();
                                        comando.CommandText = " UPDATE FACT_PRODUCTO SET cod_pro=@cod_pro,precio=@precio,descripcion=@descripcion WHERE num_fact=(SELECT num_fact from factura where numero_fact=@n and rut_pro=@rut)";
                                        comando.Parameters.Add("@rut", SqlDbType.VarChar);
                                        comando.Parameters["@rut"].Value = rut_p.Text;
                                        comando.Parameters.AddWithValue("@nfact", SqlDbType.Int);
                                        comando.Parameters["@nfact"].Value = nfactura_p.Text;
                                        comando.Parameters.AddWithValue("@fecha", SqlDbType.Date);
                                        comando.Parameters["@fecha"].Value = fecha_p.Text;
                                        comando.Parameters.Add("@n", SqlDbType.Int);
                                        comando.Parameters["@n"].Value = numerof.ToString();

                                        comando.Parameters.AddWithValue("@cod_pro", Convert.ToString(Rows.Cells[0].Value));

                                        comando.Parameters.AddWithValue("@descripcion", Convert.ToString(Rows.Cells[2].Value));

                                        comando.Parameters.AddWithValue("@cantidad", Convert.ToInt32(Rows.Cells[3].Value));

                                        if (Rows.Cells[4].Value == null)
                                        {
                                            comando.Parameters.AddWithValue("@precio", 0);
                                        }
                                        else
                                        {
                                            comando.Parameters.AddWithValue("@precio", Convert.ToInt32(Rows.Cells[4].Value));
                                        }

                                        comando.ExecuteNonQuery();


                                    }
                                }
                                comando.Parameters.Clear();

                                comando.CommandText = "UPDATE FACTURA SET guia=@guia,numero_fact=@numero_fact,neto=@neto,iva=@iva,total=@total WHERE numero_fact=@n and rut_pro=@rut_emp";
                                if (guia_p.Checked)
                                {
                                    comando.Parameters.Add("@guia", SqlDbType.VarChar);
                                    comando.Parameters["@guia"].Value = "Guia";
                                }
                                else
                                {
                                    comando.Parameters.Add("@guia", SqlDbType.VarChar);
                                    comando.Parameters["@guia"].Value = "Factura";
                                }
                                comando.Parameters.Add("@numero_fact", SqlDbType.Int);
                                comando.Parameters["@numero_fact"].Value = nfactura_p.Text;
                                comando.Parameters.Add("@fecha", SqlDbType.Date);
                                comando.Parameters["@fecha"].Value = fecha_p.Text;
                                comando.Parameters.Add("@cod_emp", SqlDbType.Int);
                                comando.Parameters["@cod_emp"].Value = "0";
                                comando.Parameters.Add("@n", SqlDbType.Int);
                                comando.Parameters["@n"].Value = numerof.ToString();

                                if (neto.Text.Length == 0)
                                {
                                    comando.Parameters.Add("@neto", SqlDbType.Int);
                                    comando.Parameters["@neto"].Value = "0";
                                }
                                else
                                {
                                    comando.Parameters.Add("@neto", SqlDbType.Int);
                                    comando.Parameters["@neto"].Value = neto.Text;
                                }
                                if (neto.Text.Length == 0)
                                {
                                    comando.Parameters.Add("@iva", SqlDbType.Int);
                                    comando.Parameters["@iva"].Value = "0";

                                }
                                else
                                {
                                    comando.Parameters.Add("@iva", SqlDbType.Int);
                                    comando.Parameters["@iva"].Value = iva.Text;
                                }
                                if (neto.Text.Length == 0)
                                {
                                    comando.Parameters.Add("@total", SqlDbType.Int);
                                    comando.Parameters["@total"].Value = "0";
                                }
                                else
                                {
                                    comando.Parameters.Add("@total", SqlDbType.Int);
                                    comando.Parameters["@total"].Value = total.Text;
                                }
                                comando.Parameters.Add("@rut_emp", SqlDbType.VarChar);
                                comando.Parameters["@rut_emp"].Value = rut_p.Text;
                                comando.ExecuteNonQuery();
                                trans.Commit();
                                MessageBox.Show("Factura modificada con exito");
                                this.Owner.Show();
                                this.Close();
                            }
                            catch (SqlException ev)
                            {
                                MessageBox.Show("Error al insertar datos de tablas FACTURA,GIRO,PROVEEDOR: " + ev.ToString());
                                try
                                {
                                    trans.Rollback();
                                }
                                catch (Exception exrollb)
                                {
                                    MessageBox.Show("Error al ejecutar ROLLBACK: " + exrollb.ToString());
                                }
                            }

                            con.Close();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al intentar conectar la base de datos: " + ex.ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Asegurese de marcar esta GUIA como FACTURA");
                    }
                }
                else
                {
                    MessageBox.Show("Debe Ingresar todos los datos requeridos en el formulario.\nLos unicos datos opcionales son: fono,fax y e-mail", "CUIDADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                cont++;
                MessageBox.Show("Recuerde que debe cambiar el número de GUIA por el número de FACTURA ", "CUIDADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }


        private void rut_p_Validated(object sender, EventArgs e)
        {
            int id = 0;
            if ((rut_p.Text.Length > 0) && !int.TryParse(rut_p.Text, out id))
            {
                MessageBox.Show("Rut solo acepta valores numericos", "Rut con letras???", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                guardar.Enabled = false;
                return;
            }
            else
            {
                guardar.Enabled = true;
            }
            if (rut_p.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar un rut", "ERRORRRRSSSS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void titular_p_Validated(object sender, EventArgs e)
        {
            int id = 0;
            if ((titular_p.Text.Length > 0) && int.TryParse(titular_p.Text, out id))
            {
                MessageBox.Show("Nombre del titular solo acepta caracteres", "Nombre con número??? JAJAJ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                guardar.Enabled = false;
                return;
            }
            else
            {
                guardar.Enabled = true;
            }
            if (titular_p.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar un titular", "ERRORRRRSSSS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void nfactura_p_Validated(object sender, EventArgs e)
        {
            int id = 0;
            if ((nfactura_p.Text.Length > 0) && !int.TryParse(nfactura_p.Text, out id))
            {
                nfactura_p.Text = "";
                MessageBox.Show("Número de factura solo acepta valores numericos", "Pegate la cacha po!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                guardar.Enabled = false;
                return;
            }
            else
            {
                guardar.Enabled = true;
            }
            if (nfactura_p.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar un número de factura", "ERRORRRRSSSS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void fecha_p_Validated(object sender, EventArgs e)
        {
            
            if (fecha_p.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar un fecha", "ERRORRRRSSSS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                guardar.Enabled = false;
                return;
            }
            else
            {
                guardar.Enabled = true;
            }
        }

        private void fax_p_Validated(object sender, EventArgs e)
        {
            int id = 0;
            if ((fax_p.Text.Length > 0) && !int.TryParse(fax_p.Text, out id))
            {
                fax_p.Text = "";
                MessageBox.Show("Número de fax solo acepta valores numericos", "Pegate la cacha po!!! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                guardar.Enabled = false;
                return;
            }
            else
            {
                guardar.Enabled = true;
            }
            if (fax_p.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar un fax", "ERRORRRRSSSS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void fono_p_Validated(object sender, EventArgs e)
        {
            int id = 0;
            if ((fono_p.Text.Length > 0) && !int.TryParse(fono_p.Text, out id))
            {
                fono_p.Text = "";
                MessageBox.Show("Número de teléfono solo acepta valores numericos", "Pegate la cacha po!!! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                guardar.Enabled = false;
                return;
            }
            else
            {
                guardar.Enabled = true;
            }
            if (fono_p.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar un teléfono", "ERRORRRRSSSS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void giro_p_Validating(object sender, CancelEventArgs e)
        {
            int id = 0;
            if ((giro_p.Text.Length > 0) && int.TryParse(giro_p.Text, out id))
            {
                giro_p.Text="";
                MessageBox.Show("Giro solo acepta caracteres", "Usted no haga eso!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                guardar.Enabled = false;
                return;
            }
            else
            {
                guardar.Enabled = true;
            }
            if (giro_p.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar un giro", "ERRORRRRSSSS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

       
        private void iva_Validated(object sender, EventArgs e)
        {
            int id = 0;
            if ((iva.TextLength>0) && !int.TryParse(iva.Text, out id))
            {
                iva.Text = "";
                MessageBox.Show("IVA solo acepta valores numericos", "Bah", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                guardar.Enabled = false;
                return;
            }
            else
            {
                guardar.Enabled = true;
            }
        }

        private void neto_Validated(object sender, EventArgs e)
        {
            int id = 0;
            if ((neto.TextLength>0) && !int.TryParse(neto.Text, out id))
            {
                neto.Text = "";
                MessageBox.Show("NETO solo acepta valores numericos", "Pegate la cacha po!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                guardar.Enabled = false;
                return;
            }
            else
            {
                guardar.Enabled = true;
            }

        }

        private void total_Validated(object sender, EventArgs e)
        {
            int id = 0;
            if ((total.TextLength>0) && !int.TryParse(total.Text, out id))
            {
                total.Text = "";
                MessageBox.Show("TOTAL solo acepta valores numericos", "Pegate la cacha po!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                guardar.Enabled = false;
                return;
            }
            else
            {
                guardar.Enabled = true;
            }

        }

        private void nombre_p_Validated(object sender, EventArgs e)
        {
            if (nombre_p.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar una empresa", "ERRORRRRSSSS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void direccion_p_Validated(object sender, EventArgs e)
        {

            if (nombre_p.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar una dirección", "ERRORRRRSSSS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                guardar.Enabled = false;
                return;
            }
            else
            {
                guardar.Enabled = true;
            }
        }

        private void GuiasG_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void GuiasG_Paint(object sender, PaintEventArgs e)
        {
            Rectangle fromcolor = new Rectangle(0, 0, this.Width, this.Height);
            Brush gbrush = new LinearGradientBrush(fromcolor, Color.Gold, Color.Maroon, LinearGradientMode.Vertical);
            e.Graphics.FillRectangle(gbrush, fromcolor);
        }

        private void dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int d;
            if (dgv.CurrentRow.Cells[4].Value != null && !int.TryParse(dgv.CurrentRow.Cells[4].Value.ToString(), out d))
            {
                dgv.CurrentRow.Cells[4].Value = "";
                MessageBox.Show("Precio solo acepta valores numericos", "Avispate!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guardar_MouseMove(object sender, MouseEventArgs e)
        {
            guardar.BackColor = Color.Maroon;
        }

        private void guardar_MouseLeave(object sender, EventArgs e)
        {
            guardar.BackColor = Color.White;
        }

        private void cancelar_MouseMove(object sender, MouseEventArgs e)
        {
            cancelar.BackColor = Color.Maroon;
        }

        private void cancelar_MouseLeave(object sender, EventArgs e)
        {
            cancelar.BackColor = Color.White;
        }

       
    }
}
