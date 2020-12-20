using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaW
{
    public class clsDetalleMatriculaLogica
    {
        private static clsDetalleMatriculaLogica Cls = null;
        private clsDetalleMatriculaLogica() { }

        public static clsDetalleMatriculaLogica GetInstance()
        {

            if (Cls == null)
            {
                Cls = new clsDetalleMatriculaLogica();
            }
            return Cls;
        }


        public void RegistrarDetalleMatricula(CapaEntidadesW.clsDetalleMatriculaEntidad cls)
        {
            try
            {
                CapaDatosW.clsDetalle_MatriculaDatos.GetInstance().RegistrarDetalleMatricula(cls);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
