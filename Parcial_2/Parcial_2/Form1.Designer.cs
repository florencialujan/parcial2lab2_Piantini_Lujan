namespace Parcial_2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBermuda = new System.Windows.Forms.CheckBox();
            this.cMangaCorta = new System.Windows.Forms.CheckBox();
            this.rPantalon = new System.Windows.Forms.RadioButton();
            this.rCamisa = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.premium = new System.Windows.Forms.RadioButton();
            this.standard = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.precio = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cantidad = new System.Windows.Forms.TextBox();
            this.BotonCalcular = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "VENTAS AL POR MAYOR - DeoLicaprio";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rPantalon);
            this.groupBox1.Controls.Add(this.rCamisa);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(110, 95);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de prenda";
            // 
            // cBermuda
            // 
            this.cBermuda.AutoSize = true;
            this.cBermuda.Location = new System.Drawing.Point(164, 110);
            this.cBermuda.Name = "cBermuda";
            this.cBermuda.Size = new System.Drawing.Size(68, 17);
            this.cBermuda.TabIndex = 5;
            this.cBermuda.Text = "Bermuda";
            this.cBermuda.UseVisualStyleBackColor = true;
            // 
            // cMangaCorta
            // 
            this.cMangaCorta.AutoSize = true;
            this.cMangaCorta.Location = new System.Drawing.Point(164, 73);
            this.cMangaCorta.Name = "cMangaCorta";
            this.cMangaCorta.Size = new System.Drawing.Size(86, 17);
            this.cMangaCorta.TabIndex = 4;
            this.cMangaCorta.Text = "Manga corta";
            this.cMangaCorta.UseVisualStyleBackColor = true;
            // 
            // rPantalon
            // 
            this.rPantalon.AutoSize = true;
            this.rPantalon.Location = new System.Drawing.Point(6, 57);
            this.rPantalon.Name = "rPantalon";
            this.rPantalon.Size = new System.Drawing.Size(75, 19);
            this.rPantalon.TabIndex = 3;
            this.rPantalon.TabStop = true;
            this.rPantalon.Text = "Pantalón";
            this.rPantalon.UseVisualStyleBackColor = true;
            this.rPantalon.CheckedChanged += new System.EventHandler(this.rPantalon_CheckedChanged);
            // 
            // rCamisa
            // 
            this.rCamisa.AutoSize = true;
            this.rCamisa.Checked = true;
            this.rCamisa.Location = new System.Drawing.Point(6, 22);
            this.rCamisa.Name = "rCamisa";
            this.rCamisa.Size = new System.Drawing.Size(66, 19);
            this.rCamisa.TabIndex = 2;
            this.rCamisa.TabStop = true;
            this.rCamisa.Text = "Camisa";
            this.rCamisa.UseVisualStyleBackColor = true;
            this.rCamisa.CheckedChanged += new System.EventHandler(this.rCamisa_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.premium);
            this.groupBox2.Controls.Add(this.standard);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(36, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 66);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calidad de prenda";
            // 
            // premium
            // 
            this.premium.AutoSize = true;
            this.premium.Location = new System.Drawing.Point(98, 31);
            this.premium.Name = "premium";
            this.premium.Size = new System.Drawing.Size(74, 19);
            this.premium.TabIndex = 1;
            this.premium.TabStop = true;
            this.premium.Text = "Premium";
            this.premium.UseVisualStyleBackColor = true;
            // 
            // standard
            // 
            this.standard.AutoSize = true;
            this.standard.Checked = true;
            this.standard.Location = new System.Drawing.Point(6, 31);
            this.standard.Name = "standard";
            this.standard.Size = new System.Drawing.Size(75, 19);
            this.standard.TabIndex = 0;
            this.standard.TabStop = true;
            this.standard.Text = "Standard";
            this.standard.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.precio);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(21, 233);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(113, 59);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Precio";
            // 
            // precio
            // 
            this.precio.Location = new System.Drawing.Point(9, 25);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(81, 26);
            this.precio.TabIndex = 5;
            this.precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.compruebaSoloNumeros);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cantidad);
            this.groupBox4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(140, 233);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(108, 59);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cantidad";
            // 
            // cantidad
            // 
            this.cantidad.Location = new System.Drawing.Point(6, 25);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(87, 26);
            this.cantidad.TabIndex = 6;
            this.cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.compruebaSoloNumeros);
            // 
            // BotonCalcular
            // 
            this.BotonCalcular.BackColor = System.Drawing.Color.SpringGreen;
            this.BotonCalcular.Location = new System.Drawing.Point(59, 308);
            this.BotonCalcular.Name = "BotonCalcular";
            this.BotonCalcular.Size = new System.Drawing.Size(162, 38);
            this.BotonCalcular.TabIndex = 5;
            this.BotonCalcular.Text = "Calcular Precio Final";
            this.BotonCalcular.UseVisualStyleBackColor = false;
            this.BotonCalcular.Click += new System.EventHandler(this.BotonCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 358);
            this.Controls.Add(this.cBermuda);
            this.Controls.Add(this.cMangaCorta);
            this.Controls.Add(this.BotonCalcular);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ventas al por mayor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cBermuda;
        private System.Windows.Forms.CheckBox cMangaCorta;
        private System.Windows.Forms.RadioButton rPantalon;
        private System.Windows.Forms.RadioButton rCamisa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton premium;
        private System.Windows.Forms.RadioButton standard;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox cantidad;
        private System.Windows.Forms.Button BotonCalcular;
    }
}

