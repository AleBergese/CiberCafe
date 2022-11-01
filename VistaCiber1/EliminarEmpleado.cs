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
    
    public partial class EliminarEmpleado : Form
    {
        
        principal principal = new principal();
        public EliminarEmpleado()
        {
            InitializeComponent();
        }

        private void brnEliminaremp1_Click(object sender, EventArgs e)
        {
            empleados nuevoEmpleado = new empleados();


            principal = new principal();
            principal.BajaEmpleado(nuevoEmpleado.idEmpleados);

            GrillaEmpleado fmr = new GrillaEmpleado();
            fmr.Show();

            //Llamamos a la funcion de eliminar empleado seleccionado en la grilla

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
