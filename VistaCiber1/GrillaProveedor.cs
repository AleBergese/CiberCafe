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
    public partial class GrillaProveedor : Form
    {
        public GrillaProveedor()
        {
            InitializeComponent();
        }
         //Los botones solo nos llevan a las pantallas designadas
        private void btnAltaPro_Click(object sender, EventArgs e)
        {
            AltaProveedor fmr = new AltaProveedor();
            fmr.Show();
        }

        private void btnModPro_Click(object sender, EventArgs e)
        {
            ModProveedor fmr = new ModProveedor();
            fmr.Show();
            this.Hide();
        }

        private void btnBajaPro_Click(object sender, EventArgs e)
        {
            EliminarProveedor fmr = new EliminarProveedor();
            fmr.Show();
            this.Hide();
        }

        private void GrillaProveedor_Load(object sender, EventArgs e)
        {
            persistenciaDeDatos instanciaPersistencia = new persistenciaDeDatos();
            instanciaPersistencia.InicializarArchivo();
            principal instanciaPrincipal = new principal();
            instanciaPrincipal.RellenarLista();

            grillaPro.DataSource = instanciaPrincipal.ValidarProveedor();

            //Cargamos la persistencia de datos en la grilla para que valide que los datos ingresados son correctos y pueda registrarlos

        }
    }
}
