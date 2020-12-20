using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatosW
{
    public class clsModuloDatos
    {





        private static clsModuloDatos Cls = null;
        private clsModuloDatos() { }

        public static clsModuloDatos GetInstance()
        {

            if (Cls == null)
            {
                Cls = new clsModuloDatos();
            }
            return Cls;
        }




        public DataTable ListarModulos()
        {
            SqlConnection Con = null;
            DataTable tabla = new DataTable();
            SqlDataReader dr = null;
            try
            {
                Con = clsConexion.GetInstance().ConexionBD();
                SqlCommand Cmd = new SqlCommand("sp_listarModulo", Con);
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


        public DataTable BuscarModulo(string cadena)
        {
            SqlConnection Con = null;
            DataTable tabla = new DataTable();
            SqlDataReader dr = null;
            try
            {
                Con = clsConexion.GetInstance().ConexionBD();
                SqlCommand Cmd = new SqlCommand("[sp_buscarModuloNombre]", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@nombre", cadena);
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



        public void RegistrarModulo(CapaEntidadesW.clsModuloEntidad cls)
        {
            SqlConnection Con = null;
            DataTable tabla = new DataTable();
            try
            {
                Con = clsConexion.GetInstance().ConexionBD();
                SqlCommand Cmd = new SqlCommand("sp_insertarModulo", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@nombres", cls.Nombre);

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



        public void ActualizarModulo(CapaEntidadesW.clsModuloEntidad cls)
        {
            SqlConnection Con = null;
            DataTable tabla = new DataTable();
            try
            {
                Con = clsConexion.GetInstance().ConexionBD();
                SqlCommand Cmd = new SqlCommand("sp_actualizarModulo", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@idmodulo", cls.Idmodulo);
                Cmd.Parameters.AddWithValue("@nombre", cls.Nombre);
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

        public void EliminarModulo(int idmodulo)
        {
            SqlConnection Con = null;
            DataTable tabla = new DataTable();
            try
            {
                Con = clsConexion.GetInstance().ConexionBD();
                SqlCommand Cmd = new SqlCommand("sp_eliminarModulo", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@idmodulo", idmodulo);
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



        public CapaEntidadesW.clsModuloEntidad UbicarModulo(int idmodulo)
        {
            SqlConnection Con = null;
            //DataTable tabla = new DataTable();
            CapaEntidadesW.clsModuloEntidad cls = null;
            SqlDataReader rd = null;
            try
            {
                Con = clsConexion.GetInstance().ConexionBD();
                SqlCommand Cmd = new SqlCommand("sp_buscarModuloId", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@idmodulo", idmodulo);
                Con.Open();
                rd = Cmd.ExecuteReader();
                if (rd.Read())
                {
                    cls = new CapaEntidadesW.clsModuloEntidad();
                    cls.Idmodulo = Convert.ToInt32(rd["idrol"].ToString());
                    cls.Nombre = rd["nombre"].ToString();


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
