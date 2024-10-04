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

namespace R.E.S.O__CALR_
{
    public partial class Wmataprocesos : Form
    {
        public Wmataprocesos()
        {
            InitializeComponent();
            
        }

        private void Wmataprocesos_Load(object sender, EventArgs e)
        {
           cmdObtenerpro.PerformClick();
        }

        private void cmdObtenerpro_Click(object sender, EventArgs e)
        {

            string bindebug = AppDomain.CurrentDomain.BaseDirectory;

            Process process = new Process();

            // Configurar el proceso para ejecutar cmd.exe
            process.StartInfo.FileName = "cmd.exe";


            // Pasar el comando que quieres ejecutar
            process.StartInfo.Arguments = "/c tasklist /NH /FO CSV" + "\"" + bindebug + "procesos.txt" + "\"";

            // Configurar para que no se muestre la ventana de CMD
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.UseShellExecute = false;

            // Iniciar el proceso
            process.Start();

            // Esperar a que el proceso termine
            process.WaitForExit();
            cboprocesos.Items.Clear();
            try
            {
                using (StreamReader lector = new StreamReader(bindebug+"procesos.txt"))
                {
                    string linea;

                    while ((linea = lector.ReadLine()) != null)
                    {
                        // Separar la línea por comas
                        string[] valores = linea.Split(',');
                        string proceso = valores[0].Replace(".exe", "").Replace("\"", "");

                        // Asumiendo que la columna deseada es la primera (índice 0)
                        cboprocesos.Items.Add(proceso);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo CSV: " + ex.Message);
            }
        }

        private void cmdcerrar_Click(object sender, EventArgs e)
        {
            foreach (Process proceso in Process.GetProcesses())
            {
                try
                {
                    // Comparar el nombre del proceso
                    if (proceso.ProcessName == cboprocesos.Text)
                    {
                        // Cerrar el proceso
                        proceso.Kill();
                        MessageBox.Show($"{cboprocesos.Text} cerrado exitosamente");
                    }
                    
                }
                catch (Win32Exception r)
                {
                    MessageBox.Show(r.Message);
                    break;
                }
                
            }
        }

        
    }
}
