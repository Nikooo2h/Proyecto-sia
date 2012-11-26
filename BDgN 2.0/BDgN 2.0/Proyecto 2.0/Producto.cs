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
    public partial class Precio : Form
    {
        public Precio()
        {
            InitializeComponent();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
        DataTable dt;
        BindingSource bs=new BindingSource();
        SqlDataAdapter da;
        private void marca_p_Load(object sender, EventArgs e)
        {
            rtv.Text = TextoAyuda.Precio + TextoAyuda.p_modificacion + TextoAyuda.p_funcion + TextoAyuda.p_actualización;
            SqlConnection con = new SqlConnection("Server=localhost; database=INVERSEC_3; integrated security=yes");

                dgvp.DataSource = bs;
                try
                {

                    dt = new DataTable();
                    da = new SqlDataAdapter("select cod_pro Codigo,nombre Nombre,descripcion Descripcion, precio Precio, USPrecio US$ from producto", con);
                    SqlCommandBuilder comandob = new SqlCommandBuilder(da);
                    da.Fill(dt);
                    da.UpdateCommand = comandob.GetUpdateCommand();
                    da.InsertCommand = comandob.GetInsertCommand();
                    da.DeleteCommand = comandob.GetDeleteCommand();
                    bs.DataSource = dt;
                    dgvp.Columns[0].ReadOnly = true;
                    dgvp.Columns[1].ReadOnly = true;
                    dgvp.Columns[2].ReadOnly = true;
                    

                }
                catch(Exception ev)
                {
                    MessageBox.Show("Error al conectar con la tabla PRODUCTO"+ev.ToString(),"ERRORS",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            
        }

        private void Producto_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

       
        private void Dolares_Validated(object sender, EventArgs e)
        {
            int a = 0;
            if (Dolares.Text.Length > 0 && !int.TryParse(Dolares.Text, out a))
            {
                MessageBox.Show("Ingrese un valor de dolar válido", "ERRORSSSS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Dolares.Text = "";
                Conversion.Enabled = false;
            }
            else
            {
                Conversion.Enabled = true;
            }
        }

        private void Conversion_Click(object sender, EventArgs e)
        {
            if (Dolares.TextLength > 0)
            {
                int dolar = Convert.ToInt32(Dolares.Text);
                foreach (DataGridViewRow r in dgvp.Rows)
                {
                    if (r.Cells[0].Value != null)
                    {
                        if (r.Cells[4].Value != null && Convert.ToInt32(r.Cells[4].Value) > 0)
                        {
                            r.Cells[3].Value = dolar * Convert.ToInt32(r.Cells[4].Value);
                        }
                    }
                }
                MessageBox.Show("Conversión realizada");
            }
            else
            {
                MessageBox.Show("Debe ingresar el valor de dolar");
            }
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            bs.EndEdit();
            da.Update((DataTable)bs.DataSource);
            MessageBox.Show("Datos guardados");
        }

        private void Precio_Paint(object sender, PaintEventArgs e)
        {
            Rectangle fromcolor = new Rectangle(0, 0, this.Width, this.Height);
            Brush gbrush = new LinearGradientBrush(fromcolor, Color.Gold, Color.Maroon, LinearGradientMode.Vertical);
            e.Graphics.FillRectangle(gbrush, fromcolor);
        }

        private void Conversion_MouseMove(object sender, MouseEventArgs e)
        {
            Conversion.BackColor = Color.Maroon;
        }

        private void Conversion_MouseLeave(object sender, EventArgs e)
        {
            Conversion.BackColor = Color.White;
        }

        private void Actualizar_MouseMove(object sender, MouseEventArgs e)
        {
            Actualizar.BackColor = Color.Maroon;
        }

        private void Actualizar_MouseLeave(object sender, EventArgs e)
        {
            Actualizar.BackColor = Color.White;
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
