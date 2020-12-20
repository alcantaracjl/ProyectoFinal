using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatosW
{
    public class clsConexion    {

        private static clsConexion Con = null;
        private clsConexion(){ }    

        public static clsConexion GetInstance()  {

            if (Con==null)            {
                Con = new clsConexion();
            }
            return Con;
        }

        public SqlConnection ConexionBD()
        {
             SqlConnection Con = new SqlConnection(ConfigurationManager.ConnectionStrings["cnConexion"].ToString());
            return Con;
        }
    }
}
