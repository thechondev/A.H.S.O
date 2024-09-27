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

namespace R.E.S.O__CALR_
{
    public partial class Wmataprocesos : Form
    {
        public Wmataprocesos()
        {
            InitializeComponent();
        }

        private void cmdObtenerpro_Click(object sender, EventArgs e)
        {
            Process[] processList = Process.GetProcesses();

            foreach (Process process in processList)
            {
                rtxtProcesos.AppendText("Nombre del proceso: " + process.ProcessName.ToString() + " Nombre Imagen " + process.MainModule.FileName.ToString());
            }

        }

        private void cmdcerrar_Click(object sender, EventArgs e)
        {
            foreach (Process proceso in Process.GetProcesses())
            {
                try
                {
                    // Comparar el nombre del proceso
                    if (proceso.ProcessName == txtProceso.Text)
                    {
                        // Cerrar el proceso
                        proceso.Kill();
                        MessageBox.Show($"{txtProceso.Text} cerrado exitosamente");
                    }
                    
                }
                catch (Win32Exception r)
                {
                    MessageBox.Show(r.Message);
                }
                
            }
        }
    }
}
