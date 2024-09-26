using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R.E.S.O__CALR_
{
    public partial class Wclave : Form
    {
        public Wclave()
        {
            InitializeComponent();
        }
        int existencia = 0;
        private void cmdCrearCont_Click(object sender, EventArgs e)
        {
            try
            {

                Registry.CurrentUser.CreateSubKey(txtContraseña.Text);
                Registry.SetValue(@"HKEY_CURRENT_USER\" + txtContraseña.Text.ToLower(), txtContraseña.Text, txtValor.Text);
                MessageBox.Show(@"Clave creada en HKEY_CURRENT_USER\" + txtContraseña.Text.ToLower());

            }
            catch (ManagementException r)
            {
                MessageBox.Show(r.Message);

            }

        }
    }
}
