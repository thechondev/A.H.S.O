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
        string ruta = @"HKEY_CURRENT_USER\";
        private void cmdCrearCont_Click(object sender, EventArgs e)
        {
            try
            {

                Registry.CurrentUser.CreateSubKey(txtContraseña.Text);
                Registry.SetValue( ruta + txtContraseña.Text.ToLower(), txtContraseña.Text, txtValor.Text);
                MessageBox.Show(@"Clave creada en HKEY_CURRENT_USER\" + txtContraseña.Text.ToLower());

            }
            catch (ArgumentException r)
            {
                MessageBox.Show(r.Message);

            }

        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Registry.SetValue( ruta + txtContraseña.Text.ToLower(), txtContraseña.Text, txtValor.Text);
                MessageBox.Show("El valor de " + txtContraseña.Text + " Fue actualizado a " + txtValor.Text );
            }
            catch (ArgumentNullException r)
            { 
                MessageBox.Show(r.Message);
            }
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Registry.CurrentUser.DeleteSubKeyTree(txtContraseña.Text.ToLower());
                MessageBox.Show(txtContraseña.Text + " Fue borrada de " + ruta);
            }
            catch (ArgumentNullException r)
            {
                MessageBox.Show(r.Message);
            }
        }
    }
}
