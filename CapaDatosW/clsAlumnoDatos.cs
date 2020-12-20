using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatosW
{
    public class clsAlumnoDatos
    {


        private static clsAlumnoDatos Cls = null;
        private clsAlumnoDatos() { }

        public static clsAlumnoDatos GetInstance()
        {

            if (Cls == null)
            {
                Cls = new clsAlumnoDatos();
            }
            return Cls;
        }





        public DataTable ListarAlumnos()
        {
            SqlConnection Con = null;
            DataTable tabla = new DataTable();
            SqlDataReader dr = null;
            try
            {
                Con = clsConexion.GetInstance().ConexionBD();
                SqlCommand Cmd = new SqlCommand("sp_listarAlumno", Con);
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


        public DataTable BuscarAlumnoPat(string cadena)
        {
            SqlConnection Con = null;
            DataTable tabla = new DataTable();
            SqlDataReader dr = null;
            try
            {
                Con = clsConexion.GetInstance().ConexionBD();
                SqlCommand Cmd = new SqlCommand("sp_buscarAlumnoApellidoPat", Con);
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

        public DataTable BuscarAlumnoidusuario(string cadena)
        {
            SqlConnection Con = null;
            DataTable tabla = new DataTable();
            SqlDataReader dr = null;
            try
            {
                Con = clsConexion.GetInstance().ConexionBD();
                SqlCommand Cmd = new SqlCommand("sp_buscarAlumnoidusuario", Con);
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

        public void RegistrarAlumno(CapaEntidadesW.clsAlumnoEntidad cls)
        {
            SqlConnection Con = null;
            DataTable tabla = new DataTable();
            try
            {
                Con = clsConexion.GetInstance().ConexionBD();
                SqlCommand Cmd = new SqlCommand("sp_insertarAlumno", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@codalumno", cls.CodAlumno);
                Cmd.Parameters.AddWithValue("@idescuela", cls.IdEscuela);
                Cmd.Parameters.AddWithValue("@idperiodo", cls.IdPeriodo);
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



        public void ActualizarAlumno(CapaEntidadesW.clsAlumnoEntidad cls)
        {
            SqlConnection Con = null;
            DataTable tabla = new DataTable();
            try
            {
                Con = clsConexion.GetInstance().ConexionBD();
                SqlCommand Cmd = new SqlCommand("sp_actualizarAlumno", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@codalumno", cls.CodAlumno);
                Cmd.Parameters.AddWithValue("@idescuela", cls.IdEscuela);
                Cmd.Parameters.AddWithValue("@idperiodo", cls.IdPeriodo);
                //Cmd.Parameters.AddWithValue("@idusuario", cls.Idusuario);
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

        public void EliminarAlumno(string id)
        {
            SqlConnection Con = null;
            DataTable tabla = new DataTable();
            try
            {
                Con = clsConexion.GetInstance().ConexionBD();
                SqlCommand Cmd = new SqlCommand("sp_eliminarAlumno", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@codalumno", id);
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



        public CapaEntidadesW.clsAlumnoEntidad UbicarAlumno(string id)
        {
            SqlConnection Con = null;
            //DataTable tabla = new DataTable();
            CapaEntidadesW.clsAlumnoEntidad cls = null;
            SqlDataReader rd = null;
            try
            {
                Con = clsConexion.GetInstance().ConexionBD();
                SqlCommand Cmd = new SqlCommand("sp_buscarAlumnoid", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@codalumno", id);
                Con.Open();
                rd = Cmd.ExecuteReader();
                if (rd.Read())
                {
                    cls = new CapaEntidadesW.clsAlumnoEntidad();
                    cls.CodAlumno = rd["codAlumno"].ToString();
                    cls.Idusuario = rd["idusuario"].ToString();
                    cls.IdEscuela = Convert.ToInt32(rd["idescuela"].ToString());
                    cls.NombreEscuela = rd["Escuela"].ToString();
                    cls.IdPeriodo = Convert.ToInt32(rd["idperiodo"].ToString());
                    cls.NombrePeriodo = rd["Sem_Ingreso"].ToString();
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



        public CapaEntidadesW.clsAlumnoEntidad UbicarAlumnoIdUsuario(string id)
        {
            SqlConnection Con = null;
            //DataTable tabla = new DataTable();
            CapaEntidadesW.clsAlumnoEntidad cls = null;
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
                    cls = new CapaEntidadesW.clsAlumnoEntidad();
                    cls.CodAlumno = rd["codAlumno"].ToString();
                    cls.Idusuario = rd["idusuario"].ToString();
                    cls.IdEscuela = Convert.ToInt32(rd["idescuela"].ToString());
                    cls.NombreEscuela = rd["Escuela"].ToString();
                    cls.IdPeriodo = Convert.ToInt32(rd["idperiodo"].ToString());
                    cls.NombrePeriodo = rd["Sem_Ingreso"].ToString();
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
