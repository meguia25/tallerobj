using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObligatorioDominio.Repositorios;
using ObligatorioDominio.EntidadesDeNegocio;

namespace ObligatorioDominio.Interfaces
{
    public interface IRepositorioViajes
    {
        bool registarViaje(Viaje unViaje);
        List<Viaje> listadoViajesXTurista(int unNDocumento);
        List<Viaje> listadoViajesEntreDosFechas(DateTime fechaInicial, DateTime fechaFinal);
        List<Vehiculo> listadoVehiculosDisponibles(DateTime fechaInicial, DateTime fechaFinal);
    }
}
