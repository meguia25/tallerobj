using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObligatorioDominio.EntidadesDeNegocio;

namespace ObligatorioDominio.Interfaces
{
    public interface IRepositorioModelos
    {
        bool altaModelo(Modelo unModelo);
    }
}
