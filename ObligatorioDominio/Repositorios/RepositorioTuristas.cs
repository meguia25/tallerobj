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
        public Turista buscarTurista(int unNDocumento)
        {
            Turista elTurista = null;
            bool bandera = false;
            int i = 0;
            while (i < ListaTuristas.Count && !bandera)
            {
                if (ListaTuristas[i].NDocumento == unNDocumento)
                {
                    elTurista = ListaTuristas[i];
                    bandera = true;
                }
            }
            return elTurista;
        }
        public bool cambiarContraseña(string nuevaContraseña)
        {
            bool cambio = false;
            


            return cambio;
        }
        public List<Turista> listadoTuristas()
        {
            List<Turista> lista = new List<Turista>();
            foreach (Turista v in this.ListaTuristas)
            {
                lista.Add(v);
            }

            return lista;
        }
    }
}
