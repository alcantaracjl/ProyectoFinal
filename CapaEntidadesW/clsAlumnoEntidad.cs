using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadesW
{
    public class clsAlumnoEntidad
    {
        private String codAlumno;
        private int idEscuela;
        private String nombreEscuela;
        private int idPeriodo;
        private String nombrePeriodo;
        private String idusuario;
        private String estado;


        public string CodAlumno { get => codAlumno; set => codAlumno = value; }
        public int IdEscuela { get => idEscuela; set => idEscuela = value; }
        public int IdPeriodo { get => idPeriodo; set => idPeriodo = value; }
        public string Idusuario { get => idusuario; set => idusuario = value; }
        public string Estado { get => estado; set => estado = value; }
        public string NombreEscuela { get => nombreEscuela; set => nombreEscuela = value; }
        public string NombrePeriodo { get => nombrePeriodo; set => nombrePeriodo = value; }
       
    }
}
