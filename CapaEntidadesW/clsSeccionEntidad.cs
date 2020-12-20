using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadesW
{
    public class clsSeccionEntidad
    {
        private int idSeccion;
        private String nombre;

        public int IdSeccion { get => idSeccion; set => idSeccion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
