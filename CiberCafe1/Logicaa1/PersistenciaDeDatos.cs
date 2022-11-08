using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Logicaa1
{
    public class persistenciaDeDatos
    {
        readonly string RutaListaClientes = @"C:\Users\Usuario\source\repos\CiberCafe1\archivo_listas\ListaCliente.txt";
        readonly string RutaListaEmpleados = @"C:\Users\Usuario\source\repos\CiberCafe1\archivo_listas\ListaEmpleados.txt";
        readonly string RutaListaProveedor = @"C:\Users\Usuario\source\repos\CiberCafe1\archivo_listas\ListaProveedor.txt";

        public void InicializarArchivo()
        {
            if (!File.Exists(RutaListaClientes))
            {
                File.Create(RutaListaClientes).Close();
            }

            if (!File.Exists(RutaListaProveedor))
            {
                File.Create(RutaListaProveedor).Close();
            }

            if (!File.Exists(RutaListaEmpleados))
            {
                File.Create(RutaListaEmpleados).Close();
            }
        }

        public List<cliente> LeerArchivoCliente()
        {
            string locationFile = RutaListaClientes;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<cliente> ListaClientes = JsonConvert.DeserializeObject<List<cliente>>(content);
                return ListaClientes;
            }
        }

        public List<proveedor> LeerArchivoProveedor()
        {
            string locationFile = RutaListaProveedor;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<proveedor> ListaProveedor = JsonConvert.DeserializeObject<List<proveedor>>(content);
                return ListaProveedor;
            }
        }
        public List<empleados> LeerArchivoEmpleado()
        {
            string locationFile = RutaListaEmpleados;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<empleados> ListaEmpleados = JsonConvert.DeserializeObject<List<empleados>>(content);
                return ListaEmpleados;
            }
        }

        public void GuardarArchivoCliente(List<cliente> ListaClientes)
        {
            string locationFile = RutaListaClientes;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(ListaClientes);
                writer.Write(jsonContent);
            }
        }

        public void GuardarArchivoProveedor(List<proveedor> ListaProveedor)
        {
            string locationFile = RutaListaProveedor;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(ListaProveedor);
                writer.Write(jsonContent);
            }
        }


        public void GuardarArchivoEmpleados(List<empleados> ListaEmpleados)
        {
            string locationFile = RutaListaEmpleados;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(ListaEmpleados);
                writer.Write(jsonContent);
            }
        }
    }
}
