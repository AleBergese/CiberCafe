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
    public partial class AltaEmpleado : Form
        
    {
        empleados nuevoEmpleado = new empleados();
        principal principal = new principal();
        public AltaEmpleado()
        {
            InitializeComponent();
        }

        private void txtIdEmpleado_Click(object sender, EventArgs e)
        {

        }

        private void txtDniEmpleado_Click(object sender, EventArgs e)
        {

        }

        private void boxIdEmpleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxDniEmpleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxNombreEmpleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxApellidoEmpleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxTelefonoEmpleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxDireccionEmpleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAlta1_Click(object sender, EventArgs e)
        {

          nuevoEmpleado = new empleados();
          nuevoEmpleado.nombre = boxNombreEmpleado.Text;
          nuevoEmpleado.apellido = boxApellidoEmpleado.Text;
          nuevoEmpleado.dni = int.Parse(boxDniEmpleado.Text);
          nuevoEmpleado.direccion = boxDireccionEmpleado.Text;
          nuevoEmpleado.idEmpleados = int.Parse(boxIdEmpleado.Text);
          nuevoEmpleado.telefono = int.Parse(boxTelefonoEmpleado.Text);

          principal = new principal();
          principal.RellenarLista();
          principal.AltaEmpleado(nuevoEmpleado, nuevoEmpleado.idEmpleados);

          GrillaEmpleado fmr = new GrillaEmpleado();
          fmr.Show();
          this.Hide();

          //Llamamos la funcion de dar de alta el empleado y que registre los datos que colocamos en las text box  

        }

        private void AltaEmpleado_Load(object sender, EventArgs e)
        {
            

        }

        private void boxDniEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!boxDniEmpleado.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }
        private void boxIdEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!boxIdEmpleado.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        private void boxTelefonoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!boxTelefonoEmpleado.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void boxNombreEmpleado_KeyPress(object sender, KeyPressEventArgs e)
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
        private void boxApellidoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
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
