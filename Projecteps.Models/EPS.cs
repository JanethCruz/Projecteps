using System;
using System.Collections.Generic;
using System.Text;

namespace Projecteps.Models
{
    public class EPS
    {
        public int EPSId { get; set; }
        public String NombreEPS { get; set; }
        public List<Persona> Personas { get; set; }
    }
}
