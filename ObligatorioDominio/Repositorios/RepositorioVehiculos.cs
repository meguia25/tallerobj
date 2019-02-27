using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObligatorioDominio.EntidadesDeNegocio;
using ObligatorioDominio.Interfaces;

namespace ObligatorioDominio.Repositorios
{
    public class RepositorioVehiculos : IRepositorioVehiculos
    {
        public List<Vehiculo> listaVehiculos = new List<Vehiculo>();

        public RepositorioVehiculos()
        {
            this.listaVehiculos = new List<Vehiculo>();
        }
        public bool altaVehiculo(Vehiculo unVehiculo)
        {
            bool alta = false;
            if (!listaVehiculos.Contains(unVehiculo))
            {
                listaVehiculos.Add(unVehiculo);
                alta = true;
            }
            return alta;
        }
        public Vehiculo buscarVehiculo(string laMatricula)
        {
            Vehiculo elVehiculo = null;
            bool bandera = false;
            int i = 0;
            while(i < listaVehiculos.Count && !bandera)
            {
                if(listaVehiculos[i].Matricula == laMatricula)
                {
                    elVehiculo = listaVehiculos[i];
                    bandera = true;
                }
            }
            return elVehiculo;
        }
        public List<Vehiculo> listadoTodosLosVehiculos()
        {
            List<Vehiculo> lista = new List<Vehiculo>();
            foreach(Vehiculo v in this.listaVehiculos)
            {
                lista.Add(v);
            }

            return lista;
        }
    }
}
