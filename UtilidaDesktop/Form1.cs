using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtilidaDesktop {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }


        private void btn_salir_Click(object sender, EventArgs e) {
            Application.Exit(); 
        }

        private void btn_a_Click(object sender, EventArgs e) {
            Shutdown shutdown = new Shutdown();
            shutdown.Show();
            this.Hide();
        }

        private void btn_b_Click(object sender, EventArgs e) {
            activarWin windows = new activarWin();
            windows.Show();
            this.Hide();
        }

        private void btn_c_Click(object sender, EventArgs e) {
            ProcessStartInfo comando = new ProcessStartInfo();
            comando.FileName = "cmd.exe";
            comando.WindowStyle = ProcessWindowStyle.Hidden;
            comando.Arguments = @"/k ipconfig /flushdns ";
            Process.Start(comando);
            MessageBox.Show("Caché Vaciado Correctamente","FlushDNS");
        }

        private void btn_d_Click(object sender, EventArgs e) {

            MessageBox.Show("Indica la ruta de instalación de tu WinRAR", "Alerta",MessageBoxButtons.OK, MessageBoxIcon.Information);

            saveFileArchivo1.Filter = "clave | *.key";
            saveFileArchivo1.FileName = "rarreg";
            if (saveFileArchivo1.ShowDialog()==DialogResult.OK) {

                string ruta = saveFileArchivo1.FileName;
                string textoCrear = "RAR registration data\r\nFederal Agency for Education\r\n1000000 PC usage license\r\nUID=b621cca9a84bc5deffbf\r\n6412612250ffbf533df6db2dfe8ccc3aae5362c06d54762105357d\r\n5e3b1489e751c76bf6e0640001014be50a52303fed29664b074145\r\n7e567d04159ad8defc3fb6edf32831fd1966f72c21c0c53c02fbbb\r\n2f91cfca671d9c482b11b8ac3281cb21378e85606494da349941fa\r\ne9ee328f12dc73e90b6356b921fbfb8522d6562a6a4b97e8ef6c9f\r\nfb866be1e3826b5aa126a4d2bfe9336ad63003fc0e71c307fc2c60\r\n64416495d4c55a0cc82d402110498da970812063934815d81470829275";
                StreamWriter textoArchivo = File.CreateText(ruta);

                textoArchivo.Write(textoCrear);
                textoArchivo.Flush();
                textoArchivo.Close();

                MessageBox.Show("Se ha crackeado WinRAR con exito", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
    }
}
