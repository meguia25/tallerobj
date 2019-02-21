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
        private readonly static ContenedorRepositorios instancia = new ContenedorRepositorios();
        public static ContenedorRepositorios Instancia { get { return instancia; } }
        #endregion
        private IRepositorioTuristas repositorioTuristas = new RepositorioTuristas();

        public IRepositorioTuristas repoTuristas { get { return repositorioTuristas; } }
    }
}
