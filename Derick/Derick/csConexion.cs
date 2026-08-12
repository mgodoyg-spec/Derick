using Microsoft.Data.SqlClient;

public class csConexion
{
    private static string cadena = @"Server=MICHELLE\SQLEXPRESS;Database=Derick;User Id=Gerente;Password=ger123;TrustServerCertificate=True;";

    public static SqlConnection ObtenerConexion()
    {
        return new SqlConnection(cadena);
    }
}