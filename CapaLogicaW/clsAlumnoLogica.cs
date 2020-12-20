using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaW
{
    public class clsAlumnoLogica
    {


        private static clsAlumnoLogica Cls = null;
        private clsAlumnoLogica() { }

        public static clsAlumnoLogica GetInstance()
        {

            if (Cls == null)
            {
                Cls = new clsAlumnoLogica();
            }
            return Cls;
        }



        public DataTable ListaAlumnos()
        {
            try
            {
                return CapaDatosW.clsAlumnoDatos.GetInstance().ListarAlumnos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable BuscarAlumnoPat(string cadena)
        {
            try
            {
                return CapaDatosW.clsAlumnoDatos.GetInstance().BuscarAlumnoPat(cadena);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DataTable BuscarAlumnoIdUsuario(string cadena)
        {
            try
            {
                return CapaDatosW.clsAlumnoDatos.GetInstance().BuscarAlumnoidusuario(cadena);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void EliminarAlumno(string codAlumno)
        {
            try
            {
                CapaDatosW.clsAlumnoDatos.GetInstance().EliminarAlumno(codAlumno);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public void RegistrarAlumno(CapaEntidadesW.clsAlumnoEntidad cls)
        {
            try
            {
                CapaDatosW.clsAlumnoDatos.GetInstance().RegistrarAlumno(cls);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ActualizarAlumno(CapaEntidadesW.clsAlumnoEntidad cls)
        {
            try
            {
                CapaDatosW.clsAlumnoDatos.GetInstance().ActualizarAlumno(cls);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public CapaEntidadesW.clsAlumnoEntidad UbicarAlumno(string idUsuario)
        {
            try
            {
                return CapaDatosW.clsAlumnoDatos.GetInstance().UbicarAlumno(idUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public CapaEntidadesW.clsAlumnoEntidad UbicarAlumnoIdUsuario(string idUsuario)
        {
            try
            {
                return CapaDatosW.clsAlumnoDatos.GetInstance().UbicarAlumnoIdUsuario(idUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}
