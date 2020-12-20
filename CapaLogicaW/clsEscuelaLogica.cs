using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaW
{
    public class clsEscuelaLogica
    {



        private static clsEscuelaLogica Cls = null;
        private clsEscuelaLogica() { }

        public static clsEscuelaLogica GetInstance()
        {

            if (Cls == null)
            {
                Cls = new clsEscuelaLogica();
            }
            return Cls;
        }



       
        public DataTable ListaEscuelas()
        {
            try
            {
                return CapaDatosW.clsEscuelaDatos.GetInstance().ListarEscuelas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DataTable ListaEscuelasActivas()
        {
            try
            {
                return CapaDatosW.clsEscuelaDatos.GetInstance().ListarEscuelasActivas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable BuscarEscuelaNombre(string cadena)
        {
            try
            {
                return CapaDatosW.clsEscuelaDatos.GetInstance().BuscarEscuelaNombre(cadena);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void EliminarEscuela(int idescuela)
        {
            try
            {
                CapaDatosW.clsEscuelaDatos.GetInstance().EliminarEscuela(idescuela);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public void RegistrarEscuela(CapaEntidadesW.clsEscuelaEntidad cls)
        {
            try
            {
                CapaDatosW.clsEscuelaDatos.GetInstance().RegistrarEscuela(cls);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ActualizarEscuela(CapaEntidadesW.clsEscuelaEntidad cls)
        {
            try
            {
                CapaDatosW.clsEscuelaDatos.GetInstance().ActualizarEscuela(cls);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public CapaEntidadesW.clsEscuelaEntidad UbicarEscuela(int idescuela)
        {
            try
            {
                return CapaDatosW.clsEscuelaDatos.GetInstance().UbicarEscuela(idescuela);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }







    }
}





