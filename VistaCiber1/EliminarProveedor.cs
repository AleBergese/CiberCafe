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
    public partial class EliminarProveedor : Form
    {
        principal principal = new principal();
        public EliminarProveedor()
        {
            InitializeComponent();
        }

        private void brnEliminaremp1_Click(object sender, EventArgs e)
        {
            proveedor nuevoProveedor = new proveedor();


            principal = new principal();
            principal.BajaProveedor(nuevoProveedor.idProveedor);

            GrillaProveedor fmr = new GrillaProveedor();
            fmr.Show();

            //Llamamos a la funcion de eliminar proveedor seleccionado en la grilla

        }
    }
}
