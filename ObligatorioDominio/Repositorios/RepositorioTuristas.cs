using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObligatorioDominio.EntidadesDeNegocio;

namespace ObligatorioDominio.Repositorios
{
    public class RepositorioTuristas
    {
        public List<Turista> ListaTuristas = new List<Turista>();
        public RepositorioTuristas()
        {
            this.ListaTuristas = new List<Turista>();
        }
        public bool agregarTurista(String unNombre, String unPais, int unNDocumento)
        {
            bool alta = false;
            if(unNombre != null && unPais != null && unNDocumento != 0)
            {
                Turista unTurista = new Turista(unNombre, unPais, unNDocumento);
                ListaTuristas.Add(unTurista);
                alta = true;
            }
            return alta;
        }
    }
}
