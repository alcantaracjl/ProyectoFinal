using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaW
{
    public class clsDocenteLogica
    {



        private static clsDocenteLogica Cls = null;
        private clsDocenteLogica() { }

        public static clsDocenteLogica GetInstance()
        {

            if (Cls == null)
            {
                Cls = new clsDocenteLogica();
            }
            return Cls;
        }



        public DataTable ListaDocentes()
        {
            try
            {
                return CapaDatosW.clsDocenteDatos.GetInstance().ListarDocentes();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable BuscarDocentePat(string cadena)
        {
            try
            {
                return CapaDatosW.clsDocenteDatos.GetInstance().BuscarDocentePat(cadena);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DataTable BuscarDocenteIdUsuario(string cadena)
        {
            try
            {
                return CapaDatosW.clsDocenteDatos.GetInstance().BuscarDocenteidusuario(cadena);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void EliminarDocente(string codAlumno)
        {
            try
            {
                CapaDatosW.clsDocenteDatos.GetInstance().EliminarDocente(codAlumno);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public void RegistrarDocente(CapaEntidadesW.clsDocenteEntidad cls)
        {
            try
            {
                CapaDatosW.clsDocenteDatos.GetInstance().RegistrarDocente(cls);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ActualizarDocente(CapaEntidadesW.clsDocenteEntidad cls)
        {
            try
            {
                CapaDatosW.clsDocenteDatos.GetInstance().ActualizarDocente(cls);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public CapaEntidadesW.clsDocenteEntidad UbicarDocente(string id)
        {
            try
            {
                return CapaDatosW.clsDocenteDatos.GetInstance().UbicarDocente(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public CapaEntidadesW.clsDocenteEntidad UbicarDocenteIdUsuario(string id)
        {
            try
            {
                return CapaDatosW.clsDocenteDatos.GetInstance().UbicarDocenteIdUsuario(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}
