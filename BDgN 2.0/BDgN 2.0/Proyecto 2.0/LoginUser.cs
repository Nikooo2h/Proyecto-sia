using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class LoginUser : Form
    {
        public LoginUser()
        {
            InitializeComponent();
        }

        private void entrar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=localhost; Initial Catalog = INVERSEC_3; Integrated Security=True;");
            SqlCommand comando;
            String com = "SELECT nombre,pass FROM USUARIO";
            try
            {
                comando = new SqlCommand(com, con);
                con.Open();
                comando.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(dt);
                DataRowCollection drc = dt.Rows;
                Boolean exito = false;
                foreach (DataRow r in drc)
                {
                    if ((r["nombre"].ToString().Equals(usuarios.Text)) && (r["pass"].ToString().Equals(password.Text)) && (usuarios.Text.Length != 0) && (password.Text.Length != 0))
                    {
                        Menu m = new Menu();
                        this.AddOwnedForm(m); //Login se convierte en padre de Menu, asi se puede hacer invisible.
                        this.Hide();
                        m.Show();
                        exito = true;
                    }
                }
                if (!exito)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
                con.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("Login Error:  " + x.ToString());
            }
        }

        private void LoginUser_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=localhost; Initial Catalog = INVERSEC_3; Integrated Security=True;");
            SqlCommand comando;
            String com = "Select nombre FROM USUARIO";
            try
            {
                comando = new SqlCommand(com, con);
                con.Open();
                comando.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(dt);
                DataRowCollection drc = dt.Rows;
                foreach (DataRow r in drc)
                {
                    usuarios.Items.Add(r["nombre"].ToString());
                }
                con.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("Login Error:  " + x.ToString());
            }
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginUser_Paint(object sender, PaintEventArgs e)
        {
            Rectangle fromcolor = new Rectangle(0, 0, this.Width, this.Height);
            Brush gbrush = new LinearGradientBrush(fromcolor, Color.Gold, Color.Maroon, LinearGradientMode.Vertical);
            e.Graphics.FillRectangle(gbrush, fromcolor);
        }

        private void entrar_MouseMove(object sender, MouseEventArgs e)
        {
            entrar.BackColor = Color.Maroon;
        }

        private void entrar_MouseLeave(object sender, EventArgs e)
        {
            entrar.BackColor = Color.White;
        }

        private void salir_MouseMove(object sender, MouseEventArgs e)
        {
            salir.BackColor = Color.Maroon;
        }

        private void salir_MouseLeave(object sender, EventArgs e)
        {
            salir.BackColor = Color.White;
        }

       

        
    }
}
