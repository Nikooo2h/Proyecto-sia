namespace WindowsFormsApplication1
{
    partial class Buscar_Guia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buscar_Guia));
            this.nfactura_p = new System.Windows.Forms.TextBox();
            this.rut_p = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Salir = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.Button();
            this.rutd_p = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nfactura_p
            // 
            this.nfactura_p.Location = new System.Drawing.Point(116, 32);
            this.nfactura_p.Name = "nfactura_p";
            this.nfactura_p.Size = new System.Drawing.Size(100, 20);
            this.nfactura_p.TabIndex = 0;
            this.nfactura_p.Validated += new System.EventHandler(this.nfactura_p_Validated);
            // 
            // rut_p
            // 
            this.rut_p.Location = new System.Drawing.Point(116, 58);
            this.rut_p.Name = "rut_p";
            this.rut_p.Size = new System.Drawing.Size(100, 20);
            this.rut_p.TabIndex = 1;
            this.rut_p.Validated += new System.EventHandler(this.rut_p_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rut Empresa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número de factura:";
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(214, 332);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 23);
            this.Salir.TabIndex = 4;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            this.Salir.MouseLeave += new System.EventHandler(this.Salir_MouseLeave);
            this.Salir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Salir_MouseMove);
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(303, 55);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 5;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            this.Buscar.MouseLeave += new System.EventHandler(this.Buscar_MouseLeave);
            this.Buscar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Buscar_MouseMove);
            // 
            // rutd_p
            // 
            this.rutd_p.Location = new System.Drawing.Point(239, 58);
            this.rutd_p.Name = "rutd_p";
            this.rutd_p.Size = new System.Drawing.Size(32, 20);
            this.rutd_p.TabIndex = 6;
            this.rutd_p.Validated += new System.EventHandler(this.rutd_p_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "-";
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(6, 19);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(503, 178);
            this.dgv.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox2.Controls.Add(this.dgv);
            this.groupBox2.Location = new System.Drawing.Point(12, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(515, 203);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Guias disponibles";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox1.Controls.Add(this.nfactura_p);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rut_p);
            this.groupBox1.Controls.Add(this.rutd_p);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Buscar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(18, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 95);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // Buscar_Guia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 367);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Salir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Buscar_Guia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar guia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Buscar_Guia_FormClosing);
            this.Load += new System.EventHandler(this.Buscar_Guia_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Buscar_Guia_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox nfactura_p;
        private System.Windows.Forms.TextBox rut_p;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.TextBox rutd_p;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}