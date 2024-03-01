namespace UtilidaDesktop {
    partial class Shutdown {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btn_programar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_time = new System.Windows.Forms.TextBox();
            this.cbo_time = new System.Windows.Forms.ComboBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_programar
            // 
            this.btn_programar.BackColor = System.Drawing.Color.Black;
            this.btn_programar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_programar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_programar.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_programar.ForeColor = System.Drawing.Color.Lime;
            this.btn_programar.Location = new System.Drawing.Point(95, 123);
            this.btn_programar.Name = "btn_programar";
            this.btn_programar.Size = new System.Drawing.Size(272, 46);
            this.btn_programar.TabIndex = 4;
            this.btn_programar.Text = "Programar Apagado";
            this.btn_programar.UseVisualStyleBackColor = false;
            this.btn_programar.Click += new System.EventHandler(this.btn_programar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "¿En cuanto tiempo quieres que se apague el equipo?";
            // 
            // txt_time
            // 
            this.txt_time.BackColor = System.Drawing.Color.Black;
            this.txt_time.Font = new System.Drawing.Font("OCR A Extended", 24F, System.Drawing.FontStyle.Bold);
            this.txt_time.ForeColor = System.Drawing.Color.Lime;
            this.txt_time.Location = new System.Drawing.Point(149, 66);
            this.txt_time.MaxLength = 2;
            this.txt_time.Name = "txt_time";
            this.txt_time.Size = new System.Drawing.Size(54, 41);
            this.txt_time.TabIndex = 1;
            this.txt_time.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_time_KeyPress);
            // 
            // cbo_time
            // 
            this.cbo_time.BackColor = System.Drawing.Color.Black;
            this.cbo_time.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_time.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_time.ForeColor = System.Drawing.Color.Lime;
            this.cbo_time.FormattingEnabled = true;
            this.cbo_time.Items.AddRange(new object[] {
            "Segundos",
            "Minutos",
            "Horas",
            "Dias"});
            this.cbo_time.Location = new System.Drawing.Point(220, 76);
            this.cbo_time.Name = "cbo_time";
            this.cbo_time.Size = new System.Drawing.Size(101, 21);
            this.cbo_time.TabIndex = 2;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Black;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.Lime;
            this.btn_back.Location = new System.Drawing.Point(33, 123);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(36, 46);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "<";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Shutdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(429, 181);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.cbo_time);
            this.Controls.Add(this.txt_time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_programar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Shutdown";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shutdown";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_programar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_time;
        private System.Windows.Forms.ComboBox cbo_time;
        private System.Windows.Forms.Button btn_back;
    }
}