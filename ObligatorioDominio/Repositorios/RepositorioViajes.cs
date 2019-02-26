using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObligatorioDominio.EntidadesDeNegocio;
using ObligatorioDominio.Interfaces;

namespace ObligatorioDominio.Repositorios
{
    public class RepositorioViajes : IRepositorioViajes
    {
        public List<Viaje> ListaViajes = new List<Viaje>();

        public RepositorioViajes(){
            this.ListaViajes = new List<Viaje>();
        }
        public bool registarViaje(Viaje unViaje)
        {
            bool alta = false;
            if (!ListaViajes.Contains(unViaje))
            {
                ListaViajes.Add(unViaje);
                alta = true;
            }
            return alta;
        }

        public List<Viaje> listadoViajesEntreDosFechas(DateTime fechaInicial, DateTime fechaFinal)
        {
            List<Viaje> lista = new List<Viaje>();
            foreach(Viaje v in this.ListaViajes)
            {
                if(v.FechaInicial >= fechaFinal && v.FechaFinal <= fechaFinal)
                {
                    lista.Add(v);
                }
            }
            return lista;
        }
        public List<Vehiculo> listadoVehiculosDisponibles(DateTime fechaInicial, DateTime fechaFinal)
        {
            List<Vehiculo> lista = new List<Vehiculo>();
            foreach(Viaje v in this.ListaViajes)
            {
                if (!(v.FechaInicial >= fechaFinal && v.FechaFinal <= fechaFinal))
                {
                    lista.Add(v.Vehiculo);
                }
            }
            return lista;
        }

        public List<Viaje> listaViajesXTurista(int unNDocumento)
        {
            List<Viaje> lista = new List<Viaje>();
            foreach (Viaje v in this.ListaViajes)
            {
                if(v.Turista.NDocumento == unNDocumento)
                {
                    lista.Add(v);
                }
            }
            lista.Sort();
            return lista;
        }

    }
}
