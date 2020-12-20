using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadesW
{
    public class clsRolModuloEntidad
    {
        private int idrolmodulo;
        private int idrol;
        private string rolnombre;
        private int idmodulo;
        private string modulonombre;
        private string estado;

        public int Idrolmodulo { get => idrolmodulo; set => idrolmodulo = value; }
        public int Idrol { get => idrol; set => idrol = value; }
        public string Rolnombre { get => rolnombre; set => rolnombre = value; }
        public int IdModulo { get => idmodulo; set => idmodulo = value; }
        public string Modulonombre { get => modulonombre; set => modulonombre = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
