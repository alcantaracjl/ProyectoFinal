using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatosW
{
    public class clsDetalle_MatriculaDatos
    {
        private static clsDetalle_MatriculaDatos Cls = null;
        private clsDetalle_MatriculaDatos() { }

        public static clsDetalle_MatriculaDatos GetInstance()
        {

            if (Cls == null)
            {
                Cls = new clsDetalle_MatriculaDatos();
            }
            return Cls;
        }

        public void RegistrarDetalleMatricula(CapaEntidadesW.clsDetalleMatriculaEntidad cls)
        {
            SqlConnection Con = null;
            DataTable tabla = new DataTable();
            try
            {
                Con = clsConexion.GetInstance().ConexionBD();
                SqlCommand Cmd = new SqlCommand("sp_insertarDetalleMatricula", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@idmatricula", cls.IdMatricula);
                Cmd.Parameters.AddWithValue("@idclases", cls.IdClases);
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



    }
}
