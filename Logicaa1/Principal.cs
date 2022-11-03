using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicaa1
{
    public class principal
    {
        List<cliente> ListaCliente = new List<cliente>();
        List<proveedor> ListaProveedor = new List<proveedor>();
        List<empleados> ListaEmpleados = new List<empleados>();


        //ABM Cliente
        public void AltaCliente(cliente clienteNuevo, int idCliente)
        {
            ListaCliente = ValidarCliente();
            cliente nuevoCliente = new cliente();
            nuevoCliente.idCliente = clienteNuevo.idCliente;
            nuevoCliente.dni = clienteNuevo.dni;
            nuevoCliente.nombre = clienteNuevo.nombre;
            nuevoCliente.apellido = clienteNuevo.apellido;
            nuevoCliente.direccion = clienteNuevo.direccion;
            nuevoCliente.telefono = clienteNuevo.telefono;
            ListaCliente.Add(nuevoCliente);
            InstanciaPersistenciaDatos.GuardarArchivoCliente(ListaCliente);

            //Registra los datos que le indicamos y los guarda en la lista de clientes
        }
        public void ModificarCliente(cliente clientenuevo, int idcliente)
        {
            var clienteModificado = ListaCliente.Find(x => idcliente == x.idCliente);

            ListaCliente = ValidarCliente();

            clienteModificado.idCliente = clientenuevo.idCliente;
            clienteModificado.dni = clientenuevo.dni;
            clienteModificado.nombre = clientenuevo.nombre;
            clienteModificado.apellido = clientenuevo.apellido;
            clienteModificado.direccion = clientenuevo.direccion;
            clienteModificado.telefono = clientenuevo.telefono;

            var clienteEliminado = ListaCliente.Find(x => idcliente == x.idCliente);
            ListaCliente.Remove(clienteEliminado);
            ListaCliente.Add(clienteModificado);
            InstanciaPersistenciaDatos.GuardarArchivoCliente(ListaCliente);

            //Modifica los datos que registramos en el alta de clientes
        }
        public void BajaCliente(int idCliente)
        {
            ListaCliente = ValidarCliente();
            cliente nuevoCliente = new cliente();
            var clienteEliminado = ListaCliente.Find(x => idCliente == x.idCliente);
            ListaCliente.Remove(clienteEliminado);
            InstanciaPersistenciaDatos.GuardarArchivoCliente(ListaCliente);

            //Elimina el cliente seleccionado en la grilla (EN TEORIA)
        }

        //ABM Empleado
        public void AltaEmpleado(empleados empleadoNuevo, int idEmpleados)
        {
            ListaEmpleados = ValidarEmpleados();

            empleados nuevoEmpleado = new empleados();
            nuevoEmpleado.idEmpleados = empleadoNuevo.idEmpleados;
            nuevoEmpleado.dni = empleadoNuevo.dni;
            nuevoEmpleado.nombre = empleadoNuevo.nombre;
            nuevoEmpleado.apellido = empleadoNuevo.apellido;
            nuevoEmpleado.direccion = empleadoNuevo.direccion;
            nuevoEmpleado.telefono = empleadoNuevo.telefono;
            ListaEmpleados.Add(nuevoEmpleado);
            InstanciaPersistenciaDatos.GuardarArchivoEmpleados(ListaEmpleados);

            //Registra los datos que le indicamos y los guarda en la lista de empleados
        }
        public void ModificarEmpleado(empleados empleadoNuevo, int idEmpleado, int telefono)
        {
            var empleadoModificado = ListaEmpleados.Find(x => idEmpleado == x.idEmpleados);

            ListaEmpleados = ValidarEmpleados();

            empleadoModificado.idEmpleados = empleadoNuevo.idEmpleados;
            empleadoModificado.dni = empleadoNuevo.dni;
            empleadoModificado.nombre = empleadoNuevo.nombre;
            empleadoModificado.apellido = empleadoNuevo.apellido;
            empleadoModificado.direccion = empleadoNuevo.direccion;
            empleadoModificado.telefono = empleadoNuevo.telefono;

            var empleadoEliminado = ListaEmpleados.Find(x => idEmpleado == x.idEmpleados);
            ListaEmpleados.Remove(empleadoEliminado);
            ListaEmpleados.Add(empleadoModificado);
            InstanciaPersistenciaDatos.GuardarArchivoEmpleados(ListaEmpleados);

            //Modifica los datos que registramos en el alta de empleados
        }
        public void BajaEmpleado(int idEmpleado)
        {
            ListaEmpleados = ValidarEmpleados();
            empleados nuevoEmpleado = new empleados();
            var empleadoEliminado = ListaEmpleados.Find(x => idEmpleado == x.idEmpleados);
            ListaEmpleados.Remove(empleadoEliminado);
            InstanciaPersistenciaDatos.GuardarArchivoEmpleados(ListaEmpleados);

            //Elimina el empleado seleccionado en la grilla (EN TEORIA)
        }

        //ABM Proveedor
        public void AltaProveedor(proveedor proveedorNuevo, int idProveedor)
        {
            ListaProveedor = ValidarProveedor();
            proveedor nuevoProveedor = new proveedor();
            nuevoProveedor.idProveedor = proveedorNuevo.idProveedor;
            nuevoProveedor.dni = proveedorNuevo.dni;
            nuevoProveedor.nombre = proveedorNuevo.nombre;
            nuevoProveedor.apellido = proveedorNuevo.apellido;
            nuevoProveedor.direccion = proveedorNuevo.direccion;
            nuevoProveedor.telefono = proveedorNuevo.telefono;
            ListaProveedor.Add(nuevoProveedor);
            InstanciaPersistenciaDatos.GuardarArchivoProveedor(ListaProveedor);

            //Registra los datos que le indicamos y los guarda en la lista de proveedores
        }
        public void ModificarProveedor(proveedor proveedorNuevo, int idProveedor, int telefono)
        {
            var proveedorModificado = ListaProveedor.Find(x => idProveedor == x.idProveedor);

            ListaProveedor = ValidarProveedor();

            proveedorModificado.idProveedor = proveedorNuevo.idProveedor;
            proveedorModificado.dni = proveedorNuevo.dni;
            proveedorModificado.nombre = proveedorNuevo.nombre;
            proveedorModificado.apellido = proveedorNuevo.apellido;
            proveedorModificado.direccion = proveedorNuevo.direccion;
            proveedorModificado.telefono = proveedorNuevo.telefono;

            var proveedorEliminado = ListaProveedor.Find(x => idProveedor == x.idProveedor);
            ListaProveedor.Remove(proveedorEliminado);
            ListaProveedor.Add(proveedorModificado);
            InstanciaPersistenciaDatos.GuardarArchivoProveedor(ListaProveedor);

            //Modifica los datos que registramos en el alta de proveedores

        }
        public void BajaProveedor(int idProveedor)
        {
            ListaProveedor = ValidarProveedor();
            proveedor nuevoProveedor = new proveedor();
            var proveedorEliminado = ListaProveedor.Find(x => idProveedor == x.idProveedor);
            ListaProveedor.Remove(proveedorEliminado);
            InstanciaPersistenciaDatos.GuardarArchivoProveedor(ListaProveedor);

            //Elimina el proveedor seleccionado en la grilla (EN TEORIA)
        }

        persistenciaDeDatos InstanciaPersistenciaDatos = new persistenciaDeDatos();
        public void RellenarLista()
        {
            ListaCliente = InstanciaPersistenciaDatos.LeerArchivoCliente();
            ListaProveedor = InstanciaPersistenciaDatos.LeerArchivoProveedor();
            ListaEmpleados = InstanciaPersistenciaDatos.LeerArchivoEmpleado();
        }


        //Validaciones

        //Si la lista tiene un valor nulo este codigo se encarga de rellenar y devolvernos una nueva lista con datos que no sean nulos
        public List<cliente> ValidarCliente()
        {
            ListaCliente = InstanciaPersistenciaDatos.LeerArchivoCliente();
            if (ListaCliente == null)
            {
                List<cliente> NuevaListaCliente = new List<cliente>();
                return NuevaListaCliente;
            }
            else
            {
                return ListaCliente;
            }

            
        }

        
        public List<empleados> ValidarEmpleados()
        {
            ListaEmpleados= InstanciaPersistenciaDatos.LeerArchivoEmpleado();
            if (ListaEmpleados == null)
            {
                ListaEmpleados = new List<empleados>();
            }

            return ListaEmpleados;

        }

        public List<proveedor> ValidarProveedor()
        {
            ListaProveedor = InstanciaPersistenciaDatos.LeerArchivoProveedor();
            if (ListaProveedor == null)
            {
                ListaProveedor = new List<proveedor>();
            }

            return ListaProveedor;

        }
    }
}