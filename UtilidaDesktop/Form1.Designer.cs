namespace UtilidaDesktop {
    partial class Form1 {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_a = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_b = new System.Windows.Forms.Button();
            this.btn_c = new System.Windows.Forms.Button();
            this.btn_d = new System.Windows.Forms.Button();
            this.saveFileArchivo1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btn_a
            // 
            this.btn_a.BackColor = System.Drawing.Color.Black;
            this.btn_a.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_a.ForeColor = System.Drawing.Color.Lime;
            this.btn_a.Location = new System.Drawing.Point(49, 30);
            this.btn_a.Name = "btn_a";
            this.btn_a.Size = new System.Drawing.Size(326, 39);
            this.btn_a.TabIndex = 1;
            this.btn_a.Text = " Temporizador Apagar PC";
            this.btn_a.UseVisualStyleBackColor = false;
            this.btn_a.Click += new System.EventHandler(this.btn_a_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.Black;
            this.btn_salir.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.Color.Lime;
            this.btn_salir.Location = new System.Drawing.Point(120, 446);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(171, 39);
            this.btn_salir.TabIndex = 5;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_b
            // 
            this.btn_b.BackColor = System.Drawing.Color.Black;
            this.btn_b.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_b.ForeColor = System.Drawing.Color.Lime;
            this.btn_b.Location = new System.Drawing.Point(49, 90);
            this.btn_b.Name = "btn_b";
            this.btn_b.Size = new System.Drawing.Size(326, 39);
            this.btn_b.TabIndex = 2;
            this.btn_b.Text = "Activar Windows 10";
            this.btn_b.UseVisualStyleBackColor = false;
            this.btn_b.Click += new System.EventHandler(this.btn_b_Click);
            // 
            // btn_c
            // 
            this.btn_c.BackColor = System.Drawing.Color.Black;
            this.btn_c.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_c.ForeColor = System.Drawing.Color.Lime;
            this.btn_c.Location = new System.Drawing.Point(49, 154);
            this.btn_c.Name = "btn_c";
            this.btn_c.Size = new System.Drawing.Size(326, 39);
            this.btn_c.TabIndex = 3;
            this.btn_c.Text = "Borrar caché DNS";
            this.btn_c.UseVisualStyleBackColor = false;
            this.btn_c.Click += new System.EventHandler(this.btn_c_Click);
            // 
            // btn_d
            // 
            this.btn_d.BackColor = System.Drawing.Color.Black;
            this.btn_d.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_d.ForeColor = System.Drawing.Color.Lime;
            this.btn_d.Location = new System.Drawing.Point(49, 217);
            this.btn_d.Name = "btn_d";
            this.btn_d.Size = new System.Drawing.Size(326, 39);
            this.btn_d.TabIndex = 4;
            this.btn_d.Text = "Crackear WinRAR";
            this.btn_d.UseVisualStyleBackColor = false;
            this.btn_d.Click += new System.EventHandler(this.btn_d_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(417, 497);
            this.Controls.Add(this.btn_d);
            this.Controls.Add(this.btn_c);
            this.Controls.Add(this.btn_b);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_a);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UtilidaDesktop";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_a;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_b;
        private System.Windows.Forms.Button btn_c;
        private System.Windows.Forms.Button btn_d;
        private System.Windows.Forms.SaveFileDialog saveFileArchivo1;
    }
}

