namespace WindowsFormsApplication1
{
    partial class Precio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Precio));
            this.dgvp = new System.Windows.Forms.DataGridView();
            this.Salir = new System.Windows.Forms.Button();
            this.Conversion = new System.Windows.Forms.Button();
            this.Dolares = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Actualizar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtv = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvp)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvp
            // 
            this.dgvp.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvp.Location = new System.Drawing.Point(6, 15);
            this.dgvp.Name = "dgvp";
            this.dgvp.Size = new System.Drawing.Size(545, 253);
            this.dgvp.TabIndex = 0;
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(498, 363);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 23);
            this.Salir.TabIndex = 2;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            this.Salir.MouseLeave += new System.EventHandler(this.Salir_MouseLeave);
            this.Salir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Salir_MouseMove);
            // 
            // Conversion
            // 
            this.Conversion.Location = new System.Drawing.Point(220, 28);
            this.Conversion.Name = "Conversion";
            this.Conversion.Size = new System.Drawing.Size(75, 23);
            this.Conversion.TabIndex = 3;
            this.Conversion.Text = "Conversión";
            this.Conversion.UseVisualStyleBackColor = true;
            this.Conversion.Click += new System.EventHandler(this.Conversion_Click);
            this.Conversion.MouseLeave += new System.EventHandler(this.Conversion_MouseLeave);
            this.Conversion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Conversion_MouseMove);
            // 
            // Dolares
            // 
            this.Dolares.Location = new System.Drawing.Point(98, 31);
            this.Dolares.Name = "Dolares";
            this.Dolares.Size = new System.Drawing.Size(100, 20);
            this.Dolares.TabIndex = 4;
            this.Dolares.Validated += new System.EventHandler(this.Dolares_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Precio del Dolar:";
            // 
            // Actualizar
            // 
            this.Actualizar.Location = new System.Drawing.Point(352, 363);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(75, 23);
            this.Actualizar.TabIndex = 6;
            this.Actualizar.Text = "Actualizar";
            this.Actualizar.UseVisualStyleBackColor = true;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            this.Actualizar.MouseLeave += new System.EventHandler(this.Actualizar_MouseLeave);
            this.Actualizar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Actualizar_MouseMove);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox1.Controls.Add(this.rtv);
            this.groupBox1.Location = new System.Drawing.Point(620, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 381);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ayuda";
            // 
            // rtv
            // 
            this.rtv.Location = new System.Drawing.Point(6, 19);
            this.rtv.Name = "rtv";
            this.rtv.ReadOnly = true;
            this.rtv.Size = new System.Drawing.Size(298, 356);
            this.rtv.TabIndex = 0;
            this.rtv.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox2.Controls.Add(this.Dolares);
            this.groupBox2.Controls.Add(this.Conversion);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(456, 63);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dolar-Pesos";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox3.Controls.Add(this.dgvp);
            this.groupBox3.Location = new System.Drawing.Point(12, 81);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(561, 276);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // Precio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 394);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Actualizar);
            this.Controls.Add(this.Salir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Precio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Precios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Producto_FormClosing);
            this.Load += new System.EventHandler(this.marca_p_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Precio_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvp;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button Conversion;
        private System.Windows.Forms.TextBox Dolares;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Actualizar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtv;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}