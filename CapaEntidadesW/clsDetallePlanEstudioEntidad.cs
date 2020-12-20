using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadesW
{
    public class clsDetallePlanEstudioEntidad
    {
        private int idDetallePlan;
        private int idPlanEstudio;
        private int idCurso;

        public int IdDetallePlan { get => idDetallePlan; set => idDetallePlan = value; }
        public int IdPlanEstudio { get => idPlanEstudio; set => idPlanEstudio = value; }
        public int IdCurso { get => idCurso; set => idCurso = value; }
    }
}
