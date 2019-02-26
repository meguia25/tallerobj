using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioDominio.EntidadesDeNegocio
{
    public class Turista: Usuario
    {
        public String Nombre { get; set; }
        public String Pais { get; set; }
        public int NDocumento { get; set; }
        public List<Viaje> Viajes { get; set; }
    }
}
