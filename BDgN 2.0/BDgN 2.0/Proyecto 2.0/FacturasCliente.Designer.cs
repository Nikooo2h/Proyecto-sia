namespace WindowsFormsApplication1
{
    partial class FacturasCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacturasCliente));
            this.fecha_p = new System.Windows.Forms.MaskedTextBox();
            this.titular_p = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_p = new System.Windows.Forms.TextBox();
            this.neto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.iva = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.TextBox();
            this.nfactura_p = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.direccion_p = new System.Windows.Forms.TextBox();
            this.fono_p = new System.Windows.Forms.TextBox();
            this.fax_p = new System.Windows.Forms.TextBox();
            this.email_p = new System.Windows.Forms.TextBox();
            this.rut_p = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.giro_p = new System.Windows.Forms.TextBox();
            this.Salir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // fecha_p
            // 
            this.fecha_p.Location = new System.Drawing.Point(565, 21);
            this.fecha_p.Name = "fecha_p";
            this.fecha_p.ReadOnly = true;
            this.fecha_p.Size = new System.Drawing.Size(100, 20);
            this.fecha_p.TabIndex = 75;
            // 
            // titular_p
            // 
            this.titular_p.Location = new System.Drawing.Point(77, 22);
            this.titular_p.Name = "titular_p";
            this.titular_p.ReadOnly = true;
            this.titular_p.Size = new System.Drawing.Size(176, 20);
            this.titular_p.TabIndex = 72;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 71;
            this.label12.Text = "Señor(es):";
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv.Location = new System.Drawing.Point(6, 19);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(1043, 448);
            this.dgv.TabIndex = 70;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Descripción";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 600;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cantidad";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Precio";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // nombre_p
            // 
            this.nombre_p.Location = new System.Drawing.Point(324, 22);
            this.nombre_p.Name = "nombre_p";
            this.nombre_p.ReadOnly = true;
            this.nombre_p.Size = new System.Drawing.Size(165, 20);
            this.nombre_p.TabIndex = 66;
            // 
            // neto
            // 
            this.neto.Location = new System.Drawing.Point(80, 45);
            this.neto.Name = "neto";
            this.neto.ReadOnly = true;
            this.neto.Size = new System.Drawing.Size(100, 20);
            this.neto.TabIndex = 64;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 63;
            this.label11.Text = "IVA:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 62;
            this.label10.Text = "Neto:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 61;
            this.label9.Text = "Total:";
            // 
            // iva
            // 
            this.iva.Location = new System.Drawing.Point(80, 19);
            this.iva.Name = "iva";
            this.iva.ReadOnly = true;
            this.iva.Size = new System.Drawing.Size(100, 20);
            this.iva.TabIndex = 60;
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(80, 71);
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Size = new System.Drawing.Size(100, 20);
            this.total.TabIndex = 59;
            // 
            // nfactura_p
            // 
            this.nfactura_p.Location = new System.Drawing.Point(324, 54);
            this.nfactura_p.Name = "nfactura_p";
            this.nfactura_p.ReadOnly = true;
            this.nfactura_p.Size = new System.Drawing.Size(165, 20);
            this.nfactura_p.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(512, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 57;
            this.label8.Text = "Fecha:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 56;
            this.label7.Text = "N° Factura:";
            // 
            // direccion_p
            // 
            this.direccion_p.Location = new System.Drawing.Point(324, 85);
            this.direccion_p.Name = "direccion_p";
            this.direccion_p.ReadOnly = true;
            this.direccion_p.Size = new System.Drawing.Size(165, 20);
            this.direccion_p.TabIndex = 55;
            // 
            // fono_p
            // 
            this.fono_p.Location = new System.Drawing.Point(565, 84);
            this.fono_p.Name = "fono_p";
            this.fono_p.ReadOnly = true;
            this.fono_p.Size = new System.Drawing.Size(165, 20);
            this.fono_p.TabIndex = 54;
            // 
            // fax_p
            // 
            this.fax_p.Location = new System.Drawing.Point(565, 54);
            this.fax_p.Name = "fax_p";
            this.fax_p.ReadOnly = true;
            this.fax_p.Size = new System.Drawing.Size(165, 20);
            this.fax_p.TabIndex = 53;
            // 
            // email_p
            // 
            this.email_p.Location = new System.Drawing.Point(793, 22);
            this.email_p.Name = "email_p";
            this.email_p.ReadOnly = true;
            this.email_p.Size = new System.Drawing.Size(165, 20);
            this.email_p.TabIndex = 52;
            // 
            // rut_p
            // 
            this.rut_p.Location = new System.Drawing.Point(77, 57);
            this.rut_p.Multiline = true;
            this.rut_p.Name = "rut_p";
            this.rut_p.ReadOnly = true;
            this.rut_p.Size = new System.Drawing.Size(176, 20);
            this.rut_p.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(752, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(525, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Fax:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(518, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Fono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Direccion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Giro:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Rut:";
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(267, 29);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(51, 13);
            this.Label.TabIndex = 43;
            this.Label.Text = "Empresa:";
            // 
            // giro_p
            // 
            this.giro_p.Location = new System.Drawing.Point(77, 88);
            this.giro_p.Name = "giro_p";
            this.giro_p.ReadOnly = true;
            this.giro_p.Size = new System.Drawing.Size(176, 20);
            this.giro_p.TabIndex = 76;
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(682, 635);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(87, 23);
            this.Salir.TabIndex = 77;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            this.Salir.MouseLeave += new System.EventHandler(this.Salir_MouseLeave);
            this.Salir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Salir_MouseMove);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox1.Controls.Add(this.neto);
            this.groupBox1.Controls.Add(this.total);
            this.groupBox1.Controls.Add(this.iva);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(1133, 494);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 118);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox2.Controls.Add(this.dgv);
            this.groupBox2.Location = new System.Drawing.Point(71, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1056, 473);
            this.groupBox2.TabIndex = 79;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Productos";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox3.Controls.Add(this.nfactura_p);
            this.groupBox3.Controls.Add(this.Label);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.giro_p);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.fecha_p);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.titular_p);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.nombre_p);
            this.groupBox3.Controls.Add(this.rut_p);
            this.groupBox3.Controls.Add(this.email_p);
            this.groupBox3.Controls.Add(this.fax_p);
            this.groupBox3.Controls.Add(this.fono_p);
            this.groupBox3.Controls.Add(this.direccion_p);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(71, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1056, 114);
            this.groupBox3.TabIndex = 79;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Factura";
            // 
            // FacturasCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 662);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Salir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FacturasCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FacturasCliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FacturasCliente_FormClosing);
            this.Load += new System.EventHandler(this.FacturasCliente_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FacturasCliente_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox fecha_p;
        private System.Windows.Forms.TextBox titular_p;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox nombre_p;
        private System.Windows.Forms.TextBox neto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox iva;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.TextBox nfactura_p;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox direccion_p;
        private System.Windows.Forms.TextBox fono_p;
        private System.Windows.Forms.TextBox fax_p;
        private System.Windows.Forms.TextBox email_p;
        private System.Windows.Forms.TextBox rut_p;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.TextBox giro_p;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}