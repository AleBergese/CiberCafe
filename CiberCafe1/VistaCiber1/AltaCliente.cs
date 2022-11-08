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
    public partial class AltaCliente : Form
    {
        cliente nuevoCliente = new cliente();
        principal principal = new principal();
        public AltaCliente()
        {
            InitializeComponent();
        }

        private void btnAltaCLi1_Click(object sender, EventArgs e)
        {
            nuevoCliente = new cliente();
            nuevoCliente.nombre = boxNombreCliente.Text;
            nuevoCliente.apellido = boxApellidoCliente.Text;
            nuevoCliente.dni = int.Parse(boxDniCliente.Text);
            nuevoCliente.direccion = boxDireccionCliente.Text;
            nuevoCliente.idCliente = int.Parse(boxIdCliente.Text);
            nuevoCliente.telefono = int.Parse(boxTelefonoCliente.Text);

            principal = new principal();
            principal.RellenarLista();
            principal.AltaCliente(nuevoCliente, nuevoCliente.dni);

            GrillaClientes fmr = new GrillaClientes();
            fmr.Show();
            this.Hide();

            //Llamamos la funcion de dar de alta el cliente y que registre los datos que colocamos en las text box
        }

        private void AltaCliente_Load(object sender, EventArgs e)
        {

        }
        private void boxDniCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!boxDniCliente.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }
        private void boxIdCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!boxIdCliente.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        private void boxTelefonoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!boxTelefonoCliente.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void boxNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
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
        private void boxApellidoCliente_KeyPress(object sender, KeyPressEventArgs e)
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
        
        private void boxApellidoCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
} 
