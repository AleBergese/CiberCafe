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
    public partial class ModProveedor : Form
    {
        proveedor proveedorModificado = new proveedor();
        principal principal = new principal();
        public ModProveedor()
        {
            InitializeComponent();
        }

        private void btnModPro1_Click(object sender, EventArgs e)
        {
            proveedorModificado = new proveedor();
            proveedorModificado.nombre = boxNombreProM.Text;
            proveedorModificado.apellido = boxApellidoProM.Text;
            proveedorModificado.dni = int.Parse(boxDniProM.Text);
            proveedorModificado.direccion = boxDireccionProM.Text;
            proveedorModificado.idProveedor = int.Parse(boxIdProM.Text);
            proveedorModificado.telefono = int.Parse(boxTelefonoProM.Text);

            principal = new principal();
            principal.RellenarLista();
            principal.ModificarProveedor(proveedorModificado, proveedorModificado.idProveedor, proveedorModificado.telefono);

            GrillaProveedor fmr = new GrillaProveedor();
            fmr.Show();
            this.Hide();

            //Llamamos a la funcion de modificar proveedor para registrar los nuevos datos y sobreeescribir los anteriores

        }

        private void boxDniProM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!boxDniProM.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }
        private void boxIdProM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!boxIdProM.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        private void boxTelefonoProM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!boxTelefonoProM.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void boxNombreProM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten letras", "validación de texto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void boxApellidoProM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten letras", "validación de texto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
