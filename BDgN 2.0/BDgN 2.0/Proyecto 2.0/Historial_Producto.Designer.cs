namespace WindowsFormsApplication1
{
    partial class Historial_Producto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historial_Producto));
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fecha_fin = new System.Windows.Forms.MaskedTextBox();
            this.fecha_ini = new System.Windows.Forms.MaskedTextBox();
            this.Buscar = new System.Windows.Forms.Button();
            this.dgvi = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvs = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buscarP = new System.Windows.Forms.Button();
            this.producto = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvs)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Fecha final:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Fecha de inicio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 26;
            // 
            // fecha_fin
            // 
            this.fecha_fin.Location = new System.Drawing.Point(105, 46);
            this.fecha_fin.Name = "fecha_fin";
            this.fecha_fin.Size = new System.Drawing.Size(93, 20);
            this.fecha_fin.TabIndex = 25;
            this.fecha_fin.Validated += new System.EventHandler(this.fecha_fin_Validated);
            // 
            // fecha_ini
            // 
            this.fecha_ini.Location = new System.Drawing.Point(105, 20);
            this.fecha_ini.Name = "fecha_ini";
            this.fecha_ini.Size = new System.Drawing.Size(93, 20);
            this.fecha_ini.TabIndex = 24;
            this.fecha_ini.Validated += new System.EventHandler(this.fecha_ini_Validated);
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(225, 33);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 23;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            this.Buscar.MouseLeave += new System.EventHandler(this.Buscar_MouseLeave);
            this.Buscar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Buscar_MouseMove);
            // 
            // dgvi
            // 
            this.dgvi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvi.Location = new System.Drawing.Point(6, 19);
            this.dgvi.Name = "dgvi";
            this.dgvi.ReadOnly = true;
            this.dgvi.Size = new System.Drawing.Size(784, 200);
            this.dgvi.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox1.Controls.Add(this.dgvi);
            this.groupBox1.Location = new System.Drawing.Point(12, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 225);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresos de productos";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox2.Controls.Add(this.dgvs);
            this.groupBox2.Location = new System.Drawing.Point(12, 349);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 225);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Salidas de productos";
            // 
            // dgvs
            // 
            this.dgvs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvs.Location = new System.Drawing.Point(6, 19);
            this.dgvs.Name = "dgvs";
            this.dgvs.ReadOnly = true;
            this.dgvs.Size = new System.Drawing.Size(784, 200);
            this.dgvs.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox3.Controls.Add(this.fecha_fin);
            this.groupBox3.Controls.Add(this.Buscar);
            this.groupBox3.Controls.Add(this.fecha_ini);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 100);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fechas";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.buscarP);
            this.groupBox4.Controls.Add(this.producto);
            this.groupBox4.Location = new System.Drawing.Point(418, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(394, 100);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // buscarP
            // 
            this.buscarP.Location = new System.Drawing.Point(215, 30);
            this.buscarP.Name = "buscarP";
            this.buscarP.Size = new System.Drawing.Size(75, 23);
            this.buscarP.TabIndex = 1;
            this.buscarP.Text = "Buscar";
            this.buscarP.UseVisualStyleBackColor = true;
            this.buscarP.Click += new System.EventHandler(this.buscarP_Click);
            this.buscarP.MouseLeave += new System.EventHandler(this.buscarP_MouseLeave);
            this.buscarP.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buscarP_MouseMove);
            // 
            // producto
            // 
            this.producto.Location = new System.Drawing.Point(92, 33);
            this.producto.Name = "producto";
            this.producto.Size = new System.Drawing.Size(100, 20);
            this.producto.TabIndex = 0;
            this.producto.Validated += new System.EventHandler(this.producto_Validated);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(867, 545);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // Historial_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 583);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Historial_Producto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial_Producto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Historial_Producto_FormClosing);
            this.Load += new System.EventHandler(this.Historial_Producto_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Historial_Producto_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvs)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox fecha_fin;
        private System.Windows.Forms.MaskedTextBox fecha_ini;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.DataGridView dgvi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvs;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buscarP;
        private System.Windows.Forms.TextBox producto;
        private System.Windows.Forms.Button button1;
    }
}