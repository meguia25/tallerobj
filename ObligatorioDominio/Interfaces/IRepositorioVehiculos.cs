using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObligatorioDominio.Repositorios;
using ObligatorioDominio.EntidadesDeNegocio;

namespace ObligatorioDominio.Interfaces
{
    public interface IRepositorioVehiculos
    {
        Vehiculo buscarVehiculo(string unaMatricula);
        List<Vehiculo> listadoTodosLosVehiculos();
        bool altaVehiculo(Vehiculo unVehiculo);
    }
}
