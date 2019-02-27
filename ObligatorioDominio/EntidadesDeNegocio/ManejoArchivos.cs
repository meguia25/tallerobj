using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ObligatorioDominio.EntidadesDeNegocio
{
    public class ManejoArchivos
    {
        private static string ArchivoUsuarios = AppDomain.CurrentDomain.BaseDirectory + "\\Archivos\\usuarios.txt";
        private static string ArchivoMarcas = AppDomain.CurrentDomain.BaseDirectory + "\\Archivos\\marcas.txt";
        private static string ArchivoModelos = AppDomain.CurrentDomain.BaseDirectory + "\\Archivos\\modelos.txt";
        private static string ArchivoParametros = AppDomain.CurrentDomain.BaseDirectory + "\\Archivos\\parametros.txt";
        private static string ArchivoVehiculos = AppDomain.CurrentDomain.BaseDirectory + "\\Archivos\\vehiculos.txt";

        public static Usuario LeerUsuario()
        {
            StreamReader sr = null;
            using (sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "\\Archivos\\usuarios.txt"))
            {
                string linea = sr.ReadLine();
                while (linea != null)
                {
                    Usuario unU = ObtenerUsuarioDesdeString(linea, "#");
                    Fachada.Fachada.Instancia.agregarUsuarioDesdeArchivo(unU);
                    linea = sr.ReadLine();
                    //return unU;
                }
            }
            return null;
        }
        private static Usuario ObtenerUsuarioDesdeString(string dato, string delimitador)
        {
            string[] vecDatos = dato.Split(delimitador.ToCharArray());
            Usuario usuNuevo = new Usuario
            {
                Usu = vecDatos[0],
                Contrasenia = vecDatos[1],
                Rol = vecDatos[2]
            };
            return usuNuevo;
        }

    }
}
