namespace UtilidaDesktop {
    partial class CuentaRegresiva {
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
            this.components = new System.ComponentModel.Container();
            this.txt_cuentaRegresiva = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txt_cuentaRegresiva
            // 
            this.txt_cuentaRegresiva.BackColor = System.Drawing.Color.Black;
            this.txt_cuentaRegresiva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_cuentaRegresiva.Font = new System.Drawing.Font("OCR A Extended", 72F, System.Drawing.FontStyle.Bold);
            this.txt_cuentaRegresiva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txt_cuentaRegresiva.Location = new System.Drawing.Point(0, 0);
            this.txt_cuentaRegresiva.Name = "txt_cuentaRegresiva";
            this.txt_cuentaRegresiva.Size = new System.Drawing.Size(455, 161);
            this.txt_cuentaRegresiva.TabIndex = 0;
            this.txt_cuentaRegresiva.Text = "8553600";
            this.txt_cuentaRegresiva.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CuentaRegresiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 161);
            this.Controls.Add(this.txt_cuentaRegresiva);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CuentaRegresiva";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CuentaRegresiva";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txt_cuentaRegresiva;
        private System.Windows.Forms.Timer timer1;
    }
}