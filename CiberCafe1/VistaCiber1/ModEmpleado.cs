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
    public partial class ModEmpleado : Form
    {
        empleados empleadoModificado = new empleados();
        principal principal = new principal();
        public ModEmpleado()
        {
            InitializeComponent();
        }

        private void btnMod1_Click(object sender, EventArgs e)
        {
            empleadoModificado = new empleados();
            empleadoModificado.nombre = boxNombreEmpleadoM.Text;
            empleadoModificado.apellido = boxApellidoEmpleadoM.Text;
            empleadoModificado.dni = int.Parse(boxDniEmpleadoM.Text);
            empleadoModificado.direccion = boxDireccionEmpleadoM.Text;
            empleadoModificado.idEmpleados = int.Parse(boxIdEmpleadoM.Text);
            empleadoModificado.telefono = int.Parse(boxTelefonoEmpleadoM.Text);

            principal = new principal();
            principal.RellenarLista();
            principal.ModificarEmpleado(empleadoModificado, empleadoModificado.idEmpleados, empleadoModificado.telefono);

            GrillaEmpleado fmr = new GrillaEmpleado();
            fmr.Show();
            this.Hide();

            //Llamamos a la funcion de modificar empleado para registrar los nuevos datos y sobreeescribir los anteriores

        }

        private void ModEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void boxDniEmpleadoM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!boxDniEmpleadoM.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }
        private void boxIdEmpleadoM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!boxIdEmpleadoM.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        private void boxTelefonoEmpleadoM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!boxTelefonoEmpleadoM.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void boxNombreEmpleadoM_KeyPress(object sender, KeyPressEventArgs e)
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
        private void boxApellidoEmpleadoM_KeyPress(object sender, KeyPressEventArgs e)
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
