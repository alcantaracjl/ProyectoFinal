using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaW
{
    public class clsModuloLogica
    {


        private static clsModuloLogica Cls = null;
        private clsModuloLogica() { }

        public static clsModuloLogica GetInstance()
        {

            if (Cls == null)
            {
                Cls = new clsModuloLogica();
            }
            return Cls;
        }




        public DataTable ListarModulos()
        {
            try
            {
                return CapaDatosW.clsModuloDatos.GetInstance().ListarModulos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable BuscarModulo(string cadena)
        {
            try
            {
                return CapaDatosW.clsModuloDatos.GetInstance().BuscarModulo(cadena);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void EliminarModulo(int idmodulo)
        {
            try
            {
                CapaDatosW.clsModuloDatos.GetInstance().EliminarModulo(idmodulo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public void RegistrarModulo(CapaEntidadesW.clsModuloEntidad cls)
        {
            try
            {
                CapaDatosW.clsModuloDatos.GetInstance().RegistrarModulo(cls);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ActualizarModulo(CapaEntidadesW.clsModuloEntidad cls)
        {
            try
            {
                CapaDatosW.clsModuloDatos.GetInstance().ActualizarModulo(cls);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public CapaEntidadesW.clsModuloEntidad UbicarModulo(int idmodulo)
        {
            try
            {
                return CapaDatosW.clsModuloDatos.GetInstance().UbicarModulo(idmodulo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}
