using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatosW
{
    public class clsCicloDatos
    {

        private static clsCicloDatos Cls = null;
        private clsCicloDatos() { }

        public static clsCicloDatos GetInstance()
        {

            if (Cls == null)
            {
                Cls = new clsCicloDatos();
            }
            return Cls;
        }





        public DataTable ListarCiclo()
        {
            SqlConnection Con = null;
            DataTable tabla = new DataTable();
            SqlDataReader dr = null;
            try
            {
                Con = clsConexion.GetInstance().ConexionBD();
                SqlCommand Cmd = new SqlCommand("sp_listarCiclo", Con);
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





    }
}
