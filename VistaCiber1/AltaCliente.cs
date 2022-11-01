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

            principal = new principal();
            principal.RellenarLista();
            principal.AltaCliente(nuevoCliente, nuevoCliente.dni);

            GrillaClientes fmr = new GrillaClientes();
            fmr.Show();
            this.Hide();

            //Llamamos la funcion de dar de alta el cliente y que registre los datos que colocamos en las text box
        }
    }
} 
