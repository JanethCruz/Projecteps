using System;
using System.Collections.Generic;
using System.Text;

namespace Projecteps.Models
{
    public class Autorizacion
    {
        public int AutorizacionId { get; set; }
        public string Estado { get; set; }
        public string NombreDelEspecialista { get; set; }
        public string NombreDePrestacionDeServicio { get; set; }
        public string SalonDeCita { get; set; }
        public string FechaDeCita { get; set; }
        public string HoraDeCita { get; set; }
    }
}
