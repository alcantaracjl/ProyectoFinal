using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadesW
{
    public class clsPermisoLogin
    {
        private int accUsuario;
        private int permUsuarioCrear;
        private int permUsuarioActualizar;
        private int permUsuarioEliminar;
        private int permUsuarioListar;
        private int accCiclo;
        private int permCicloCrear;
        private int permCicloActualizar;
        private int permCicloEliminar;
        private int permCicloListar;

        public int AccUsuario { get => accUsuario; set => accUsuario = value; }
        public int PermUsuarioCrear { get => permUsuarioCrear; set => permUsuarioCrear = value; }
        public int PermUsuarioActualizar { get => permUsuarioActualizar; set => permUsuarioActualizar = value; }
        public int PermUsuarioEliminar { get => permUsuarioEliminar; set => permUsuarioEliminar = value; }
        public int PermUsuarioListar { get => permUsuarioListar; set => permUsuarioListar = value; }
        public int AccCiclo { get => accCiclo; set => accCiclo = value; }
        public int PermCicloCrear { get => permCicloCrear; set => permCicloCrear = value; }
        public int PermCicloActualizar { get => permCicloActualizar; set => permCicloActualizar = value; }
        public int PermCicloEliminar { get => permCicloEliminar; set => permCicloEliminar = value; }
        public int PermCicloListar { get => permCicloListar; set => permCicloListar = value; }
    }
}
