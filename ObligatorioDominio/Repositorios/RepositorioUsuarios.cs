using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObligatorioDominio.EntidadesDeNegocio;
using ObligatorioDominio.Interfaces;
using System.Text.RegularExpressions;

namespace ObligatorioDominio.Repositorios
{
    public class RepositorioUsuarios : IRepositorioUsuarios

    {
        public List<Usuario> listaUsuarios = new List<Usuario>();

        public RepositorioUsuarios()
        {
            this.listaUsuarios = new List<Usuario>();
        }
        public bool agregarUsuario(Usuario unUsuario)
        {
            bool alta = false;
            if (!listaUsuarios.Contains(unUsuario))
            {
                listaUsuarios.Add(unUsuario);
                alta = true;
            }
            return alta;
        }
        public Usuario buscarUsuario(String unUsuario)
        {
            Usuario elUsuario = null;
            bool bandera = false;
            int i = 0;
            while (i < listaUsuarios.Count && !bandera)
            {
                if (listaUsuarios[i].Usu == unUsuario)
                {
                    elUsuario = listaUsuarios[i];
                    bandera = true;
                }
                i++;
            }
            return elUsuario;
        }
        public bool cambiarContraseña(String unUsuario, String nuevaContrasenia)
        {
            bool cambio = false;
            Usuario usuario = buscarUsuario(unUsuario);
            if (usuario != null)
            {
                if (validarContrasenia(nuevaContrasenia))
                {
                    usuario.Contrasenia = nuevaContrasenia;
                    cambio = true;
                }
            }
            return cambio;
        }
        public bool validarContrasenia(String nuevaContrasenia)
        {
            if(nuevaContrasenia.Length >= 6)
            {
                if (new Regex("[A-Z]").IsMatch(nuevaContrasenia) && new Regex("[0-9]").IsMatch(nuevaContrasenia))
                {
                    return true;
                }
            }
            return false;
        }
        public Usuario login(String unUsuario, String contrasenia)
        {
            Usuario usuario = buscarUsuario(unUsuario);
            if (usuario != null)
            {
                if (usuario.Contrasenia != contrasenia)
                {
                    usuario = null;
                }            
            }
            return usuario;
        }

    }
}
