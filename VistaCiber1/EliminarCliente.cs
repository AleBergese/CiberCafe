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
    public partial class EliminarCliente : Form
    {
        principal principal = new principal();

        public EliminarCliente()
        {
            InitializeComponent();
        }

        private void brnEliminarcli1_Click(object sender, EventArgs e)
        {

            cliente nuevoCliente = new cliente();

            principal = new principal();
            principal.BajaCliente(nuevoCliente.idCliente);

            GrillaClientes fmr = new GrillaClientes();
            fmr.Show();

            //Llamamos a la funcion de eliminar cliente seleccionado en la grilla
        }
    }
}
