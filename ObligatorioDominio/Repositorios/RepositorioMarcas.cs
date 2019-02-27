using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObligatorioDominio.EntidadesDeNegocio;
using ObligatorioDominio.Interfaces;

namespace ObligatorioDominio.Repositorios
{
    public class RepositorioMarcas :IRepositorioMarcas
    {
        public List<Marca> listaMarcas = new List<Marca>();

        public RepositorioMarcas()
        {
            this.listaMarcas = new List<Marca>();
        }
        public bool altaMarca(Marca unaMarca)
        {
            bool alta = false;
            if (!listaMarcas.Contains(unaMarca))
            {
                listaMarcas.Add(unaMarca);
                alta = true;
            }
            return alta;
        }
    }
}
