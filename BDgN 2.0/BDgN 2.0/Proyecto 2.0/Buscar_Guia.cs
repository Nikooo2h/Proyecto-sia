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
    public partial class Buscar_Guia : Form
    {
        public Buscar_Guia()
        {
            InitializeComponent();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
        GuiasG g;
        SqlDataAdapter da;
        DataTable dt=new DataTable();
        private void Buscar_Click(object sender, EventArgs e)
        {
            if (rut_p.Text.Length > 0 && rutd_p.Text.Length > 0 && nfactura_p.Text.Length > 0)
            {
                SqlConnection con = new SqlConnection("Server=localhost; database=INVERSEC_3; integrated security=yes");
                try
                {
                    SqlCommand comando = new SqlCommand("SELECT * FROM FACTURA WHERE numero_fact=@n AND guia=@guia AND rut_pro=@rut", con);
                    comando.Parameters.Add("@rut", SqlDbType.VarChar);
                    comando.Parameters["@rut"].Value = rut_p.Text + "-" + rutd_p.Text;
                    comando.Parameters.Add("@guia", SqlDbType.VarChar);
                    comando.Parameters["@guia"].Value = "Guia";
                    comando.Parameters.Add("@n", SqlDbType.Int);
                    comando.Parameters["@n"].Value = nfactura_p.Text;

                    da = new SqlDataAdapter(comando);

                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        g = new GuiasG();
                        g.rut = rut_p.Text + "-" + rutd_p.Text;
                        g.numerof = Convert.ToInt32(nfactura_p.Text);
                        this.AddOwnedForm(g);
                        this.Hide();
                        g.Show();
                    }
                    else
                    {
                        MessageBox.Show("No se encontro la guia");
                    }
                    con.Close();

                }
                catch (Exception ev)
                {
                    MessageBox.Show("Error: " + ev.ToString());
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar número de factura y rut de la empresa");
            }
        }

        private void Buscar_Guia_Load(object sender, EventArgs e)
        {
            DataTable dtgrid = new DataTable();
            SqlDataAdapter da;
            using (SqlConnection con= new SqlConnection("Server=localhost; database=INVERSEC_3; integrated security=yes"))
            {
               try
               {
                   SqlCommand comando = new SqlCommand("SELECT f.rut_pro Rut, p.nombre Nombre ,f.fecha Fecha, f.numero_fact Factura from Proveedor p join factura f on f.guia='guia' and f.rut_pro=p.rut_emp",con);
                   da = new SqlDataAdapter(comando);
                   da.Fill(dtgrid);
                   dgv.DataSource = dtgrid;
                   con.Close();
               }
                catch(Exception ex)
               {
                    MessageBox.Show("Error al intentar agregar datos a DataGridView"+ex.ToString());

               }
            }
        }

        private void Buscar_Guia_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

       
        private void rutd_p_Validated(object sender, EventArgs e)
        {
            int suma = 0;
            if (rut_p.TextLength > 0)
            {
                int entR = int.Parse(rut_p.Text);
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
                    }
                }
                if (div == 10)
                {
                    if (!rutd_p.Text.Equals("k"))
                    {
                        MessageBox.Show("Ha ingresado un código verificador erroneo");
                    }
                }
                if ((div != 11) && (div != 10))
                {
                    if (!rutd_p.Text.Equals(div.ToString()))
                    {
                        MessageBox.Show("Ha ingresado un código verificador erroneo");
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

        private void rut_p_Validated(object sender, EventArgs e)
        {
            int d;
            if (rut_p.TextLength > 0 && !int.TryParse(rut_p.Text, out d))
            {
                rut_p.Text = "";
                MessageBox.Show("Debe ingresar un rut válido");
            }
        }

        private void nfactura_p_Validated(object sender, EventArgs e)
        {
            int d;
            if (nfactura_p.TextLength > 0 && !int.TryParse(nfactura_p.Text, out d))
            {
                nfactura_p.Text = "";
                MessageBox.Show("Debe ingresar un numero de factura válido");
            }
        }

        private void Buscar_Guia_Paint(object sender, PaintEventArgs e)
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
