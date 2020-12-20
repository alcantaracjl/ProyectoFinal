using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadesW
{
    public class clsMatriculaEntidad
    {
        private int idMatricula;
        private String codAlumno;
        private String Alumno;

        private int idPeriodo;
        private String Periodo;
        private int idCiclo;
        private String Ciclo;
        private DateTime fecha;
        private String estado;

        public int IdMatricula { get => idMatricula; set => idMatricula = value; }
        public string CodAlumno { get => codAlumno; set => codAlumno = value; }
        public int IdPeriodo { get => idPeriodo; set => idPeriodo = value; }
        public int IdCiclo { get => idCiclo; set => idCiclo = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Alumno1 { get => Alumno; set => Alumno = value; }
        public string Periodo1 { get => Periodo; set => Periodo = value; }
        public string Ciclo1 { get => Ciclo; set => Ciclo = value; }
    }
}
