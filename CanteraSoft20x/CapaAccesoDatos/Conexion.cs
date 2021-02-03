using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class Conexion
    {
        public static string Conectar()
        {
            return ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
        }
    }
}
