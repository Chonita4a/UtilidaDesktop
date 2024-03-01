using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtilidaDesktop {
    public partial class CuentaRegresiva : Form {

        private Timer miTimer;

        public CuentaRegresiva(int cuentaRegresiva) {
            InitializeComponent();
            txt_cuentaRegresiva.Text = cuentaRegresiva.ToString();

            // Configura el Timer
            miTimer = new Timer();
            miTimer.Interval = 1000; // Intervalo en milisegundos (en este caso, 1 segundo)
            miTimer.Tick += MiTimer_Tick;

            // Habilita el Timer
            miTimer.Enabled = true;
            
        }

        private void MiTimer_Tick(object sender, EventArgs e) {
            // Coloca aquí el código que deseas ejecutar cada ciertos segundos
            // Por ejemplo:
            
            int cuenta = Int32.Parse(txt_cuentaRegresiva.Text);
            cuenta = cuenta -1;
            txt_cuentaRegresiva.Text = cuenta.ToString();
            
            switch (cuenta) {
                case 10:
                case 8:
                case 6:
                case 4:
                case 2:
                case 0: { txt_cuentaRegresiva.BackColor = Color.Red; 
                    txt_cuentaRegresiva.ForeColor = Color.White;
                    }
                    break;

                case 9:
                case 7:
                case 5:
                case 3:
                case 1: { txt_cuentaRegresiva.BackColor = Color.White;
                        txt_cuentaRegresiva.ForeColor = Color.Black;
                    }
                    break;
            }

            
            if(cuenta == 0) {
                miTimer.Enabled = false;
                txt_cuentaRegresiva.BackColor = Color.Red;
            }
        }
    }
}
