using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadesW
{
    public class clsDocenteEntidad
    {
        private String iddocente;
        private String idusuario;
        private String estado;
        public String Iddocente { get => iddocente; set => iddocente = value; }
        public string Idusuario { get => idusuario; set => idusuario = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
