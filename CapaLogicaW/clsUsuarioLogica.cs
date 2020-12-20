using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaW
{
    public class clsUsuarioLogica
    {

        private static clsUsuarioLogica Cls = null;
        private clsUsuarioLogica() { }

        public static clsUsuarioLogica GetInstance()
        {

            if (Cls == null)
            {
                Cls = new clsUsuarioLogica();
            }
            return Cls;
        }


        public CapaEntidadesW.clsUsuarioEntidad Acceso(string usuario, string clave)
        {
            try
            {
                return CapaDatosW.clsUsuarioDatos.GetInstance().login(usuario, clave);

            }

            catch(Exception ex)
            {
                throw ex;


            }

        }


        public DataTable ListarUsuarios()
        {
            try
            {
                return CapaDatosW.clsUsuarioDatos.GetInstance().ListarUsuarios();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable BuscarUsuario(string cadena)
        {
            try
            {
                return CapaDatosW.clsUsuarioDatos.GetInstance().BuscarUsuario(cadena);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void EliminarUsuario(string idusuario)
        {
            try
            {
                CapaDatosW.clsUsuarioDatos.GetInstance().EliminarUsuario(idusuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public void RegistrarUsuario(CapaEntidadesW.clsUsuarioEntidad cls)
        {
            try
            {
                CapaDatosW.clsUsuarioDatos.GetInstance().RegistrarUsuario(cls);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ActualizarUsuario(CapaEntidadesW.clsUsuarioEntidad cls)
        {
            try
            {
                CapaDatosW.clsUsuarioDatos.GetInstance().ActualizarUsuario(cls);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public CapaEntidadesW.clsUsuarioEntidad UbicarUsuario(string idUsuario)
        {
            try
            {
                return CapaDatosW.clsUsuarioDatos.GetInstance().UbicarUsuario(idUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}
