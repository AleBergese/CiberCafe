using Logicaa1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaCiber1
{
    public partial class AltaProveedor : Form
    {
        proveedor nuevoProveedor = new proveedor();
        principal principal = new principal();
        public AltaProveedor()
        {
            InitializeComponent();
        }

        private void btnAltaPro_Click(object sender, EventArgs e)
        {
            nuevoProveedor = new proveedor();
            nuevoProveedor.nombre = boxNombrePro.Text;
            nuevoProveedor.apellido = boxApellidoPro.Text;
            nuevoProveedor.dni = int.Parse(boxDniPro.Text);
            nuevoProveedor.direccion = boxDireccionPro.Text;
            nuevoProveedor.idProveedor = int.Parse(boxIdPro.Text);
            nuevoProveedor.telefono = int.Parse(boxTelefonoPro.Text);

            principal = new principal();
            principal.RellenarLista();
            principal.AltaProveedor(nuevoProveedor, nuevoProveedor.idProveedor);

            GrillaProveedor fmr = new GrillaProveedor();
            fmr.Show();
            this.Hide();

            //Llamamos la funcion de dar de alta el proveedor y que registre los datos que colocamos en las text box
        }
    }
}
