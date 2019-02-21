using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObligatorioDominio.EntidadesDeNegocio;
using ObligatorioDominio.Interfaces;

namespace ObligatorioDominio.Repositorios
{
    public class RepositorioTuristas : IRepositorioTuristas
    {
        public List<Turista> ListaTuristas = new List<Turista>();
        public RepositorioTuristas()
        {
            this.ListaTuristas = new List<Turista>();
        }
        public bool agregarTurista(Turista unTurista)
        {
            bool alta = false;
            if(!ListaTuristas.Contains(unTurista))
            {
                ListaTuristas.Add(unTurista);
                alta = true;
            }
            return alta;
        }
    }
}
