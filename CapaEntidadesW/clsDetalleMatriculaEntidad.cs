using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadesW
{
    public class clsDetalleMatriculaEntidad
    {
    private int idDetalleMatricula;
        private int idMatricula;
        private int idClases;
        private String estado;

        public int IdDetalleMatricula { get => idDetalleMatricula; set => idDetalleMatricula = value; }
        public int IdMatricula { get => idMatricula; set => idMatricula = value; }
        public int IdClases { get => idClases; set => idClases = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
