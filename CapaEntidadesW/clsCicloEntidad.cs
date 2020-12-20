using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadesW
{
    public class clsCicloEntidad
    {
        private int idCiclo;
            private String nombre;

        public int IdCiclo { get => idCiclo; set => idCiclo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
