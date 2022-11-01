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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txtusuario_Click(object sender, EventArgs e)
        {

        }

        private void boxUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseña_Click(object sender, EventArgs e)
        {

        }

        private void boxContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (boxUsuario.Text.Length > 0)
            {
                // Llamamos a la funcion que valida el usuario, si esta todo en orden nos deja entrar, sino hay que volver a intentarlo

                if (validarUsuario(boxUsuario.Text.Trim(), boxContraseña.Text.Trim()))
                {
                    MessageBox.Show("Acceso al sistema");
                    Menu fmr = new Menu();
                    fmr.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o clave Incorrecta");
                }
                
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre de Usuario");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            persistenciaDeDatos instanciaPersistencia = new persistenciaDeDatos();
            instanciaPersistencia.InicializarArchivo();
            principal instanciaPrincipal = new principal();
            instanciaPrincipal.RellenarLista();
        }
        private bool validarUsuario(string nombre, string clave)
        {
            //Validamos el nombre y la contraseña de la pantalla de login

            return (nombre == "Alejandro") && (clave == "pepito");
        }
    }
}
