using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObligatorioDominio.Repositorios;
using ObligatorioDominio.EntidadesDeNegocio;

namespace ObligatorioDominio.Fachada
{
    public class Fachada
    {
        RepositorioTuristas repoTurista = new RepositorioTuristas();

        #region Turista

        public bool agregarTurista(String unNombre, String unPais, int unNDocumento)
        {
            bool alta = false;
            repoTurista.agregarTurista(unNombre, unPais, unNDocumento);
            return alta;
        }
        #endregion
    }
}
