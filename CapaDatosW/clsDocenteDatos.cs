using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatosW
{
    public class clsDocenteDatos
    {


        private static clsDocenteDatos Cls = null;
        private clsDocenteDatos() { }

        public static clsDocenteDatos GetInstance()
        {

            if (Cls == null)
            {
                Cls = new clsDocenteDatos();
            }
            return Cls;
        }

        public DataTable ListarDocentes()
        {
            SqlConnection Con = null;
            DataTable tabla = new DataTable();
            SqlDataReader dr = null;
            try
            {
                Con = clsConexion.GetInstance().ConexionBD();
                SqlCommand Cmd = new SqlCommand("sp_listarDocente", Con);
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


        public DataTable BuscarDocentePat(string cadena)
        {
            SqlConnection Con = null;
            DataTable tabla = new DataTable();
            SqlDataReader dr = null;
            try
            {
                Con = clsConexion.GetInstance().ConexionBD();
                SqlCommand Cmd = new SqlCommand("sp_buscarDocenteApellidoPat", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@apellidopat", cadena);
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

        public DataTable BuscarDocenteidusuario(string cadena)
        {
            SqlConnection Con = null;
            DataTable tabla = new DataTable();
            SqlDataReader dr = null;
            try
            {
                Con = clsConexion.GetInstance().ConexionBD();
                SqlCommand Cmd = new SqlCommand("sp_buscarDocenteidusuario", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@idusuario", cadena);
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

        public void RegistrarDocente(CapaEntidadesW.clsDocenteEntidad cls)
        {
            SqlConnection Con = null;
            DataTable tabla = new DataTable();
            try
            {
                Con = clsConexion.GetInstance().ConexionBD();
                SqlCommand Cmd = new SqlCommand("sp_insertarDocente", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@iddocente", cls.Iddocente);
                Cmd.Parameters.AddWithValue("@idusuario", cls.Idusuario);
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



        public void ActualizarDocente(CapaEntidadesW.clsDocenteEntidad cls)
        {
            SqlConnection Con = null;
            DataTable tabla = new DataTable();
            try
            {
                Con = clsConexion.GetInstance().ConexionBD();
                SqlCommand Cmd = new SqlCommand("sp_actualizarDocente", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@iddocente", cls.Iddocente);
                Cmd.Parameters.AddWithValue("@idusuario", cls.Idusuario);
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

        public void EliminarDocente(string id)
        {
            SqlConnection Con = null;
            DataTable tabla = new DataTable();
            try
            {
                Con = clsConexion.GetInstance().ConexionBD();
                SqlCommand Cmd = new SqlCommand("sp_eliminardocente", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@iddocente", id);
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



        public CapaEntidadesW.clsDocenteEntidad UbicarDocente(string id)
        {
            SqlConnection Con = null;
            //DataTable tabla = new DataTable();
            CapaEntidadesW.clsDocenteEntidad cls = null;
            SqlDataReader rd = null;
            try
            {
                Con = clsConexion.GetInstance().ConexionBD();
                SqlCommand Cmd = new SqlCommand("sp_buscarDocenteid", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@iddocente", id);
                Con.Open();
                rd = Cmd.ExecuteReader();
                if (rd.Read())
                {
                    cls = new CapaEntidadesW.clsDocenteEntidad();
                    cls.Iddocente = rd["iddocente"].ToString();
                    cls.Idusuario = rd["idusuario"].ToString();
                    cls.Estado = rd["Estado"].ToString();

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



        public CapaEntidadesW.clsDocenteEntidad UbicarDocenteIdUsuario(string id)
        {
            SqlConnection Con = null;
            //DataTable tabla = new DataTable();
            CapaEntidadesW.clsDocenteEntidad cls = null;
            SqlDataReader rd = null;
            try
            {
                Con = clsConexion.GetInstance().ConexionBD();
                SqlCommand Cmd = new SqlCommand("sp_buscarAlumnoidusuario", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@idusuario", id);
                Con.Open();
                rd = Cmd.ExecuteReader();
                if (rd.Read())
                {
                    cls = new CapaEntidadesW.clsDocenteEntidad();
                    cls.Iddocente = rd["iddocente"].ToString();
                    cls.Idusuario = rd["idusuario"].ToString();
                 
                    cls.Estado = rd["estado"].ToString();


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
