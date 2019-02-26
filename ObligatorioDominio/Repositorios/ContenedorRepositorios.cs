using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObligatorioDominio.Interfaces;

namespace ObligatorioDominio.Repositorios
{
    public class ContenedorRepositorios
    {
        #region Singleton    
        //private ContenedorRepositorios instancia = new ContenedorRepositorios();
        //public ContenedorRepositorios Instancia { get { return instancia; } }
        #endregion

        private IRepositorioTuristas repositorioTuristas = new RepositorioTuristas();
        public IRepositorioTuristas repoTuristas { get { return repositorioTuristas; } }

        private IRepositorioVehiculos repositorioVehiculos = new RepositorioVehiculos();
        public IRepositorioVehiculos repoVehiculos { get { return repositorioVehiculos; } }

        private IRepositorioViajes repositorioViajes = new RepositorioViajes();
        public IRepositorioViajes repoViajes { get { return repositorioViajes; } }

        private IRepositorioModelos repositorioModelos = new RespositorioModelos();
        public IRepositorioModelos repoModelos { get { return repositorioModelos; } }

        private IRepositorioMarcas repositorioMarcas = new RepositorioMarcas();
        public IRepositorioMarcas repoMarcas { get { return repositorioMarcas; } }

        private IRepositorioAdministradores repositorioAdministradores = new RepositorioAdministradores();
        public IRepositorioAdministradores repoAdministradores { get { return repositorioAdministradores; } }

        private IRepositorioUsuarios repositorioUsuarios = new RepositorioUsuarios();
        public IRepositorioUsuarios repoUsuarios { get { return repositorioUsuarios; } }

    }
}
