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
    public partial class ModCliente : Form
    {
        cliente clienteModificado = new cliente();
        principal principal = new principal();
        public ModCliente()
        {
            InitializeComponent();
        }

        private void btnModCLi1_Click(object sender, EventArgs e)
        {
            clienteModificado = new cliente();
            clienteModificado.nombre = boxNombreClienteM.Text;
            clienteModificado.apellido = boxApellidoClienteM.Text;
            clienteModificado.dni = int.Parse(boxDniClienteM.Text);
            clienteModificado.direccion = boxDireccionClienteM.Text;
            clienteModificado.idCliente = int.Parse(boxIdClienteM.Text);

            principal = new principal();
            principal.RellenarLista();
            principal.ModificarCliente(clienteModificado, clienteModificado.idCliente);

            GrillaClientes fmr = new GrillaClientes();
            fmr.Show();
            this.Hide();

            //Llamamos a la funcion de modificar cliente para registrar los nuevos datos y sobreeescribir los anteriores
        }
    }
}
