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
    }
}
