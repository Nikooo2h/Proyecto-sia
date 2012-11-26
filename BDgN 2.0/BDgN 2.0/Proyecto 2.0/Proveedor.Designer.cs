namespace WindowsFormsApplication1
{
    partial class Proveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proveedor));
            this.label12 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fecha_p = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.rutd_p = new System.Windows.Forms.TextBox();
            this.titular_p = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvP = new System.Windows.Forms.DataGridView();
            this.codigo_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.des_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.precio_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factura_p = new System.Windows.Forms.RadioButton();
            this.guia_p = new System.Windows.Forms.RadioButton();
            this.label27 = new System.Windows.Forms.Label();
            this.giro_p = new System.Windows.Forms.ComboBox();
            this.nfactura_p = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.direccion_p = new System.Windows.Forms.TextBox();
            this.fono_p = new System.Windows.Forms.TextBox();
            this.fax_p = new System.Windows.Forms.TextBox();
            this.email_p = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.neto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.iva = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.TextBox();
            this.cancelar = new System.Windows.Forms.Button();
            this.guardar = new System.Windows.Forms.Button();
            this.nombre_p = new System.Windows.Forms.ComboBox();
            this.rut_p = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvP)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(-69, -5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 67;
            this.label12.Text = "Señor(es):";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(-72, -33);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(46, 13);
            this.label25.TabIndex = 61;
            this.label25.Text = "Factura:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-72, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Giro:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-70, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Rut:";
            // 
            // fecha_p
            // 
            this.fecha_p.Location = new System.Drawing.Point(650, 26);
            this.fecha_p.Name = "fecha_p";
            this.fecha_p.Size = new System.Drawing.Size(100, 20);
            this.fecha_p.TabIndex = 96;
            this.fecha_p.Validated += new System.EventHandler(this.fecha_p_Validated);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(208, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(10, 13);
            this.label13.TabIndex = 95;
            this.label13.Text = "-";
            // 
            // rutd_p
            // 
            this.rutd_p.Location = new System.Drawing.Point(224, 55);
            this.rutd_p.Name = "rutd_p";
            this.rutd_p.Size = new System.Drawing.Size(23, 20);
            this.rutd_p.TabIndex = 94;
            this.rutd_p.Validated += new System.EventHandler(this.rutd_p_Validated);
            // 
            // titular_p
            // 
            this.titular_p.Location = new System.Drawing.Point(81, 23);
            this.titular_p.Name = "titular_p";
            this.titular_p.Size = new System.Drawing.Size(176, 20);
            this.titular_p.TabIndex = 93;
            this.titular_p.Validated += new System.EventHandler(this.titular_p_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 92;
            this.label3.Text = "Señor(es):";
            // 
            // dgvP
            // 
            this.dgvP.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo_dgv,
            this.nombre_dgv,
            this.Column1,
            this.Column2,
            this.Column3,
            this.des_dgv,
            this.cantidad_dgv,
            this.Column4,
            this.precio_dgv});
            this.dgvP.Location = new System.Drawing.Point(6, 18);
            this.dgvP.Name = "dgvP";
            this.dgvP.Size = new System.Drawing.Size(1144, 448);
            this.dgvP.TabIndex = 91;
            this.dgvP.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvP_CellEndEdit);
            this.dgvP.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvP_EditingControlShowing);
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
            // Column1
            // 
            this.Column1.HeaderText = "Modelo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Marca";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Clasificacion";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // des_dgv
            // 
            this.des_dgv.HeaderText = "Descripción";
            this.des_dgv.Name = "des_dgv";
            this.des_dgv.Width = 300;
            // 
            // cantidad_dgv
            // 
            this.cantidad_dgv.HeaderText = "Cantidad";
            this.cantidad_dgv.Name = "cantidad_dgv";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Bodega";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // precio_dgv
            // 
            this.precio_dgv.HeaderText = "Precio";
            this.precio_dgv.Name = "precio_dgv";
            // 
            // factura_p
            // 
            this.factura_p.AutoSize = true;
            this.factura_p.Checked = true;
            this.factura_p.Location = new System.Drawing.Point(925, 72);
            this.factura_p.Name = "factura_p";
            this.factura_p.Size = new System.Drawing.Size(61, 17);
            this.factura_p.TabIndex = 90;
            this.factura_p.TabStop = true;
            this.factura_p.Text = "Factura";
            this.factura_p.UseVisualStyleBackColor = true;
            // 
            // guia_p
            // 
            this.guia_p.AutoSize = true;
            this.guia_p.Location = new System.Drawing.Point(925, 95);
            this.guia_p.Name = "guia_p";
            this.guia_p.Size = new System.Drawing.Size(47, 17);
            this.guia_p.TabIndex = 89;
            this.guia_p.TabStop = true;
            this.guia_p.Text = "Guia";
            this.guia_p.UseVisualStyleBackColor = true;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(860, 56);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(73, 13);
            this.label27.TabIndex = 88;
            this.label27.Text = "Factura/Guia:";
            // 
            // giro_p
            // 
            this.giro_p.FormattingEnabled = true;
            this.giro_p.Location = new System.Drawing.Point(81, 81);
            this.giro_p.Name = "giro_p";
            this.giro_p.Size = new System.Drawing.Size(121, 21);
            this.giro_p.TabIndex = 71;
            // 
            // nfactura_p
            // 
            this.nfactura_p.Location = new System.Drawing.Point(375, 50);
            this.nfactura_p.Name = "nfactura_p";
            this.nfactura_p.Size = new System.Drawing.Size(165, 20);
            this.nfactura_p.TabIndex = 83;
            this.nfactura_p.Validated += new System.EventHandler(this.nfactura_p_Validated);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(597, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 82;
            this.label8.Text = "Fecha:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(308, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 81;
            this.label7.Text = "N° Factura:";
            // 
            // direccion_p
            // 
            this.direccion_p.Location = new System.Drawing.Point(375, 81);
            this.direccion_p.Name = "direccion_p";
            this.direccion_p.Size = new System.Drawing.Size(165, 20);
            this.direccion_p.TabIndex = 80;
            this.direccion_p.Validated += new System.EventHandler(this.direccion_p_Validated);
            // 
            // fono_p
            // 
            this.fono_p.Location = new System.Drawing.Point(650, 81);
            this.fono_p.Name = "fono_p";
            this.fono_p.Size = new System.Drawing.Size(165, 20);
            this.fono_p.TabIndex = 79;
            this.fono_p.Validated += new System.EventHandler(this.fono_p_Validated);
            // 
            // fax_p
            // 
            this.fax_p.Location = new System.Drawing.Point(650, 51);
            this.fax_p.Name = "fax_p";
            this.fax_p.Size = new System.Drawing.Size(165, 20);
            this.fax_p.TabIndex = 78;
            this.fax_p.Validated += new System.EventHandler(this.fax_p_Validated);
            // 
            // email_p
            // 
            this.email_p.Location = new System.Drawing.Point(939, 18);
            this.email_p.Name = "email_p";
            this.email_p.Size = new System.Drawing.Size(165, 20);
            this.email_p.TabIndex = 77;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(898, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 75;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(610, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 74;
            this.label5.Text = "Fax:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(603, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 73;
            this.label11.Text = "Fono:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(314, 88);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 72;
            this.label14.Text = "Direccion:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 88);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 13);
            this.label15.TabIndex = 70;
            this.label15.Text = "Giro:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(19, 58);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 13);
            this.label16.TabIndex = 69;
            this.label16.Text = "Rut:";
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(318, 25);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(51, 13);
            this.Label.TabIndex = 68;
            this.Label.Text = "Empresa:";
            // 
            // neto
            // 
            this.neto.Location = new System.Drawing.Point(50, 48);
            this.neto.Name = "neto";
            this.neto.Size = new System.Drawing.Size(100, 20);
            this.neto.TabIndex = 104;
            this.neto.Validated += new System.EventHandler(this.neto_Validated);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 103;
            this.label9.Text = "IVA:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 102;
            this.label10.Text = "Neto:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 77);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 13);
            this.label17.TabIndex = 101;
            this.label17.Text = "Total:";
            // 
            // iva
            // 
            this.iva.Location = new System.Drawing.Point(50, 22);
            this.iva.Name = "iva";
            this.iva.Size = new System.Drawing.Size(100, 20);
            this.iva.TabIndex = 100;
            this.iva.Validated += new System.EventHandler(this.iva_Validated);
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(50, 74);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(100, 20);
            this.total.TabIndex = 99;
            this.total.Validated += new System.EventHandler(this.total_Validated);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(1093, 635);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 98;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click_1);
            this.cancelar.MouseLeave += new System.EventHandler(this.cancelar_MouseLeave);
            this.cancelar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cancelar_MouseMove);
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(980, 635);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(75, 23);
            this.guardar.TabIndex = 97;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click_1);
            this.guardar.MouseLeave += new System.EventHandler(this.guardar_MouseLeave);
            this.guardar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.guardar_MouseMove);
            // 
            // nombre_p
            // 
            this.nombre_p.FormattingEnabled = true;
            this.nombre_p.Location = new System.Drawing.Point(375, 22);
            this.nombre_p.Name = "nombre_p";
            this.nombre_p.Size = new System.Drawing.Size(165, 21);
            this.nombre_p.TabIndex = 105;
            this.nombre_p.SelectedIndexChanged += new System.EventHandler(this.nombre_p_SelectedIndexChanged);
            // 
            // rut_p
            // 
            this.rut_p.Location = new System.Drawing.Point(81, 54);
            this.rut_p.Name = "rut_p";
            this.rut_p.Size = new System.Drawing.Size(121, 20);
            this.rut_p.TabIndex = 76;
            this.rut_p.Validated += new System.EventHandler(this.rut_p_Validated);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.dgvP);
            this.groupBox1.Location = new System.Drawing.Point(12, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1156, 474);
            this.groupBox1.TabIndex = 106;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Producto";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(1156, 279);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 195);
            this.groupBox3.TabIndex = 107;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox2.Controls.Add(this.neto);
            this.groupBox2.Controls.Add(this.total);
            this.groupBox2.Controls.Add(this.iva);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(1174, 505);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(162, 124);
            this.groupBox2.TabIndex = 92;
            this.groupBox2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox4.Controls.Add(this.nfactura_p);
            this.groupBox4.Controls.Add(this.Label);
            this.groupBox4.Controls.Add(this.nombre_p);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.fecha_p);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.rutd_p);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.titular_p);
            this.groupBox4.Controls.Add(this.rut_p);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.email_p);
            this.groupBox4.Controls.Add(this.factura_p);
            this.groupBox4.Controls.Add(this.fax_p);
            this.groupBox4.Controls.Add(this.guia_p);
            this.groupBox4.Controls.Add(this.fono_p);
            this.groupBox4.Controls.Add(this.label27);
            this.groupBox4.Controls.Add(this.direccion_p);
            this.groupBox4.Controls.Add(this.giro_p);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(12, 31);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1156, 118);
            this.groupBox4.TabIndex = 107;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Proveedor";
            // 
            // Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 662);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Proveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Proveedor_FormClosing);
            this.Load += new System.EventHandler(this.Proveedor_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Proveedor_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox fecha_p;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox rutd_p;
        private System.Windows.Forms.TextBox titular_p;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvP;
        private System.Windows.Forms.RadioButton factura_p;
        private System.Windows.Forms.RadioButton guia_p;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox giro_p;
        private System.Windows.Forms.TextBox nfactura_p;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox direccion_p;
        private System.Windows.Forms.TextBox fono_p;
        private System.Windows.Forms.TextBox fax_p;
        private System.Windows.Forms.TextBox email_p;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.TextBox neto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox iva;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.ComboBox nombre_p;
        private System.Windows.Forms.TextBox rut_p;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn des_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_dgv;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_dgv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}