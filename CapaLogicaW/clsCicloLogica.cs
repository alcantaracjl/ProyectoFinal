using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaW
{
   public class clsCicloLogica
    {

        private static clsCicloLogica Cls = null;
        private clsCicloLogica() { }

        public static clsCicloLogica GetInstance()
        {

            if (Cls == null)
            {
                Cls = new clsCicloLogica();
            }
            return Cls;
        }




        public DataTable ListaCiclo()
        {
            try
            {
                return CapaDatosW.clsCicloDatos.GetInstance().ListarCiclo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
