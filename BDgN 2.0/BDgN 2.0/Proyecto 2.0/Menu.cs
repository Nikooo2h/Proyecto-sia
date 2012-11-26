using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Menu : Form
    {
        ToolTip tt;
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Paint(object sender, PaintEventArgs e)
        {
            Rectangle fromcolor = new Rectangle(0, 0, this.Width, this.Height);
            Brush gbrush = new LinearGradientBrush(fromcolor, Color.Gold, Color.Maroon, LinearGradientMode.Vertical);
            e.Graphics.FillRectangle(gbrush, fromcolor);
        }

        private void inventario_Click(object sender, EventArgs e)
        {
            Inventario inv = new Inventario();
            this.AddOwnedForm(inv);
            this.Hide();
            inv.Show();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            Precio pr = new Precio();
            this.AddOwnedForm(pr);
            this.Hide();
            pr.Show();
        }

        private void Clasificacion_Click(object sender, EventArgs e)
        {
            Clasificaciones cs = new Clasificaciones();
            this.AddOwnedForm(cs);
            this.Hide();
            cs.Show();
        }

        private void Nuevo_Cliente_Click(object sender, EventArgs e)
        {
            Cliente cl = new Cliente();
            this.AddOwnedForm(cl);
            this.Hide();
            cl.Show();
        }

        private void Historial_Cliente_Click(object sender, EventArgs e)
        {
            Historial_Cliente cl = new Historial_Cliente();
            this.AddOwnedForm(cl);
            this.Hide();
            cl.Show();
        }

        private void Nuevo_Proveedor_Click(object sender, EventArgs e)
        {
            Proveedor pro = new Proveedor();
            this.AddOwnedForm(pro);
            this.Hide();
            pro.Show();
        }

        private void Historial_Proveedor_Click(object sender, EventArgs e)
        {
            Historial_Proveedor hpro = new Historial_Proveedor();
            this.AddOwnedForm(hpro);
            this.Hide();
            hpro.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Buscar_Guia g = new Buscar_Guia();
            this.AddOwnedForm(g);
            this.Hide();
            g.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            nombre.Text="INVERSEC Chile LTDA";
            direccion.Text = "Rio Tolten nº 2610 Lampa";
            giro.Text="Distribución Climatización";
            tt = new ToolTip();
            tt.AutoPopDelay = 10000;
            tt.SetToolTip(inventario,TextoAyuda.m_inventario);
            tt.SetToolTip(Precios,TextoAyuda.m_precios);
            tt.SetToolTip(Clasificacion,TextoAyuda.m_clasificacion);
            tt.SetToolTip(Nuevo_Cliente,TextoAyuda.m_cliente);
            tt.SetToolTip(Historial_Cliente,TextoAyuda.m_hcliente);
            tt.SetToolTip(Nuevo_Proveedor, TextoAyuda.m_proveedor);
            tt.SetToolTip(Historial_Proveedor,TextoAyuda.m_hproveedor);
            tt.SetToolTip(Guia,TextoAyuda.m_guia);
        }
        private void inventario_MouseMove(object sender, MouseEventArgs e)
        {
            inventario.BackColor = Color.Maroon;
        }

        private void inventario_MouseLeave(object sender, EventArgs e)
        {
            inventario.BackColor = Color.White;
        }

        private void Precios_MouseMove(object sender, MouseEventArgs e)
        {
            Precios.BackColor = Color.Maroon;
        }

        private void Precios_MouseLeave(object sender, EventArgs e)
        {
            Precios.BackColor = Color.White;
        }

        private void Clasificacion_MouseMove(object sender, MouseEventArgs e)
        {
            Clasificacion.BackColor = Color.Maroon;
        }

        private void Clasificacion_MouseLeave(object sender, EventArgs e)
        {
            Clasificacion.BackColor = Color.White;
        }

        private void Nuevo_Cliente_MouseMove(object sender, MouseEventArgs e)
        {
            Nuevo_Cliente.BackColor = Color.Maroon;
        }

        private void Nuevo_Cliente_MouseLeave(object sender, EventArgs e)
        {
            Nuevo_Cliente.BackColor = Color.White;
        }

        private void Historial_Cliente_MouseMove(object sender, MouseEventArgs e)
        {
            Historial_Cliente.BackColor = Color.Maroon;
        }

        private void Historial_Cliente_MouseLeave(object sender, EventArgs e)
        {
            Historial_Cliente.BackColor = Color.White;
        }

        private void Nuevo_Proveedor_MouseMove(object sender, MouseEventArgs e)
        {
            Nuevo_Proveedor.BackColor = Color.Maroon;
        }

        private void Nuevo_Proveedor_MouseLeave(object sender, EventArgs e)
        {
            Nuevo_Proveedor.BackColor = Color.White;
        }

        private void Historial_Proveedor_MouseMove(object sender, MouseEventArgs e)
        {
            Historial_Proveedor.BackColor = Color.Maroon;
        }

        private void Historial_Proveedor_MouseLeave(object sender, EventArgs e)
        {
            Historial_Proveedor.BackColor = Color.White;
        }

        private void Guia_MouseMove(object sender, MouseEventArgs e)
        {
            Guia.BackColor = Color.Maroon;
        }

        private void Guia_MouseLeave(object sender, EventArgs e)
        {
            Guia.BackColor = Color.White;
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void Historial_producto_Click(object sender, EventArgs e)
        {
            Historial_Producto hp=new Historial_Producto();
            this.AddOwnedForm(hp);
            this.Hide();
            hp.Show();
        }

        private void Historial_producto_MouseMove(object sender, MouseEventArgs e)
        {
            Historial_producto.BackColor = Color.Maroon;
        }

        private void Historial_producto_MouseLeave(object sender, EventArgs e)
        {
            Historial_producto.BackColor = Color.White;
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
