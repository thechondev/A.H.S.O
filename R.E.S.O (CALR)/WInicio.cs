using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R.E.S.O__CALR_
{
    public partial class WInicio : Form
    {
        private string Serial;
        public WInicio()
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
            string tarjetared = "";
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
                    ramtot = (" Memoria RAM total: ", result["TotalVisibleMemorySize"]).ToString();
                }


                ManagementObjectSearcher reder = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapter WHERE NetConnectionID IS NOT NULL");

                foreach (ManagementObject queryObj in reder.Get())
                {
                    tarjetared = ("Nombre de la tarjeta de red: ", queryObj["Name"]).ToString();
                    //se detiene para que no se confunda con otros adaptadores
                    break;
                }

                rtxtdatos.Text = (nomprocesadores + "Cantidad de nucleos logicos " + (Environment.ProcessorCount).ToString() +"\n"+ ramtot+ "\n" + tarjetared);

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
        }

        private void cmdMac_Click(object sender, EventArgs e)
        {

            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.Name == "Wi-Fi")
                {
                    rtxtdatos.Text = ("Nombre del adaptador: ", nic.Name).ToString() + "\n" + ("Dirección MAC: ", nic.GetPhysicalAddress().ToString()).ToString();
                    break;
                }
            }
        }

        private void cmdProcesos_Click(object sender, EventArgs e)
        {
            Wmataprocesos wmataprocesos = new Wmataprocesos();
            wmataprocesos.Show();
        }
    }
}

