using System;
using System.Collections.Generic;
using System.Text;

namespace Projecteps.Models
{
    public class Persona
    {
        public int PersonaId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string TipoDeDocumento { get; set; }
        public string Telefono { get; set; }
        public string Edad { get; set; }
        public string Departamento { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public TipoDeVinculacion Tipo { get; set; }
        public List<Autorizacion> Autorizaciones { get; set; }
        public List<Afiliacion> Afiliaciones { get; set; }
    }
}
