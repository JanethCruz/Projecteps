using System;
using System.Collections.Generic;
using System.Text;

namespace Projecteps.Models
{
   public class TipoDeVinculacion
    {
        public int VinculacionId { get; set; }
        public List<EPS> SeleccioneEPS { get; set; }
        public List<Afiliacion> NovedadyFormulario { get; set; }
        public string Nombre { get; set; }
    }
}
