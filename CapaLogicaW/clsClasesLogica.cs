using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaW
{
    public class clsClasesLogica
    {


        private static clsClasesLogica Cls = null;
        private clsClasesLogica() { }

        public static clsClasesLogica GetInstance()
        {

            if (Cls == null)
            {
                Cls = new clsClasesLogica();
            }
            return Cls;
        }



        public DataTable ListarClasesTodas()
        {
            try
            {
                return CapaDatosW.clsClasesDatos.GetInstance().ListarClasesTodas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DataTable ListarClasesporCicloNoRegistradas(int idescuela, int idciclo, string codalumno)
        {
            try
            {
                return CapaDatosW.clsClasesDatos.GetInstance().listarClasesporCicloNoRegistradas(idescuela,idciclo,codalumno);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ListarClasesDisponibles()
        {
            try
            {
                return CapaDatosW.clsClasesDatos.GetInstance().ListarClasesDisponibles();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ListarClasesLLenas()
        {
            try
            {
                return CapaDatosW.clsClasesDatos.GetInstance().ListarClasesLLenas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



       
        public DataTable BuscarClaseCurso(string cadena)
        {
            try
            {
                return CapaDatosW.clsClasesDatos.GetInstance().BuscarClaseCurso(cadena);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void EliminarClase(int id)
        {
            try
            {
                CapaDatosW.clsClasesDatos.GetInstance().EliminarClase(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public void RegistrarClase(CapaEntidadesW.clsClasesEntidad cls)
        {
            try
            {
                CapaDatosW.clsClasesDatos.GetInstance().RegistrarClase(cls);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ActualizarClase(CapaEntidadesW.clsClasesEntidad cls)
        {
            try
            {
                CapaDatosW.clsClasesDatos.GetInstance().ActualizarClase(cls);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public CapaEntidadesW.clsClasesEntidad UbicarClase(int id)
        {
            try
            {
                return CapaDatosW.clsClasesDatos.GetInstance().UbicarClase(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




    }
}
