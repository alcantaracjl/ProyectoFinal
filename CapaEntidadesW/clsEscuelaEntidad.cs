using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadesW
{
    public class clsEscuelaEntidad
    {
        private int idEscuela;
        private String nombre;
        private int idFacultad;
        private String nombreFacultad;
        private String estado;
        public int IdEscuela { get => idEscuela; set => idEscuela = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int IdFacultad { get => idFacultad; set => idFacultad = value; }
        public string Estado { get => estado; set => estado = value; }
        public string NombreFacultad { get => nombreFacultad; set => nombreFacultad = value; }
    }
}
