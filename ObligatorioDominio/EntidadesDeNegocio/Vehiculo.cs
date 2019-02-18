using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioDominio.EntidadesDeNegocio
{
    public class Vehiculo
    {
        public String Matricula { get; set; }
        public Marca Marca { get; set; }
        public Modelo Modelo { get; set; }
        public double Quilometraje { get; set; }
    }
}
