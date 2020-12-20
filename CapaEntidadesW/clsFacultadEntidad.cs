using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadesW
{
    public class clsFacultadEntidad
    {
        private int idFacultad;
        private String abreviatura;
        private String nombre;

        public int IdFacultad { get => idFacultad; set => idFacultad = value; }
        public string Abreviatura { get => abreviatura; set => abreviatura = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
