namespace WindowsFormsApplication1
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Historial_producto = new System.Windows.Forms.Button();
            this.Clasificacion = new System.Windows.Forms.Button();
            this.Precios = new System.Windows.Forms.Button();
            this.inventario = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Historial_Cliente = new System.Windows.Forms.Button();
            this.Nuevo_Cliente = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Guia = new System.Windows.Forms.Button();
            this.Historial_Proveedor = new System.Windows.Forms.Button();
            this.Nuevo_Proveedor = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.giro = new System.Windows.Forms.TextBox();
            this.direccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox1.Controls.Add(this.Historial_producto);
            this.groupBox1.Controls.Add(this.Clasificacion);
            this.groupBox1.Controls.Add(this.Precios);
            this.groupBox1.Controls.Add(this.inventario);
            this.groupBox1.Location = new System.Drawing.Point(380, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 558);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bodega";
            // 
            // Historial_producto
            // 
            this.Historial_producto.BackColor = System.Drawing.Color.White;
            this.Historial_producto.Location = new System.Drawing.Point(6, 293);
            this.Historial_producto.Name = "Historial_producto";
            this.Historial_producto.Size = new System.Drawing.Size(105, 23);
            this.Historial_producto.TabIndex = 8;
            this.Historial_producto.Text = "Historial Producto";
            this.Historial_producto.UseVisualStyleBackColor = false;
            this.Historial_producto.Click += new System.EventHandler(this.Historial_producto_Click);
            this.Historial_producto.MouseLeave += new System.EventHandler(this.Historial_producto_MouseLeave);
            this.Historial_producto.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Historial_producto_MouseMove);
            // 
            // Clasificacion
            // 
            this.Clasificacion.BackColor = System.Drawing.Color.White;
            this.Clasificacion.Location = new System.Drawing.Point(6, 213);
            this.Clasificacion.Name = "Clasificacion";
            this.Clasificacion.Size = new System.Drawing.Size(105, 23);
            this.Clasificacion.TabIndex = 7;
            this.Clasificacion.Text = "Clasificacion";
            this.Clasificacion.UseVisualStyleBackColor = false;
            this.Clasificacion.Click += new System.EventHandler(this.Clasificacion_Click);
            this.Clasificacion.MouseLeave += new System.EventHandler(this.Clasificacion_MouseLeave);
            this.Clasificacion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Clasificacion_MouseMove);
            // 
            // Precios
            // 
            this.Precios.BackColor = System.Drawing.Color.White;
            this.Precios.Location = new System.Drawing.Point(6, 133);
            this.Precios.Name = "Precios";
            this.Precios.Size = new System.Drawing.Size(105, 23);
            this.Precios.TabIndex = 6;
            this.Precios.Text = "Precios";
            this.Precios.UseVisualStyleBackColor = false;
            this.Precios.Click += new System.EventHandler(this.Agregar_Click);
            this.Precios.MouseLeave += new System.EventHandler(this.Precios_MouseLeave);
            this.Precios.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Precios_MouseMove);
            // 
            // inventario
            // 
            this.inventario.BackColor = System.Drawing.Color.White;
            this.inventario.Location = new System.Drawing.Point(6, 53);
            this.inventario.Name = "inventario";
            this.inventario.Size = new System.Drawing.Size(105, 23);
            this.inventario.TabIndex = 5;
            this.inventario.Text = "Inventario";
            this.inventario.UseVisualStyleBackColor = false;
            this.inventario.Click += new System.EventHandler(this.inventario_Click);
            this.inventario.MouseLeave += new System.EventHandler(this.inventario_MouseLeave);
            this.inventario.MouseMove += new System.Windows.Forms.MouseEventHandler(this.inventario_MouseMove);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox3.Controls.Add(this.Historial_Cliente);
            this.groupBox3.Controls.Add(this.Nuevo_Cliente);
            this.groupBox3.Location = new System.Drawing.Point(680, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(197, 558);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cliente";
            // 
            // Historial_Cliente
            // 
            this.Historial_Cliente.BackColor = System.Drawing.Color.White;
            this.Historial_Cliente.Location = new System.Drawing.Point(15, 133);
            this.Historial_Cliente.Name = "Historial_Cliente";
            this.Historial_Cliente.Size = new System.Drawing.Size(105, 23);
            this.Historial_Cliente.TabIndex = 8;
            this.Historial_Cliente.Text = "Historial Cliente";
            this.Historial_Cliente.UseVisualStyleBackColor = false;
            this.Historial_Cliente.Click += new System.EventHandler(this.Historial_Cliente_Click);
            this.Historial_Cliente.MouseLeave += new System.EventHandler(this.Historial_Cliente_MouseLeave);
            this.Historial_Cliente.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Historial_Cliente_MouseMove);
            // 
            // Nuevo_Cliente
            // 
            this.Nuevo_Cliente.BackColor = System.Drawing.Color.White;
            this.Nuevo_Cliente.Location = new System.Drawing.Point(15, 53);
            this.Nuevo_Cliente.Name = "Nuevo_Cliente";
            this.Nuevo_Cliente.Size = new System.Drawing.Size(105, 23);
            this.Nuevo_Cliente.TabIndex = 7;
            this.Nuevo_Cliente.Text = "Nuevo Cliente";
            this.Nuevo_Cliente.UseVisualStyleBackColor = false;
            this.Nuevo_Cliente.Click += new System.EventHandler(this.Nuevo_Cliente_Click);
            this.Nuevo_Cliente.MouseLeave += new System.EventHandler(this.Nuevo_Cliente_MouseLeave);
            this.Nuevo_Cliente.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Nuevo_Cliente_MouseMove);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox4.Controls.Add(this.Guia);
            this.groupBox4.Controls.Add(this.Historial_Proveedor);
            this.groupBox4.Controls.Add(this.Nuevo_Proveedor);
            this.groupBox4.Location = new System.Drawing.Point(980, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(197, 558);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Proveedor";
            // 
            // Guia
            // 
            this.Guia.BackColor = System.Drawing.Color.White;
            this.Guia.Location = new System.Drawing.Point(16, 213);
            this.Guia.Name = "Guia";
            this.Guia.Size = new System.Drawing.Size(105, 23);
            this.Guia.TabIndex = 9;
            this.Guia.Text = "Guia";
            this.Guia.UseVisualStyleBackColor = false;
            this.Guia.Click += new System.EventHandler(this.button2_Click);
            this.Guia.MouseLeave += new System.EventHandler(this.Guia_MouseLeave);
            this.Guia.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Guia_MouseMove);
            // 
            // Historial_Proveedor
            // 
            this.Historial_Proveedor.BackColor = System.Drawing.Color.White;
            this.Historial_Proveedor.Location = new System.Drawing.Point(16, 133);
            this.Historial_Proveedor.Name = "Historial_Proveedor";
            this.Historial_Proveedor.Size = new System.Drawing.Size(105, 23);
            this.Historial_Proveedor.TabIndex = 8;
            this.Historial_Proveedor.Text = "Historial Proveedor";
            this.Historial_Proveedor.UseVisualStyleBackColor = false;
            this.Historial_Proveedor.Click += new System.EventHandler(this.Historial_Proveedor_Click);
            this.Historial_Proveedor.MouseLeave += new System.EventHandler(this.Historial_Proveedor_MouseLeave);
            this.Historial_Proveedor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Historial_Proveedor_MouseMove);
            // 
            // Nuevo_Proveedor
            // 
            this.Nuevo_Proveedor.BackColor = System.Drawing.Color.White;
            this.Nuevo_Proveedor.Location = new System.Drawing.Point(16, 53);
            this.Nuevo_Proveedor.Name = "Nuevo_Proveedor";
            this.Nuevo_Proveedor.Size = new System.Drawing.Size(105, 23);
            this.Nuevo_Proveedor.TabIndex = 7;
            this.Nuevo_Proveedor.Text = "Nuevo Proveedor";
            this.Nuevo_Proveedor.UseVisualStyleBackColor = false;
            this.Nuevo_Proveedor.Click += new System.EventHandler(this.Nuevo_Proveedor_Click);
            this.Nuevo_Proveedor.MouseLeave += new System.EventHandler(this.Nuevo_Proveedor_MouseLeave);
            this.Nuevo_Proveedor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Nuevo_Proveedor_MouseMove);
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.White;
            this.Salir.Location = new System.Drawing.Point(550, 589);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 23);
            this.Salir.TabIndex = 23;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.button1_Click);
            this.Salir.MouseLeave += new System.EventHandler(this.Salir_MouseLeave);
            this.Salir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Salir_MouseMove);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.nombre);
            this.groupBox2.Controls.Add(this.giro);
            this.groupBox2.Controls.Add(this.direccion);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(21, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 436);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Empresa";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(66, 215);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 111);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(145, 50);
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Size = new System.Drawing.Size(169, 20);
            this.nombre.TabIndex = 10;
            // 
            // giro
            // 
            this.giro.Location = new System.Drawing.Point(145, 90);
            this.giro.Name = "giro";
            this.giro.ReadOnly = true;
            this.giro.Size = new System.Drawing.Size(169, 20);
            this.giro.TabIndex = 9;
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(145, 129);
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Size = new System.Drawing.Size(169, 20);
            this.direccion.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Dirección:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giro:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Empresa:";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1184, 639);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Menu_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button Clasificacion;
        private System.Windows.Forms.Button Precios;
        private System.Windows.Forms.Button inventario;
        private System.Windows.Forms.Button Historial_Cliente;
        private System.Windows.Forms.Button Nuevo_Cliente;
        private System.Windows.Forms.Button Historial_Proveedor;
        private System.Windows.Forms.Button Nuevo_Proveedor;
        private System.Windows.Forms.Button Guia;
        private System.Windows.Forms.Button Historial_producto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox giro;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}