using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObligatorioDominio.Interfaces;
using ObligatorioDominio.EntidadesDeNegocio;
using ObligatorioDominio.Repositorios;

namespace ObligatorioDominio.Fachada
{
    public class Fachada
    {
        private ContenedorRepositorios contenedorrepo = ContenedorRepositorios.Instancia;

        #region Turista

        public bool agregarTurista(String nombre, String pais, int nDocumento)
        {
            Turista nuevoTurista = new Turista
            {
                unNombre = nombre,
                unPais = pais,
                unNDocumento = nDocumento

            };
            bool alta = false;
            contenedorrepo.agregarTurista(unNombre, unPais, unNDocumento);
            return alta;
        }
        #endregion
    }
}
