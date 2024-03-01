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
    public partial class activarWin : Form {
        public activarWin() {
            InitializeComponent();

            MessageBox.Show("Selecciona tu version de windows", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btn_version_Click(object sender, EventArgs e) {
            //systeminfo | find "Nombre del sistema operativo"
            // Crea un proceso para ejecutar el comando
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.UseShellExecute = false;

            // Inicia el proceso
            process.Start();

            // Ejecuta el comando en el símbolo del sistema
            StreamWriter streamWriter = process.StandardInput;
            streamWriter.WriteLine("systeminfo | find \"Nombre del sistema operativo\"");
            streamWriter.Close();

            // Captura la salida del proceso
            StreamReader streamReader = process.StandardOutput;
            string output = streamReader.ReadToEnd();
            streamReader.Close();

            // Espera a que el proceso termine
            process.WaitForExit();
            


            // Muestra el resultado en un MessageBox
            MessageBox.Show(output, "Información del sistema operativo");

            // Cierra el proceso
            process.Close();
        }

        private void btn_volver_Click(object sender, EventArgs e) {
            Form1 Home = new Form1();
            Home.Show();
            this.Close();
        }

        

        private void cmd(string ver) {
            string serial = "";

            switch (ver) {
                case "Windows 10 Pro 1": {                  serial = "VK7JG-NPHTM-C97JM-9MPGT-3V66T"; } break;
                case "Windows 10 Pro 2": {                  serial = "NRG8B-VKK3Q-CXVCJ-9G2XF-6Q84J"; } break;
                case "Windows 10 Pro Education": {          serial = "6TP4R-GNPTD-KYYHQ-7B7DP-J447Y"; } break;
                case "Windows 10 Pro Education N": {        serial = "YVWGF-BXNMC-HTQYQ-CPQ99-66QFC"; } break;
                case "Windows 10 Pro N 1": {                serial = "MH37W-N47XK-V7XM9-C7227-GCQG9"; } break;
                case "Windows 10 Pro N 2": {                serial = "9FNHH-K3HBT-3W4TD-6383H-6XYWF"; } break;
                case "Windows 10 Pro Serial": {             serial = "W269N-WFGWX-YVC9B-4J6C9-T83GX"; } break;
                case "Windows 10 Home": {                   serial = "TX9XD-98N7V-6WMQ6-BX7FG-H8Q99"; } break;
                case "Windows 10 Home Single Language": {   serial = "7HNRX-D7KGG-3K4RQ-4WPJ4-YTDFH"; } break;
                case "Windows 10 Education": {              serial = "NW6C2-QMPVW-D7KKK-3GKT6-VCFB2"; } break;
                case "Windows 10 Education N": {            serial = "2WH4N-8QGBV-H22JP-CT43Q-MDWWJ"; } break;
                case "Windows 10 Enterprise 1": {           serial = "NPPR9-FWDCX-D2C8J-H872K-2YT43"; } break;
                case "Windows 10 Enterprise 2": {           serial = "NPPR9-FWDCX-D2C8J-H872K-2YT43"; } break;
                case "Windows 10 Enterprise G": {           serial = "YYVX9-NTFWV-6MDM3-9PT4T-4M68B"; } break;
                case "Windows 10 Enterprise G N": {         serial = "44RPN-FTY23-9VTTB-MP9BX-T84FV"; } break;
                case "Windows 10 Enterprise N": {           serial = "DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4"; } break;
            }


            ProcessStartInfo cmd = new ProcessStartInfo();
            cmd.FileName = "cmd.exe";
            cmd.WindowStyle = ProcessWindowStyle.Hidden;
            cmd.Arguments = @"/k slmgr /ipk "+serial;
            Process.Start(cmd);
            cmd.Arguments = @"/k slmgr /skms kms.digiboy.ir";
            Process.Start(cmd);
            cmd.Arguments = @"/k slmgr /ato";
            Process.Start(cmd);
            MessageBox.Show("Se ha activado windows correctamente.\n\nNOTA: Esta activación puede durar dias, meses o años.\nVuelve aqui cuando sea necesario.", "Información Importante", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void ask(string ver) {
            DialogResult result = MessageBox.Show("Estás seguro que tu sistema es la version " + ver + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) {
                cmd(ver);
            } else {

            }
        }

        private void btn_pro1_Click(object sender, EventArgs e) {
            string ver = btn_pro1.Text;
            ask(ver);
        }

        private void btn_proen_Click(object sender, EventArgs e) {
            string ver = btn_proen.Text;
            ask(ver);
        }

        private void btn_pron1_Click(object sender, EventArgs e) {
            string ver = btn_pron1.Text;
            ask(ver);
        }

        private void btn_pron2_Click(object sender, EventArgs e) {
            string ver = btn_pron2.Text;
            ask(ver);
        }

        private void btn_pro2_Click(object sender, EventArgs e) {
            string ver = btn_pro2.Text;
            ask(ver);
        }

        private void btn_proe_Click(object sender, EventArgs e) {
            string ver = btn_proe.Text;
            ask(ver);
        }

        private void btn_pros_Click(object sender, EventArgs e) {
            string ver = btn_pros.Text;
            ask(ver);
        }

        private void btn_home_Click(object sender, EventArgs e) {
            string ver = btn_home.Text;
            ask(ver);
        }

        private void btn_e_Click(object sender, EventArgs e) {
            string ver = btn_e.Text;
            ask(ver);
        }

        private void btn_hsl_Click(object sender, EventArgs e) {
            string ver = btn_hsl.Text;
            ask(ver);
        }

        private void btn_en_Click(object sender, EventArgs e) {
            string ver = btn_en.Text;
            ask(ver);
        }

        private void btn_en1_Click(object sender, EventArgs e) {
            string ver = btn_en1.Text;
            ask(ver);
        }

        private void btn_en2_Click(object sender, EventArgs e) {
            string ver = btn_en2.Text;
            ask(ver);
        }

        private void btn_eng_Click(object sender, EventArgs e) {
            string ver = btn_eng.Text;
            ask(ver);
        }

        private void btn_engn_Click(object sender, EventArgs e) {
            string ver = btn_engn.Text;
            ask(ver);
        }

        private void btn_enn_Click(object sender, EventArgs e) {
            string ver = btn_enn.Text;
            ask(ver);
        }
    }
}
