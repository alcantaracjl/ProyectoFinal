using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatosW
{
    public class clsMatriculaDatos
    {


        private static clsMatriculaDatos Cls = null;
        private clsMatriculaDatos() { }

        public static clsMatriculaDatos GetInstance()
        {

            if (Cls == null)
            {
                Cls = new clsMatriculaDatos();
            }
            return Cls;
        }





        public DataTable ListarMatriculaActivaIdUsuario(String id)
        {
            SqlConnection Con = null;
            DataTable tabla = new DataTable();
            SqlDataReader dr = null;
            try
            {
                Con = clsConexion.GetInstance().ConexionBD();
                SqlCommand Cmd = new SqlCommand("sp_listarMatriculaActivaIdUsuario", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@idusuario", id );
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
        

        public void RegistrarMatricula(CapaEntidadesW.clsMatriculaEntidad cls)
        {
            SqlConnection Con = null;
            DataTable tabla = new DataTable();
            try
            {
                Con = clsConexion.GetInstance().ConexionBD();
                SqlCommand Cmd = new SqlCommand("sp_insertarMatricula", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@codalumno", cls.CodAlumno);
                Cmd.Parameters.AddWithValue("@idperiodo", cls.IdPeriodo);
                Cmd.Parameters.AddWithValue("@idciclo", cls.IdCiclo);
                Cmd.Parameters.AddWithValue("@fecha", cls.Fecha);
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



        public void ReservarMatricula(CapaEntidadesW.clsMatriculaEntidad cls)
        {
            SqlConnection Con = null;
            DataTable tabla = new DataTable();
            try
            {
                Con = clsConexion.GetInstance().ConexionBD();
                SqlCommand Cmd = new SqlCommand("sp_reservarMatricula", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@idmatricula", cls.IdMatricula);
                Cmd.Parameters.AddWithValue("@fecha", cls.Fecha);
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

        public void EliminarMatricula(int id)
        {
            SqlConnection Con = null;
            DataTable tabla = new DataTable();
            try
            {
                Con = clsConexion.GetInstance().ConexionBD();
                SqlCommand Cmd = new SqlCommand("sp_eliminarMatricula", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@idmatricula", id);
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



        public CapaEntidadesW.clsMatriculaEntidad UbicarMatricula(int id)
        {
            SqlConnection Con = null;
            //DataTable tabla = new DataTable();
            CapaEntidadesW.clsMatriculaEntidad cls = null;
            SqlDataReader rd = null;
            try
            {
                Con = clsConexion.GetInstance().ConexionBD();
                SqlCommand Cmd = new SqlCommand("sp_buscarMatriculaid", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@idmatricula", id);
                Con.Open();
                rd = Cmd.ExecuteReader();
                if (rd.Read())
                {
                    cls = new CapaEntidadesW.clsMatriculaEntidad();
                    cls.IdMatricula = Convert.ToInt32(rd["idMatricula"].ToString());
                    cls.CodAlumno = rd["codAlumno"].ToString();
                    cls.Alumno1 = rd["Alumno"].ToString();
                    cls.IdPeriodo = Convert.ToInt32(rd["idPeriodo"].ToString());
                    cls.Periodo1 = rd["Periodo"].ToString();
                    cls.IdCiclo = Convert.ToInt32(rd["idCiclo"].ToString());
                    cls.Ciclo1 = rd["Ciclo"].ToString();
                    
                    cls.Fecha = Convert.ToDateTime(rd["Fecha"].ToString());
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


    }
}
