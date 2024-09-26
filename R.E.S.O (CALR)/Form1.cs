using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R.E.S.O__CALR_
{
    public partial class Form1 : Form
    {
        private string Serial;
        public Form1()
        {
            InitializeComponent();
        }


        private void cmdLeerSeri_Click(object sender, EventArgs e)
        {
            LeerSerial();
            rtxtdatos.Clear();
            rtxtdatos.Text = Serial;

        }

        public void LeerSerial()
        {

            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");

                foreach (ManagementObject wmi_HD in searcher.Get())
                {
                    Serial = ("Serial Number:", wmi_HD["SerialNumber"]).ToString();
                }

            }
            catch (ManagementException e)
            {
                Serial = ("An error occurred while querying for WMI data: " + e.Message).ToString();

            }


        }

        private void cmdUnidades_Click(object sender, EventArgs e)
        {
            rtxtdatos.Clear();
            DriveInfo[] lasunidadesdeldisco = DriveInfo.GetDrives();
            string nombreuni = "";

            foreach(DriveInfo drive in lasunidadesdeldisco)
            {
                nombreuni += " " + drive.Name;
            }

            rtxtdatos.Text = ("La pc cuenta con " + lasunidadesdeldisco.Length + " particiones de disco \n" + nombreuni);
        }

        private void cmdComponentes_Click(object sender, EventArgs e)
        {
            rtxtdatos.Clear();
            string nomprocesadores = "";
            string ramtot = "";
            try
            {
                ManagementObjectSearcher procesadores = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
                foreach (ManagementObject procesador in procesadores.Get())
                {
                    nomprocesadores += "Nombre del procesador: " + procesador["Name"];
                }

                ObjectQuery wql = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(wql);
                foreach (ManagementObject result in searcher.Get())
                {
                    ramtot =  (" Memoria RAM total: ", result["TotalVisibleMemorySize"]).ToString();
                }
                
                rtxtdatos.Text = (nomprocesadores + "Cantidad de nucleos logicos " + (Environment.ProcessorCount).ToString() + ramtot);



            }

            catch (ManagementException r)
            {
                MessageBox.Show("Ocurrió un error al consultar los datos WMI: " + r.Message);
               
            }

        }

        private void cmdClaves_Click(object sender, EventArgs e)
        {
            Wclave wclave = new Wclave();
            wclave.Show();
            this.Hide();
        }
    }
}

