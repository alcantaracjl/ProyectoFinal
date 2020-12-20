using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatosW
{
    public class clsRolModuloDatos
    {



        private static clsRolModuloDatos Cls = null;
        private clsRolModuloDatos() { }

        public static clsRolModuloDatos GetInstance()
        {

            if (Cls == null)
            {
                Cls = new clsRolModuloDatos();
            }
            return Cls;
        }

        public DataTable BuscarRolModulo(int idrol)
        {
            SqlConnection Con = null;
            DataTable tabla = new DataTable();
            SqlDataReader dr = null;
            try
            {
                Con = clsConexion.GetInstance().ConexionBD();
                SqlCommand Cmd = new SqlCommand("[sp_ListarRolesModulosporIdROL]", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@idrol", idrol);
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


        public DataTable ListarRolesModulos()
        {
            SqlConnection Con = null;
            DataTable tabla = new DataTable();
            SqlDataReader dr = null;
            try
            {
                Con = clsConexion.GetInstance().ConexionBD();
                SqlCommand Cmd = new SqlCommand("sp_listarRolesModulos", Con);
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




        public void RegistrarRolModulo(CapaEntidadesW.clsRolModuloEntidad cls)
        {
            SqlConnection Con = null;
            DataTable tabla = new DataTable();
            try
            {
                Con = clsConexion.GetInstance().ConexionBD();
                SqlCommand Cmd = new SqlCommand("sp_insertarRolModulo", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@idrol", cls.Idrol);
                Cmd.Parameters.AddWithValue("@idmodulo", cls.IdModulo);

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



        public void ActualizarRolModulo(CapaEntidadesW.clsRolModuloEntidad cls)
        {
            SqlConnection Con = null;
            DataTable tabla = new DataTable();
            try
            {
                Con = clsConexion.GetInstance().ConexionBD();
                SqlCommand Cmd = new SqlCommand("sp_actualizarRolModulo", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@idrol", cls.Idrol);
                Cmd.Parameters.AddWithValue("@idmodulo", cls.IdModulo);
                Cmd.Parameters.AddWithValue("@estado", cls.Estado);
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

        public void CambiarRolModulo(int idrolmodulo)
        {
            SqlConnection Con = null;
            DataTable tabla = new DataTable();
            try
            {
                Con = clsConexion.GetInstance().ConexionBD();
                SqlCommand Cmd = new SqlCommand("sp_cambiarRolModulo", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@idrolmodulo", idrolmodulo);
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

        public void AgregarrRolModulo(int idrolmodulo)
        {
            SqlConnection Con = null;
            DataTable tabla = new DataTable();
            try
            {
                Con = clsConexion.GetInstance().ConexionBD();
                SqlCommand Cmd = new SqlCommand("sp_agregarRolModulo", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@idrolmodulo", idrolmodulo);
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

        public CapaEntidadesW.clsRolModuloEntidad UbicarRolModulo(int idrolmodulo)
        {
            SqlConnection Con = null;
            //DataTable tabla = new DataTable();
            CapaEntidadesW.clsRolModuloEntidad cls = null;
            SqlDataReader rd = null;
            try
            {
                Con = clsConexion.GetInstance().ConexionBD();
                SqlCommand Cmd = new SqlCommand("sp_buscarRolModuloId", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@idrolmodulo", idrolmodulo);
                Con.Open();
                rd = Cmd.ExecuteReader();
                if (rd.Read())
                {
                    cls = new CapaEntidadesW.clsRolModuloEntidad();
                    cls.Idrolmodulo = Convert.ToInt32(rd["idrolmodulo"].ToString());
                    cls.Idrol = Convert.ToInt32(rd["idrol"].ToString());
                    cls.Rolnombre = rd["rol"].ToString();
                    cls.IdModulo = Convert.ToInt32(rd["idmodulo"].ToString());
                    cls.Modulonombre = rd["modulo"].ToString();


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
