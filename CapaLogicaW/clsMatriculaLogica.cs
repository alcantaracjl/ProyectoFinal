using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaW
{
    public class clsMatriculaLogica
    {


        private static clsMatriculaLogica Cls = null;
        private clsMatriculaLogica() { }

        public static clsMatriculaLogica GetInstance()
        {

            if (Cls == null)
            {
                Cls = new clsMatriculaLogica();
            }
            return Cls;
        }



        public DataTable ListarMatriculaActivaIdUsuario(String id)
        {
            try
            {
                return CapaDatosW.clsMatriculaDatos.GetInstance().ListarMatriculaActivaIdUsuario(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void RegistrarMatricula(CapaEntidadesW.clsMatriculaEntidad cls)
        {
            try
            {
                CapaDatosW.clsMatriculaDatos.GetInstance().RegistrarMatricula(cls);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public void ReservarMatricula(CapaEntidadesW.clsMatriculaEntidad cls)
        {
            try
            {
                CapaDatosW.clsMatriculaDatos.GetInstance().ReservarMatricula(cls);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarMatricula(int id)
        {
            try
            {
                CapaDatosW.clsMatriculaDatos.GetInstance().EliminarMatricula(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public CapaEntidadesW.clsMatriculaEntidad UbicarMatricula(int id)
        {
            try
            {
                return CapaDatosW.clsMatriculaDatos.GetInstance().UbicarMatricula(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




    }
}
