using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaW
{
    public class clsCursosLogica
    {


        private static clsCursosLogica Cls = null;
        private clsCursosLogica() { }

        public static clsCursosLogica GetInstance()
        {

            if (Cls == null)
            {
                Cls = new clsCursosLogica();
            }
            return Cls;
        }




        public DataTable ListaCursos()
        {
            try
            {
                return CapaDatosW.clsCursoDatos.GetInstance().ListarCursos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DataTable ListaCursosActivas()
        {
            try
            {
                return CapaDatosW.clsCursoDatos.GetInstance().ListarCursoActivas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable BuscarCursoNombre(string cadena)
        {
            try
            {
                return CapaDatosW.clsCursoDatos.GetInstance().BuscarCursoNombre(cadena);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void EliminarCurso(int id)
        {
            try
            {
                CapaDatosW.clsCursoDatos.GetInstance().EliminarCurso(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public void RegistrarCurso(CapaEntidadesW.clsCursoEntidad cls)
        {
            try
            {
                CapaDatosW.clsCursoDatos.GetInstance().RegistrarCurso(cls);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ActualizarCurso(CapaEntidadesW.clsCursoEntidad cls)
        {
            try
            {
                CapaDatosW.clsCursoDatos.GetInstance().ActualizarCurso(cls);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public CapaEntidadesW.clsCursoEntidad UbicarCurso(int id)
        {
            try
            {
                return CapaDatosW.clsCursoDatos.GetInstance().UbicarCurso(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }




}
