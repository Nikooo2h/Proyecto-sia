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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }
        DataTable dtclient = new DataTable();
        DataTable dtproducto = new DataTable();
        AutoCompleteStringCollection autocod = new AutoCompleteStringCollection();
        AutoCompleteStringCollection autonombre = new AutoCompleteStringCollection();
        private void Cliente_Load(object sender, EventArgs e)
        {
            fecha_p.Mask = "aa-aa-aaaa";
            SqlConnection con = new SqlConnection("Server=localhost; database=INVERSEC_3; integrated security=yes");
            SqlCommand comando;
            String com = "SELECT nombre FROM GIRO";
            try
            {
                con.Open();
                comando = new SqlCommand(com, con);
                SqlDataAdapter da_p = new SqlDataAdapter(comando);
                DataTable dtgiro = new DataTable();
                da_p.SelectCommand = comando;
                da_p.Fill(dtgiro);
                DataRowCollection dtr;
                dtr = dtgiro.Rows;
                foreach (DataRow r in dtr)
                {
                    giro_p.Items.Add(r["nombre"].ToString());
                }
                comando.CommandText = "select p.titular,p.rut_emp,p.nombre,g.nombre giro,p.direccion,p.fono,p.fax,p.e_mail FROM CLIENTE p join giro g on  g.codigo= p.codigo_giro";
                da_p.SelectCommand = comando;
                da_p.Fill(dtclient);
                dtr.Clear();
                dtr = dtclient.Rows;
                foreach (DataRow r in dtr)
                {
                    nombre_p.Items.Add(r["nombre"].ToString());
                }
                comando.CommandText = "SELECT cod_pro,nombre,descripcion FROM PRODUCTO ";
                da_p.SelectCommand = comando;

                da_p.Fill(dtproducto);
                foreach(DataRow r in dtproducto.Rows)
                {
                    autocod.Add(r["cod_pro"].ToString());
                    autonombre.Add(r["nombre"].ToString());
                }
                con.Close();
            }
            catch (Exception ev)
            {
                MessageBox.Show("Error en DataGridView " + ev.ToString());
            }
        }
        private bool verificar_dgv ()
        {

            foreach (DataGridViewRow r in dgvC.Rows)
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
            DateTime d;
            if (iva.TextLength != 0 && neto.TextLength != 0 && total.TextLength != 0 && titular_p.TextLength != 0 && rut_p.TextLength != 0 && giro_p.Text.Length != 0 && nombre_p.Text.Length != 0 && nfactura_p.TextLength != 0 && DateTime.TryParse( fecha_p.Text,out d) && direccion_p.TextLength != 0 && verificar_dgv())
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

                        comando.CommandText = "SELECT rut_emp FROM CLIENTE WHERE rut_emp=@rut";
                        comando.Parameters.Add("@rut", SqlDbType.VarChar);
                        comando.Parameters["@rut"].Value = rut_p.Text + "-" + rutd_p.Text;
                        dr = comando.ExecuteReader();
                        comando.Parameters.Clear();

                        if (!dr.Read())
                        {

                            dr.Close();
                            comando.CommandText = "INSERT INTO CLIENTE(rut_emp,titular,nombre,codigo_giro,direccion,fono,fax,e_mail) VALUES (@rut,@titular,@nombre,(select codigo FROM GIRO WHERE nombre=@giro),@direccion,@fono,@fax,@email)";

                            comando.Parameters.Add("@rut", SqlDbType.VarChar);
                            comando.Parameters["@rut"].Value = rut_p.Text + "-" + rutd_p.Text;
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
                        comando.CommandText = "INSERT INTO FACTURA(guia,numero_fact,fecha,neto,iva,total,codigo_emp,rut_cli) VALUES (@guia,@numero_fact,@fecha,@neto,@iva,@total,@cod_emp,@rut_emp)";

                        comando.Parameters.Add("@guia", SqlDbType.VarChar);
                        comando.Parameters["@guia"].Value = "Factura";

                        comando.Parameters.Add("@numero_fact", SqlDbType.Int);
                        comando.Parameters["@numero_fact"].Value = nfactura_p.Text;
                        comando.Parameters.Add("@fecha", SqlDbType.Date);
                        comando.Parameters["@fecha"].Value = fecha_p.Text;
                        comando.Parameters.Add("@cod_emp", SqlDbType.Int);
                        comando.Parameters["@cod_emp"].Value = "0";

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
                        comando.Parameters["@rut_emp"].Value = rut_p.Text + "-" + rutd_p.Text;
                        comando.ExecuteNonQuery();

                        comando.Parameters.Clear();


                        foreach (DataGridViewRow Rows in dgvC.Rows)
                        {
                            if (Rows.Cells[0].Value != null)
                            {
                                comando.Parameters.Clear();
                                comando.CommandText = "INSERT INTO FACT_PRODUCTO (num_fact,cod_pro,cantidad,precio,descripcion) VALUES ((SELECT num_fact FROM FACTURA WHERE numero_fact=@nfact AND rut_cli=@rut),@cod_pro,@cantidad,@precio,@descripcion)";
                                comando.Parameters.AddWithValue("@nfact", SqlDbType.Int);
                                comando.Parameters["@nfact"].Value = nfactura_p.Text;
                                comando.Parameters.AddWithValue("@rut", SqlDbType.VarChar);
                                comando.Parameters["@rut"].Value = rut_p.Text + "-" + rutd_p.Text;

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

                                comando.CommandText = "UPDATE PRODUCTO SET stock=stock-@cantidad WHERE cod_pro=@cod_pro";
                                comando.ExecuteNonQuery();

                            }
                        }

                        trans.Commit();
                        MessageBox.Show("Factura guardada con exito");
                        this.Owner.Show();
                        this.Close();
                    }
                    catch (SqlException ev)
                    {
                        MessageBox.Show("Error al insertar datos de tablas FACTURA,GIRO,PROVEEDOR.\n Debe llenar todas los datos que se piden, no existen datos opcionales" + ev.ToString());
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
                MessageBox.Show("Debe Ingresar todos los datos requeridos en el formulario.\nLos unicos datos opcionales son: fono,fax y e-mail", "CUIDADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }



        //Restricciones.
        private void rut_p_Validated(object sender, EventArgs e)
        {
            int id = 0;
            if ((rut_p.Text.Length > 0) && !int.TryParse(rut_p.Text, out id))
            {
                MessageBox.Show("Rut solo acepta valores numericos", "Rut con letras???", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rut_p.Text = "";
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
            DateTime a;
            if (!DateTime.TryParse(fecha_p.Text, out a))
            {
                fecha_p.Text = "";
                MessageBox.Show("Fecha ingresada no es valida", "ERRORRRRSSSS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                guardar.Enabled = false;
            }
            else
            {
                guardar.Enabled = true;
            }
            if (fecha_p.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar un fecha", "ERRORRRRSSSS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
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
                giro_p.Text = "";
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

        private void rutd_p_Validated(object sender, EventArgs e)
        {
            int suma = 0;
            int entR;
            if (rut_p.TextLength > 0)
            {
                entR=int.Parse(rut_p.Text);
                int resto = 0;
                int serie = 2;
                for (int i = 0; i < rut_p.Text.Length; i++)
                {
                    resto = entR % 10;
                    suma = resto * serie + suma;
                    entR = entR / 10;
                    if (serie > 6)
                    {
                        serie = 2;
                    }
                    else
                    {
                        serie++;
                    }
                }
                int div = suma % 11;
                div = 11 - div;
                if (div == 11)
                {
                    if (!rutd_p.Text.Equals("0"))
                    {
                        MessageBox.Show("Ha ingresado un código verificador erroneo");
                        guardar.Enabled = false;
                    }
                    else
                    {
                        guardar.Enabled = true;
                    }
                }
                if (div == 10)
                {
                    if (!rutd_p.Text.Equals("k"))
                    {
                        MessageBox.Show("Ha ingresado un código verificador erroneo");
                        guardar.Enabled = false;
                    }
                    else
                    {
                        guardar.Enabled = true;
                    }
                }
                if ((div != 11) && (div != 10))
                {
                    if (!rutd_p.Text.Equals(div.ToString()))
                    {
                        MessageBox.Show("Ha ingresado un código verificador erroneo");
                        guardar.Enabled = false;
                    }
                    else
                    {
                        guardar.Enabled = true;
                    }
                }

            }
            else
            {
                MessageBox.Show("Debe ingresar un rut con anterioridad");
            }
            if (rutd_p.Text.Length == 0)
            {
                 MessageBox.Show("Debe ingresar un digito verificador", "ERRORRRRSSSS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if ((neto.TextLength>0)&&!int.TryParse(neto.Text, out id))
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
                guardar.Enabled = false;
                return;
            }
            else
            {
                guardar.Enabled = true;
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

        private void nombre_p_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowCollection dtr;
            dtr = dtclient.Rows;
            foreach (DataRow r in dtr)
            {
                if (nombre_p.Text.Equals(r["nombre"].ToString()))
                {
                    titular_p.Text = r["titular"].ToString();
                    direccion_p.Text = r["direccion"].ToString();
                    fono_p.Text = r["fono"].ToString();
                    fax_p.Text = r["fax"].ToString();
                    email_p.Text = r["e_mail"].ToString();
                    String[] r1 = r["rut_emp"].ToString().Split('-');
                    rut_p.Text = r1[0];
                    rutd_p.Text = r1[1];
                    giro_p.Text=r["giro"].ToString();
                }
            }
        }

        private void dgvC_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is DataGridViewTextBoxEditingControl)
            {
                var cod = e.Control as DataGridViewTextBoxEditingControl;
                cod.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cod.AutoCompleteSource = AutoCompleteSource.CustomSource;
                switch (dgvC.CurrentCell.ColumnIndex)
                {
                    case 0:
                        cod.AutoCompleteCustomSource = autocod;
                        break;
                    case 1:
                        cod.AutoCompleteCustomSource = autonombre;
                        break;
                }
            }
        }

        private void dgvC_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvC.CurrentRow.Cells[0].Value != null)
            {
                foreach (DataRow r in dtproducto.Rows)
                {
                    if (r["cod_pro"].ToString().Equals(dgvC.CurrentRow.Cells[0].Value.ToString()))
                    {
                        dgvC.CurrentRow.Cells[1].Value = r["nombre"].ToString();
                        dgvC.CurrentRow.Cells[2].Value = r["descripcion"].ToString();
                    }
                }
            }
            int d;
            if (dgvC.CurrentRow.Cells[3].Value != null && !int.TryParse(dgvC.CurrentRow.Cells[3].Value.ToString(), out d))
            {
                dgvC.CurrentRow.Cells[3].Value = "";
                MessageBox.Show("Cantidad solo acepta valores numericos", "Avispate!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (dgvC.CurrentRow.Cells[4].Value != null && !int.TryParse(dgvC.CurrentRow.Cells[4].Value.ToString(), out d))
            {
                dgvC.CurrentRow.Cells[4].Value = "";
                MessageBox.Show("Precio solo acepta valores numericos", "Avispate!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Cliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void Cliente_Paint(object sender, PaintEventArgs e)
        {
            Rectangle fromcolor = new Rectangle(0, 0, this.Width, this.Height);
            Brush gbrush = new LinearGradientBrush(fromcolor, Color.Gold, Color.Maroon, LinearGradientMode.Vertical);
            e.Graphics.FillRectangle(gbrush, fromcolor);
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