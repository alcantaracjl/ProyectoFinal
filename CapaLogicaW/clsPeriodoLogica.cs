using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaW
{
    public class clsPeriodoLogica
    {




        private static clsPeriodoLogica Cls = null;
        private clsPeriodoLogica() { }

        public static clsPeriodoLogica GetInstance()
        {

            if (Cls == null)
            {
                Cls = new clsPeriodoLogica();
            }
            return Cls;
        }




        public DataTable ListaPeriodos()
        {
            try
            {
                return CapaDatosW.clsPeriodoDatos.GetInstance().ListarPeriodo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DataTable ListarPeriodoActivas()
        {
            try
            {
                return CapaDatosW.clsPeriodoDatos.GetInstance().ListarPeriodoActivas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable BuscarPeriodoNombre(string cadena)
        {
            try
            {
                return CapaDatosW.clsPeriodoDatos.GetInstance().BuscarPeriodoNombre(cadena);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void EliminarPeriodo(int idperiodo)
        {
            try
            {
                CapaDatosW.clsPeriodoDatos.GetInstance().EliminarPeriodo(idperiodo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public void RegistrarPeriodo(CapaEntidadesW.clsPeriodoEntidad cls)
        {
            try
            {
                CapaDatosW.clsPeriodoDatos.GetInstance().RegistrarPeriodo(cls);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ActualizarPeriodo(CapaEntidadesW.clsPeriodoEntidad cls)
        {
            try
            {
                CapaDatosW.clsPeriodoDatos.GetInstance().ActualizarPeriodo(cls);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public CapaEntidadesW.clsPeriodoEntidad UbicarPeriodo(int idperiodo)
        {
            try
            {
                return CapaDatosW.clsPeriodoDatos.GetInstance().UbicarPeriodo(idperiodo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
