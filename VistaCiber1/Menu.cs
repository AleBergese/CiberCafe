using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaCiber1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void txtMenu_Click(object sender, EventArgs e)
        {

        }
         //Los botones solo nos llevan a las pantallas designadas de cada grilla
        private void btnCliente_Click(object sender, EventArgs e)
        {
            GrillaClientes fmr = new GrillaClientes();
            fmr.Show();
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            GrillaEmpleado fmr = new GrillaEmpleado();
            fmr.Show();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            GrillaProveedor fmr = new GrillaProveedor();
            fmr.Show();
        }
    }
}
