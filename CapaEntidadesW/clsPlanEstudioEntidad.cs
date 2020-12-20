using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadesW
{
    public class clsPlanEstudioEntidad
    {
        private int idPlanEstudio;
        private String nombre;
        private int idEscuela;
        private int idCiclo;

        public int IdPlanEstudio { get => idPlanEstudio; set => idPlanEstudio = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int IdEscuela { get => idEscuela; set => idEscuela = value; }
        public int IdCiclo { get => idCiclo; set => idCiclo = value; }
    }
}
