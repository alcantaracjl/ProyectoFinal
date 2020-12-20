using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaW
{
    public class clsSeccionLogica
    {

        private static clsSeccionLogica Cls = null;
        private clsSeccionLogica() { }

        public static clsSeccionLogica GetInstance()
        {

            if (Cls == null)
            {
                Cls = new clsSeccionLogica();
            }
            return Cls;
        }




        public DataTable ListaSecciones()
        {
            try
            {
                return CapaDatosW.clsSeccionDatos.GetInstance().ListarSeciones();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DataTable ListaSeccionesActivas()
        {
            try
            {
                return CapaDatosW.clsSeccionDatos.GetInstance().ListarSeccionActivos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
