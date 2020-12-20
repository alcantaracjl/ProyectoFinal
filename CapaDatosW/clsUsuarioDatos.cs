using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatosW
{
    public class clsUsuarioDatos
    {

        private static clsUsuarioDatos Cls = null;
        private clsUsuarioDatos() { }

        public static clsUsuarioDatos GetInstance()
        {

            if (Cls == null)
            {
                Cls = new clsUsuarioDatos();
            }
            return Cls;
        }



        public CapaEntidadesW.clsUsuarioEntidad login(string usuario, string clave)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            CapaEntidadesW.clsUsuarioEntidad Cls = null;
            SqlDataReader rd = null;
            try
            {
                con = clsConexion.GetInstance().ConexionBD();
                cmd = new SqlCommand("sp_login", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idusuario", usuario);
                cmd.Parameters.AddWithValue("@contrasenia", clave);
                con.Open();
                rd = cmd.ExecuteReader();
                if(rd.Read()) {
                    Cls = new CapaEntidadesW.clsUsuarioEntidad();
                    Cls.Idusuario = rd["idusuario"].ToString();
                    Cls.Contrasenia = rd["contrasenia"].ToString();
                    Cls.Tipousuario = rd["tipousuario"].ToString();
                    Cls.Nombres = rd["nombres"].ToString();
                    Cls.ApellidoPat = rd["apellidoPat"].ToString();
                    Cls.ApellidoMat = rd["apellidoMat"].ToString();
                    Cls.Telefono = rd["telefono"].ToString();
                    Cls.Correo = rd["correo"].ToString();
                    Cls.CodAlumno = rd["codAlumno"].ToString(); 
                  Cls.Idrol = Convert.ToInt32(rd["idrol"].ToString());
                  


                }


            }
            catch(Exception ex) {
                Cls = null;
                throw ex;

            }
            finally { con.Close(); }
            return Cls;

        }

        public DataTable ListarUsuarios()
        {
            SqlConnection Con = null;
            DataTable tabla = new DataTable();
            SqlDataReader dr = null;
            try
            {
                Con = clsConexion.GetInstance().ConexionBD();
                SqlCommand Cmd = new SqlCommand("sp_listarUruario", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Con.Open();
                dr = Cmd.ExecuteReader();
                tabla.Load(dr);
            }
            catch (Exception e)
            {
                tabla = null;
                throw e;
            }
            finally
            {
                Con.Close();
            }
            return tabla;
        }


        public DataTable BuscarUsuario(string cadena)
        {
            SqlConnection Con = null;
            DataTable tabla = new DataTable();
            SqlDataReader dr = null;
            try
            {
                Con = clsConexion.GetInstance().ConexionBD();
                SqlCommand Cmd = new SqlCommand("sp_buscarUsuarioPat", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@ApellidoPat", cadena);
                Con.Open();
                dr = Cmd.ExecuteReader();
                tabla.Load(dr);
            }
            catch (Exception e)
            {
                tabla = null;
                throw e;
            }
            finally
            {
                Con.Close();
            }
            return tabla;
        }



        public void RegistrarUsuario(CapaEntidadesW.clsUsuarioEntidad cls)
        {
            SqlConnection Con = null;
            DataTable tabla = new DataTable();
            try
            {
                Con = clsConexion.GetInstance().ConexionBD();
                SqlCommand Cmd = new SqlCommand("sp_insertarUsuario", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@idusuario", cls.Idusuario);
                Cmd.Parameters.AddWithValue("@contrasenia", cls.Contrasenia);
                Cmd.Parameters.AddWithValue("@nombres", cls.Nombres);
                Cmd.Parameters.AddWithValue("@apellidopat", cls.ApellidoPat);
                Cmd.Parameters.AddWithValue("@apellidomat", cls.ApellidoMat);
                Cmd.Parameters.AddWithValue("@telefono", cls.Telefono);
                Cmd.Parameters.AddWithValue("@correo", cls.Correo);
                Cmd.Parameters.AddWithValue("@estado", cls.Estado);
                Cmd.Parameters.AddWithValue("@idrol", cls.Idrol);
                Con.Open();
                Cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                tabla = null;
                throw e;
            }
            finally
            {
                Con.Close();
            }
        }



        public void ActualizarUsuario(CapaEntidadesW.clsUsuarioEntidad cls)
        {
            SqlConnection Con = null;
            DataTable tabla = new DataTable();
            try
            {
                Con = clsConexion.GetInstance().ConexionBD();
                SqlCommand Cmd = new SqlCommand("sp_actualizarUsuario", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@idusuario", cls.Idusuario);
                Cmd.Parameters.AddWithValue("@contrasenia", cls.Contrasenia);
                Cmd.Parameters.AddWithValue("@nombres", cls.Nombres);
                Cmd.Parameters.AddWithValue("@apellidopat", cls.ApellidoPat);
                Cmd.Parameters.AddWithValue("@apellidomat", cls.ApellidoMat);
                Cmd.Parameters.AddWithValue("@telefono", cls.Telefono);
                Cmd.Parameters.AddWithValue("@correo", cls.Correo);
                Cmd.Parameters.AddWithValue("@estado", cls.Estado);
                Cmd.Parameters.AddWithValue("@idrol", cls.Idrol);

                Con.Open();
                Cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                tabla = null;
                throw e;
            }
            finally
            {
                Con.Close();
            }
        }

        public void EliminarUsuario(string idusuario)
        {
            SqlConnection Con = null;
            DataTable tabla = new DataTable();
            try
            {
                Con = clsConexion.GetInstance().ConexionBD();
                SqlCommand Cmd = new SqlCommand("sp_bajarUsuario", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@idusuario", idusuario);
                Con.Open();
                Cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                tabla = null;
                throw e;
            }
            finally
            {
                Con.Close();
            }
        }



        public CapaEntidadesW.clsUsuarioEntidad UbicarUsuario(string idusuario)
        {
            SqlConnection Con = null;
            //DataTable tabla = new DataTable();
            CapaEntidadesW.clsUsuarioEntidad cls = null;
            SqlDataReader rd = null;
            try
            {
                Con = clsConexion.GetInstance().ConexionBD();
                SqlCommand Cmd = new SqlCommand("sp_buscarUsuarioId", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@idusuario", idusuario);
                Con.Open();
                rd = Cmd.ExecuteReader();
                if (rd.Read())
                {
                    cls = new CapaEntidadesW.clsUsuarioEntidad();
                    cls.Idusuario = rd["idusuario"].ToString();
                    cls.Contrasenia = rd["contrasenia"].ToString();
                    cls.Nombres = rd["nombres"].ToString();
                    cls.ApellidoPat = rd["apellidoPat"].ToString();
                    cls.ApellidoMat = rd["apellidoMat"].ToString();
                    cls.Telefono = rd["telefono"].ToString();
                    cls.Correo = rd["correo"].ToString();
                    cls.Estado = rd["estado"].ToString();
                    cls.Tipousuario = rd["tipousuario"].ToString();
                    cls.Idrol = Convert.ToInt32(rd["idrol"].ToString());
                }
            }
            catch (Exception e)
            {
                cls = null;
                throw e;
            }
            finally
            {
                Con.Close();
            }
            return cls;
        }









    }
}
