using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadesW
{
    public class clsUsuarioEntidad
    {
        private String idusuario;
        private String contrasenia;
        private String tipousuario;
        private String nombres;
            private String apellidoPat;
            private String apellidoMat;
        private String telefono;
        private String correo;
        private String estado;
        private String codAlumno;
        private int idrol;

        public string Idusuario { get => idusuario; set => idusuario = value; }
        public string Contrasenia { get => contrasenia; set => contrasenia = value; }
        public string Tipousuario { get => tipousuario; set => tipousuario = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string ApellidoPat { get => apellidoPat; set => apellidoPat = value; }
        public string ApellidoMat { get => apellidoMat; set => apellidoMat = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Estado { get => estado; set => estado = value; }
        public String CodAlumno { get => codAlumno; set => codAlumno = value; }
        public int Idrol { get => idrol; set => idrol = value; }
    }
}
