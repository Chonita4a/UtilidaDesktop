using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtilidaDesktop {
    public partial class Shutdown : Form {
        public Shutdown() {
            InitializeComponent();
        }


        private void btn_programar_Click(object sender, EventArgs e) {
           


            //MessageBox.Show(cbo_time.Text, txt_time.Text);

            if(txt_time.TextLength == 0 || txt_time.Text == "0" || txt_time.Text == "00") {
                DialogResult result = MessageBox.Show("¿Deseas apagar el equipo inmediatamente?", "No especificaste el tiempo de apagado", MessageBoxButtons.OKCancel);
                if(result == DialogResult.OK) {
                    MessageBox.Show("Apagando...");
                } else {

                }
            } else {

                if (cbo_time.Text == "") {
                    MessageBox.Show(txt_time.Text + " Que? Minutos? Segundos? Horas?");
                } else {
                    MessageBox.Show("El PC se apagara en " + txt_time.Text + " " + cbo_time.Text);
                    int cuenta = Int32.Parse(txt_time.Text);
                    string tipo = cbo_time.Text.ToUpper();
                    switch (tipo) {
                        //case "SEGUNDOS": { } break;
                        case "MINUTOS": { cuenta = cuenta * 60; } break;
                        case "HORAS": { cuenta = cuenta * 3600; } break;
                        case "DIAS": { cuenta = cuenta * 86400; } break;
                    }
                    cmd(cuenta);
                    CuentaRegresiva cuentaRegresiva = new CuentaRegresiva(cuenta);
                    cuentaRegresiva.Show();
                    this.Close();
                }

            }


        }

        private void btn_back_Click(object sender, EventArgs e) {
            Form1 Home = new Form1();
            Home.Show();
            this.Close();

        }


        private void txt_time_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void cmd(int cuenta) {
          
          ProcessStartInfo shutdown = new ProcessStartInfo();
          shutdown.FileName = "cmd.exe";
          shutdown.WindowStyle = ProcessWindowStyle.Hidden;
          shutdown.Arguments = @"/k shutdown /s /t "+ cuenta;
          Process.Start(shutdown);
        }
    }
}
