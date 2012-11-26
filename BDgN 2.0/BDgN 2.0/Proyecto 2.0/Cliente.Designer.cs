namespace WindowsFormsApplication1
{
    partial class Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            this.fecha_p = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.rutd_p = new System.Windows.Forms.TextBox();
            this.titular_p = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvC = new System.Windows.Forms.DataGridView();
            this.codigo_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.des_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giro_p = new System.Windows.Forms.ComboBox();
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
            this.cancelar = new System.Windows.Forms.Button();
            this.guardar = new System.Windows.Forms.Button();
            this.nombre_p = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvC)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // fecha_p
            // 
            this.fecha_p.Location = new System.Drawing.Point(575, 29);
            this.fecha_p.Name = "fecha_p";
            this.fecha_p.Size = new System.Drawing.Size(100, 20);
            this.fecha_p.TabIndex = 75;
            this.fecha_p.Validated += new System.EventHandler(this.fecha_p_Validated);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(214, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(10, 13);
            this.label13.TabIndex = 74;
            this.label13.Text = "-";
            // 
            // rutd_p
            // 
            this.rutd_p.Location = new System.Drawing.Point(230, 58);
            this.rutd_p.Name = "rutd_p";
            this.rutd_p.Size = new System.Drawing.Size(23, 20);
            this.rutd_p.TabIndex = 73;
            this.rutd_p.Validated += new System.EventHandler(this.rutd_p_Validated);
            // 
            // titular_p
            // 
            this.titular_p.Location = new System.Drawing.Point(87, 26);
            this.titular_p.Name = "titular_p";
            this.titular_p.Size = new System.Drawing.Size(176, 20);
            this.titular_p.TabIndex = 72;
            this.titular_p.Validated += new System.EventHandler(this.titular_p_Validated);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 71;
            this.label12.Text = "Señor(es):";
            // 
            // dgvC
            // 
            this.dgvC.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo_dgv,
            this.nombre_dgv,
            this.des_dgv,
            this.cantidad_dgv,
            this.precio_dgv});
            this.dgvC.Location = new System.Drawing.Point(6, 19);
            this.dgvC.Name = "dgvC";
            this.dgvC.Size = new System.Drawing.Size(1043, 448);
            this.dgvC.TabIndex = 70;
            this.dgvC.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvC_CellEndEdit);
            this.dgvC.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvC_EditingControlShowing);
            // 
            // codigo_dgv
            // 
            this.codigo_dgv.HeaderText = "Codigo";
            this.codigo_dgv.Name = "codigo_dgv";
            this.codigo_dgv.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // nombre_dgv
            // 
            this.nombre_dgv.HeaderText = "Nombre";
            this.nombre_dgv.Name = "nombre_dgv";
            // 
            // des_dgv
            // 
            this.des_dgv.HeaderText = "Descripción";
            this.des_dgv.Name = "des_dgv";
            this.des_dgv.Width = 600;
            // 
            // cantidad_dgv
            // 
            this.cantidad_dgv.HeaderText = "Cantidad";
            this.cantidad_dgv.Name = "cantidad_dgv";
            // 
            // precio_dgv
            // 
            this.precio_dgv.HeaderText = "Precio";
            this.precio_dgv.Name = "precio_dgv";
            // 
            // giro_p
            // 
            this.giro_p.FormattingEnabled = true;
            this.giro_p.Location = new System.Drawing.Point(87, 84);
            this.giro_p.Name = "giro_p";
            this.giro_p.Size = new System.Drawing.Size(121, 21);
            this.giro_p.TabIndex = 46;
            // 
            // neto
            // 
            this.neto.Location = new System.Drawing.Point(77, 50);
            this.neto.Name = "neto";
            this.neto.Size = new System.Drawing.Size(100, 20);
            this.neto.TabIndex = 64;
            this.neto.Validated += new System.EventHandler(this.neto_Validated);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 63;
            this.label11.Text = "IVA:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 62;
            this.label10.Text = "Neto:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 61;
            this.label9.Text = "Total:";
            // 
            // iva
            // 
            this.iva.Location = new System.Drawing.Point(77, 24);
            this.iva.Name = "iva";
            this.iva.Size = new System.Drawing.Size(100, 20);
            this.iva.TabIndex = 60;
            this.iva.Validated += new System.EventHandler(this.iva_Validated);
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(77, 76);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(100, 20);
            this.total.TabIndex = 59;
            this.total.Validated += new System.EventHandler(this.total_Validated);
            // 
            // nfactura_p
            // 
            this.nfactura_p.Location = new System.Drawing.Point(334, 54);
            this.nfactura_p.Name = "nfactura_p";
            this.nfactura_p.Size = new System.Drawing.Size(165, 20);
            this.nfactura_p.TabIndex = 58;
            this.nfactura_p.Validated += new System.EventHandler(this.nfactura_p_Validated);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(522, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 57;
            this.label8.Text = "Fecha:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(267, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 56;
            this.label7.Text = "N° Factura:";
            // 
            // direccion_p
            // 
            this.direccion_p.Location = new System.Drawing.Point(334, 85);
            this.direccion_p.Name = "direccion_p";
            this.direccion_p.Size = new System.Drawing.Size(165, 20);
            this.direccion_p.TabIndex = 55;
            this.direccion_p.Validated += new System.EventHandler(this.direccion_p_Validated);
            // 
            // fono_p
            // 
            this.fono_p.Location = new System.Drawing.Point(575, 84);
            this.fono_p.Name = "fono_p";
            this.fono_p.Size = new System.Drawing.Size(165, 20);
            this.fono_p.TabIndex = 54;
            this.fono_p.Validated += new System.EventHandler(this.fono_p_Validated);
            // 
            // fax_p
            // 
            this.fax_p.Location = new System.Drawing.Point(575, 54);
            this.fax_p.Name = "fax_p";
            this.fax_p.Size = new System.Drawing.Size(165, 20);
            this.fax_p.TabIndex = 53;
            this.fax_p.TextChanged += new System.EventHandler(this.fax_p_Validated);
            // 
            // email_p
            // 
            this.email_p.Location = new System.Drawing.Point(850, 25);
            this.email_p.Name = "email_p";
            this.email_p.Size = new System.Drawing.Size(165, 20);
            this.email_p.TabIndex = 52;
            // 
            // rut_p
            // 
            this.rut_p.Location = new System.Drawing.Point(87, 57);
            this.rut_p.Name = "rut_p";
            this.rut_p.Size = new System.Drawing.Size(121, 20);
            this.rut_p.TabIndex = 51;
            this.rut_p.Validated += new System.EventHandler(this.rut_p_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(809, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(535, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Fax:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(528, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Fono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Direccion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Giro:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Rut:";
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(277, 29);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(51, 13);
            this.Label.TabIndex = 43;
            this.Label.Text = "Empresa:";
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(1152, 635);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(74, 23);
            this.cancelar.TabIndex = 77;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            this.cancelar.MouseLeave += new System.EventHandler(this.cancelar_MouseLeave);
            this.cancelar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cancelar_MouseMove);
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(1044, 635);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(74, 23);
            this.guardar.TabIndex = 76;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            this.guardar.MouseLeave += new System.EventHandler(this.guardar_MouseLeave);
            this.guardar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.guardar_MouseMove);
            // 
            // nombre_p
            // 
            this.nombre_p.FormattingEnabled = true;
            this.nombre_p.Location = new System.Drawing.Point(334, 26);
            this.nombre_p.Name = "nombre_p";
            this.nombre_p.Size = new System.Drawing.Size(165, 21);
            this.nombre_p.TabIndex = 78;
            this.nombre_p.SelectedIndexChanged += new System.EventHandler(this.nombre_p_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.nombre_p);
            this.groupBox1.Controls.Add(this.Label);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.fecha_p);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rutd_p);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.titular_p);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.rut_p);
            this.groupBox1.Controls.Add(this.email_p);
            this.groupBox1.Controls.Add(this.fax_p);
            this.groupBox1.Controls.Add(this.giro_p);
            this.groupBox1.Controls.Add(this.fono_p);
            this.groupBox1.Controls.Add(this.direccion_p);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.nfactura_p);
            this.groupBox1.Location = new System.Drawing.Point(75, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1053, 143);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox2.Controls.Add(this.dgvC);
            this.groupBox2.Location = new System.Drawing.Point(75, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1053, 468);
            this.groupBox2.TabIndex = 80;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Productos";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox3.Controls.Add(this.neto);
            this.groupBox3.Controls.Add(this.total);
            this.groupBox3.Controls.Add(this.iva);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(1134, 512);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 117);
            this.groupBox3.TabIndex = 81;
            this.groupBox3.TabStop = false;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 662);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.guardar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cliente_FormClosing);
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Cliente_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvC)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox fecha_p;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox rutd_p;
        private System.Windows.Forms.TextBox titular_p;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvC;
        private System.Windows.Forms.ComboBox giro_p;
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
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.ComboBox nombre_p;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn des_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_dgv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}