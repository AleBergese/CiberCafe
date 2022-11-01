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
    public partial class GrillaClientes : Form
    {
        principal principal = new principal();

        public List<cliente> ListaCliente;
        public GrillaClientes()
        {
            InitializeComponent();
        }

        //Los botones nos llevan a las pantallas designadas
        private void btnAltaCli_Click(object sender, EventArgs e)
        {
            AltaCliente fmr = new AltaCliente();
            fmr.Show();
        }

        private void GrillaClientes_Load(object sender, EventArgs e)
        {
            persistenciaDeDatos instanciaPersistencia = new persistenciaDeDatos();
            instanciaPersistencia.InicializarArchivo();
            principal instanciaPrincipal = new principal();
            instanciaPrincipal.RellenarLista();

            grillaCliente.DataSource = instanciaPrincipal.ValidarCliente();

            //Cargamos la persistencia de datos en la grilla para que valide que los datos ingresados son correctos y pueda registrarlos
        }

        private void btnModifCliente_Click(object sender, EventArgs e)
        {
            ModCliente fmr = new ModCliente();
            fmr.Show();
            this.Hide();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {

            cliente CliSelec = grillaCliente.SelectedRows[0].DataBoundItem as cliente;
            principal = new principal();
            principal.BajaCliente(CliSelec.idCliente);

            GrillaClientes fmr = new GrillaClientes();
            fmr.Show();
            this.Hide();
        }
    }
}
