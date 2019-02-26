using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObligatorioDominio.EntidadesDeNegocio;
using ObligatorioDominio.Repositorios;

namespace ObligatorioDominio.Fachada
{
    public class Fachada
    {
        private ContenedorRepositorios contenedorrepo = new ContenedorRepositorios();
        public static Fachada _instancia;

        public static Fachada Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new Fachada();
                }
                return _instancia;
            }
        }

        #region Usuario
        public Usuario Login(string unUsuario, string contrasenia)
        {
            Usuario usuarioLogueado =
            contenedorrepo.repoUsuarios.login(unUsuario, contrasenia);
            return usuarioLogueado;
        }
        #endregion

        #region Turista

        public bool agregarTurista(String nombre, String pais, int nDocumento, string contrasenia)
        {
            bool alta = false;
            Turista nuevoTurista = new Turista
            {
                Nombre = nombre,
                Pais = pais,
                NDocumento = nDocumento
            };
            Usuario nuevoUsuario = new Usuario
            {
                Usu = nDocumento.ToString(),
                Contrasenia = contrasenia,
                Rol = "Turista"
            };
            if (contenedorrepo.repoTuristas.agregarTurista(nuevoTurista) && contenedorrepo.repoUsuarios.agregarUsuario(nuevoUsuario))
            {
                alta = true;
            }
            
            return alta;
        }       
        public Turista buscarTurista(int unNDocumento)
        {
            Turista tur = contenedorrepo.repoTuristas.buscarTurista(unNDocumento);
            return tur;
        }
        public bool cambiarContraseña(string unUsuario, string nuevaContrasenia)
        {
            bool cambio = false;
            if (contenedorrepo.repoUsuarios.cambiarContraseña(unUsuario, nuevaContrasenia))
            {
                cambio = true;
            }       
            return cambio;
        }
        public List<Vehiculo> listadoTodosLosVehiculos()
        {
            List<Vehiculo> lista = new List<Vehiculo>();
            lista = contenedorrepo.repoVehiculos.listadoTodosLosVehiculos();
            return lista;
        }
        public List<Viaje> listadoViajesXTurista(int unNDocumento)
        {
            return contenedorrepo.repoViajes.listadoViajesXTurista(unNDocumento);
        }

        #endregion

        #region Administrador
        public bool agregarViaje(DateTime fechaInicial, DateTime fechaFinal, string unaMatricula, int unNDocumento)
        {
            bool alta = false;
            Vehiculo elVehiculo = contenedorrepo.repoVehiculos.buscarVehiculo(unaMatricula);
            Turista elTurista = contenedorrepo.repoTuristas.buscarTurista(unNDocumento);
            if(elVehiculo != null && elTurista != null)
            {
                Viaje nuevoViaje = new Viaje
                {
                    FechaInicial = fechaInicial,
                    FechaFinal = fechaFinal,
                    Vehiculo = elVehiculo,
                    Turista = elTurista
                };
                contenedorrepo.repoViajes.registarViaje(nuevoViaje);
                //ver if bien
            }
            return alta;
        }
        public List<Viaje> listadoViajesEntreDosFechas(DateTime fechaInicial, DateTime fechaFinal)
        {
            List<Viaje> lista = new List<Viaje>();
            lista = contenedorrepo.repoViajes.listadoViajesEntreDosFechas(fechaInicial, fechaFinal);
            return lista;
        }
        public List<Vehiculo> listadoVehiculosDisponibles(DateTime fechaInicial, DateTime fechaFinal)
        {
            List<Vehiculo> lista = new List<Vehiculo>();
            lista = contenedorrepo.repoViajes.listadoVehiculosDisponibles(fechaInicial, fechaFinal);
            return lista;
        }
        public List<Turista> listadoTuristas()
        {
            List<Turista> lista = new List<Turista>();
            lista = contenedorrepo.repoTuristas.listadoTuristas();
            return lista;
        }
        #endregion
    }
}
