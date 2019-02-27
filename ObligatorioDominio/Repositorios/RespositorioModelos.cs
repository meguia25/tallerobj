using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObligatorioDominio.EntidadesDeNegocio;
using ObligatorioDominio.Interfaces;

namespace ObligatorioDominio.Repositorios
{
    public class RespositorioModelos : IRepositorioModelos
    {
        public List<Modelo> listaModelos = new List<Modelo>();

        public RespositorioModelos()
        {
            this.listaModelos = new List<Modelo>();
        }
        public bool altaModelo(Modelo unModelo)
        {
            bool alta = false;
            if (!listaModelos.Contains(unModelo))
            {
                listaModelos.Add(unModelo);
                alta = true;
            }
            return alta;
        }
    }
}
