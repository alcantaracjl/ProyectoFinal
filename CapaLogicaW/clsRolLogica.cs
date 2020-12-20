using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaW
{
    public class clsRolLogica
    {


        private static clsRolLogica Cls = null;
        private clsRolLogica() { }

        public static clsRolLogica GetInstance()
        {

            if (Cls == null)
            {
                Cls = new clsRolLogica();
            }
            return Cls;
        }


        

        public DataTable ListarRoles()
        {
            try
            {
                return CapaDatosW.clsRolDatos.GetInstance().ListarRoles();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable BuscarRol(string cadena)
        {
            try
            {
                return CapaDatosW.clsRolDatos.GetInstance().BuscarRol(cadena);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void EliminarRol(int idrol)
        {
            try
            {
                CapaDatosW.clsRolDatos.GetInstance().EliminarRol(idrol);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public void RegistrarRol(CapaEntidadesW.clsRolEntidad cls)
        {
            try
            {
                CapaDatosW.clsRolDatos.GetInstance().RegistrarRol(cls);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ActualizarRol(CapaEntidadesW.clsRolEntidad cls)
        {
            try
            {
                CapaDatosW.clsRolDatos.GetInstance().ActualizarRol(cls);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public CapaEntidadesW.clsRolEntidad UbicarRol(int irrol)
        {
            try
            {
                return CapaDatosW.clsRolDatos.GetInstance().UbicarRol(irrol);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




    }
}
