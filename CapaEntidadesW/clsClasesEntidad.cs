using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadesW
{
    public class clsClasesEntidad
    {
        private int idclases;
        private int idHorario;
        private String NombreHorario;
        private int idCurso;
        private String NombreCurso;
        private int idSeccion;
        private String NombreSeccion;
        private int vacantes;
        private String estado;
        private int iddocente;
        private String NombreDocente;

        public int Idclases { get => idclases; set => idclases = value; }
        public int IdHorario { get => idHorario; set => idHorario = value; }
        public int IdCurso { get => idCurso; set => idCurso = value; }
        public int IdSeccion { get => idSeccion; set => idSeccion = value; }
        public int Vacantes { get => vacantes; set => vacantes = value; }
        public string Estado { get => estado; set => estado = value; }
        public int Iddocente { get => iddocente; set => iddocente = value; }
        public string NombreHorario1 { get => NombreHorario; set => NombreHorario = value; }
        public string NombreCurso1 { get => NombreCurso; set => NombreCurso = value; }
        public string NombreSeccion1 { get => NombreSeccion; set => NombreSeccion = value; }
        public string NombreDocente1 { get => NombreDocente; set => NombreDocente = value; }
    }
}
