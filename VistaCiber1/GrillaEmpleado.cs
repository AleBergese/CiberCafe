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
    public partial class GrillaEmpleado : Form
    {
        public GrillaEmpleado()
        {
            InitializeComponent();
        }
         //Los botones solo nos llevan a las pantallas designadas
        private void btnAltaEmpleado_Click(object sender, EventArgs e)
        {
            AltaEmpleado fmr = new AltaEmpleado();
            fmr.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GrillaEmpleado_Load(object sender, EventArgs e)
        {
            persistenciaDeDatos instanciaPersistencia = new persistenciaDeDatos();
            instanciaPersistencia.InicializarArchivo();
            principal instanciaPrincipal = new principal();
            instanciaPrincipal.RellenarLista();

            dataGridView1.DataSource = instanciaPrincipal.ValidarEmpleados();

            //Cargamos la persistencia de datos en la grilla para que valide que los datos ingresados son correctos y pueda registrarlos

        }

        private void btnModEmpleado_Click(object sender, EventArgs e)
        {
            ModEmpleado fmr = new ModEmpleado();
            fmr.Show();
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            EliminarEmpleado fmr = new EliminarEmpleado();
            fmr.Show();
        }
    }
}
