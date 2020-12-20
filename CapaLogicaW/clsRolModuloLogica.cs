using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaW
{
    public class clsRolModuloLogica
    {




        private static clsRolModuloLogica Cls = null;
        private clsRolModuloLogica() { }

        public static clsRolModuloLogica GetInstance()
        {

            if (Cls == null)
            {
                Cls = new clsRolModuloLogica();
            }
            return Cls;
        }




        public DataTable ListarPermisos()
        {
            try
            {
                return CapaDatosW.clsRolModuloDatos.GetInstance().ListarRolesModulos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable BuscarRolModuloIdRol(int cadena)
        {
            try
            {
                return CapaDatosW.clsRolModuloDatos.GetInstance().BuscarRolModulo(cadena);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CambiarRolModulo(int idrolmodulo)
        {
            try
            {
                CapaDatosW.clsRolModuloDatos.GetInstance().CambiarRolModulo(idrolmodulo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AgregarRolModulo(int idrolmodulo)
        {
            try
            {
                CapaDatosW.clsRolModuloDatos.GetInstance().AgregarrRolModulo(idrolmodulo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void RegistrarRolModulo(CapaEntidadesW.clsRolModuloEntidad cls)
        {
            try
            {
                CapaDatosW.clsRolModuloDatos.GetInstance().RegistrarRolModulo(cls);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

      
        public CapaEntidadesW.clsRolModuloEntidad UbicarModulo(int idrolmodulo)
        {
            try
            {
                return CapaDatosW.clsRolModuloDatos.GetInstance().UbicarRolModulo(idrolmodulo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
