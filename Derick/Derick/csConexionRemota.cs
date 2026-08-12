using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Derick
{
    internal class csConexionRemota
    {
        public static SqlConnection ObtenerConexion()
        {
            string cadena =
                "Server=100.123.50.34,1433;" +
                "Database=Derick;" +
                "User Id=Michelle;" +
                "Password=Michelle@27;" +
                "TrustServerCertificate=True;";

            return new SqlConnection(cadena);
        }
    }
}
