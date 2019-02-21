using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioDominio.EntidadesDeNegocio
{
    public class Modelo
    {
        public String Tipo { get; set; }
        public int Capacidad { get; set; }
        public int KmXLitro { get; set; }
        public String Nombre { get; set; }
        public Marca Marca { get; set; }
    }
}
