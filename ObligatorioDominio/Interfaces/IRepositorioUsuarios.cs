using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObligatorioDominio.EntidadesDeNegocio;
using ObligatorioDominio.Repositorios;

namespace ObligatorioDominio.Interfaces
{
    public interface IRepositorioUsuarios
    {
        Usuario login(String unUsuario, String contrasenia);
        bool agregarUsuario(Usuario unUsuario);
        Usuario buscarUsuario(String unUsuario);
        bool cambiarContraseña(String unUsuario, string nuevaContrasenia);
    }
}
