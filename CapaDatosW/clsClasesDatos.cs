using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatosW
{
    public class clsClasesDatos
    {




        private static clsClasesDatos Cls = null;
        private clsClasesDatos() { }

        public static clsClasesDatos GetInstance()
        {

            if (Cls == null)
            {
                Cls = new clsClasesDatos();
            }
            return Cls;
        }




        public DataTable ListarClasesTodas()
        {
            SqlConnection Con = null;
            DataTable tabla = new DataTable();
            SqlDataReader dr = null;
            try
            {
                Con = clsConexion.GetInstance().ConexionBD();
                SqlCommand Cmd = new SqlCommand("sp_listarClasesTodas", Con);
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



        public DataTable ListarClasesDisponibles()
        {
            SqlConnection Con = null;
            DataTable tabla = new DataTable();
            SqlDataReader dr = null;
            try
            {
                Con = clsConexion.GetInstance().ConexionBD();
                SqlCommand Cmd = new SqlCommand("sp_listarClasesDisponibles", Con);
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

        public DataTable ListarClasesPublicadas()
        {
            SqlConnection Con = null;
            DataTable tabla = new DataTable();
            SqlDataReader dr = null;
            try
            {
                Con = clsConexion.GetInstance().ConexionBD();
                SqlCommand Cmd = new SqlCommand("sp_listarClasesPublicadas", Con);
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




        public DataTable listarClasesporCicloNoRegistradas(int idescuela, int idciclo, string codalumno)
        {
            SqlConnection Con = null;
            DataTable tabla = new DataTable();
            SqlDataReader dr = null;
            try
            {
                Con = clsConexion.GetInstance().ConexionBD();
                SqlCommand Cmd = new SqlCommand("sp_listarClasesporCicloNoRegistradas", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@idescuela", idescuela);
                Cmd.Parameters.AddWithValue("@idciclo", idciclo);
                Cmd.Parameters.AddWithValue("@codalumno", codalumno);
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








        public DataTable ListarClasesLLenas()
        {
            SqlConnection Con = null;
            DataTable tabla = new DataTable();
            SqlDataReader dr = null;
            try
            {
                Con = clsConexion.GetInstance().ConexionBD();
                SqlCommand Cmd = new SqlCommand("sp_listarClasesLlenas", Con);
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


        public DataTable BuscarClaseCurso(string cadena)
        {
            SqlConnection Con = null;
            DataTable tabla = new DataTable();
            SqlDataReader dr = null;
            try
            {
                Con = clsConexion.GetInstance().ConexionBD();
                SqlCommand Cmd = new SqlCommand("sp_buscarClaseCurso", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@nombrecurso", cadena);
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



        public void RegistrarClase(CapaEntidadesW.clsClasesEntidad cls)
        {
            SqlConnection Con = null;
            DataTable tabla = new DataTable();
            try
            {
                Con = clsConexion.GetInstance().ConexionBD();
                SqlCommand Cmd = new SqlCommand("sp_insertarClases", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@idHorario", cls.IdHorario);
                Cmd.Parameters.AddWithValue("@idCurso", cls.IdCurso);
                Cmd.Parameters.AddWithValue("@idSeccion", cls.IdSeccion);
                Cmd.Parameters.AddWithValue("@vacantes", cls.Vacantes);
                Cmd.Parameters.AddWithValue("@estado", cls.Estado);
                Cmd.Parameters.AddWithValue("@iddocente", cls.Iddocente);


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



        public void ActualizarClase(CapaEntidadesW.clsClasesEntidad cls)
        {
            SqlConnection Con = null;
            DataTable tabla = new DataTable();
            try
            {
                Con = clsConexion.GetInstance().ConexionBD();
                SqlCommand Cmd = new SqlCommand("sp_actualizarClases", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@idclases", cls.Idclases);
                Cmd.Parameters.AddWithValue("@idHorario", cls.IdHorario);
                Cmd.Parameters.AddWithValue("@idCurso", cls.Idclases);
                Cmd.Parameters.AddWithValue("@idSeccion", cls.IdSeccion);
                Cmd.Parameters.AddWithValue("@vacantes", cls.Vacantes);
                Cmd.Parameters.AddWithValue("@estado", cls.Estado);
                Cmd.Parameters.AddWithValue("@iddocente", cls.Iddocente);

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

        public void EliminarClase(int id)
        {
            SqlConnection Con = null;
            DataTable tabla = new DataTable();
            try
            {
                Con = clsConexion.GetInstance().ConexionBD();
                SqlCommand Cmd = new SqlCommand("sp_eliminarClase", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@idclases", id);
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



        public CapaEntidadesW.clsClasesEntidad UbicarClase(int id)
        {
            SqlConnection Con = null;
            //DataTable tabla = new DataTable();
            CapaEntidadesW.clsClasesEntidad cls = null;
            SqlDataReader rd = null;
            try
            {
                Con = clsConexion.GetInstance().ConexionBD();
                SqlCommand Cmd = new SqlCommand("sp_buscarClasesTodasid", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@idclases", id);
                Con.Open();
                rd = Cmd.ExecuteReader();
                if (rd.Read())
                {
                    cls = new CapaEntidadesW.clsClasesEntidad();
                    cls.Idclases = Convert.ToInt32(rd["idclases"].ToString());
                    cls.IdHorario = Convert.ToInt32(rd["idHorario"].ToString());
                    cls.NombreHorario1 = (rd["Dia"].ToString()+": "+ rd["Horario"].ToString());
                    cls.IdCurso = Convert.ToInt32(rd["idCurso"].ToString());
                    cls.NombreCurso1 = rd["Curso"].ToString();
                    cls.IdSeccion = Convert.ToInt32(rd["idSeccion"].ToString());
                    cls.NombreSeccion1 = rd["Seccion"].ToString();
                    cls.Estado = rd["Estado"].ToString();
                    cls.Vacantes = Convert.ToInt32(rd["Vacantes"].ToString());
                    cls.Iddocente = Convert.ToInt32(rd["iddocente"].ToString());
                    cls.NombreDocente1 = rd["Docente"].ToString();

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
