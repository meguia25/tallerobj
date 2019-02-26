using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioDominio.EntidadesDeNegocio
{
    public class Viaje 
    {
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public Turista Turista { get; set; }

    }
}
