using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadesW
{
    public class clsCursoEntidad
    {
        private int idCurso;
        private String nombre;
        private int creditos;
        private String estado;
        public int IdCurso { get => idCurso; set => idCurso = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Creditos { get => creditos; set => creditos = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
