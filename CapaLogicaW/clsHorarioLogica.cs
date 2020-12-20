using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaW
{
    public class clsHorarioLogica

    {


        private static clsHorarioLogica Cls = null;
        private clsHorarioLogica() { }

        public static clsHorarioLogica GetInstance()
        {

            if (Cls == null)
            {
                Cls = new clsHorarioLogica();
            }
            return Cls;
        }




        public DataTable ListaHorarios()
        {
            try
            {
                return CapaDatosW.clsHorarioDatos.GetInstance().ListarHorarios();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DataTable ListaHorariosActivos()
        {
            try
            {
                return CapaDatosW.clsHorarioDatos.GetInstance().ListarHorariosActivos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
