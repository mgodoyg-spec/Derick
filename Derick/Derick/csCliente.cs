using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Derick
{
    internal class csCliente
    {
        public int IdCliente { get; set; }
        public string Codigo { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public bool Estado { get; set; }

        private csConectaSQL conexion = new csConectaSQL();

        public DataTable Listar(string buscar = "")
        {
            buscar = buscar.Replace("'", "''");

            string query = @"
                SELECT IdCliente, Codigo,
                       Nombres + ' ' + Apellidos AS NombreCompleto,
                       Telefono
                FROM Clientes
                WHERE Estado = 1";

            if (buscar != "")
            {
                query += @" AND (
                    Nombres LIKE '%" + buscar + @"%'
                    OR Apellidos LIKE '%" + buscar + @"%'
                    OR Telefono LIKE '%" + buscar + @"%'
                    OR Codigo LIKE '%" + buscar + @"%'
                )";
            }

            query += " ORDER BY Nombres";

            return conexion.RetornaRegistros(query);
        }
        public bool CodigoExiste(string codigo)
        {
            string query = "SELECT COUNT(*) FROM Clientes WHERE Codigo = '" + codigo + "'";
            DataTable dt = conexion.RetornaRegistros(query);
            return dt != null && Convert.ToInt32(dt.Rows[0][0]) > 0;
        }

        public string GenerarCodigo()
        {
            DataTable dt = conexion.RetornaRegistros(@"
        SELECT ISNULL(
            MAX(TRY_CONVERT(INT, SUBSTRING(Codigo, 4, 20))), 0
        )
        FROM Clientes
        WHERE Codigo LIKE 'CLI%'");

            int maxCodigo = Convert.ToInt32(dt.Rows[0][0]);
            int nuevoCodigo = maxCodigo + 1;
            return "CLI" + nuevoCodigo.ToString("D3");
        }

        public bool Registrar()
        {
            string sql = @"
        INSERT INTO Clientes (Codigo, Nombres, Apellidos, Cedula, Telefono, Correo, Direccion, Estado)
        VALUES (@Codigo, @Nombres, @Apellidos, @Cedula, @Telefono, @Correo, @Direccion, 1)";

            return conexion.ejecutarComando(sql,
                new SqlParameter("@Codigo", Codigo),
                new SqlParameter("@Nombres", Nombres),
                new SqlParameter("@Apellidos", Apellidos),
                new SqlParameter("@Cedula", Cedula),
                new SqlParameter("@Telefono", Telefono),
                new SqlParameter("@Correo", string.IsNullOrEmpty(Correo) ? (object)DBNull.Value : Correo),
                new SqlParameter("@Direccion", string.IsNullOrEmpty(Direccion) ? (object)DBNull.Value : Direccion)
            );
        }

        public bool CedulaExiste(string cedula)
        {
            string cedEsc = cedula.Replace("'", "''");
            DataTable dt = conexion.RetornaRegistros(
                "SELECT COUNT(*) FROM Clientes WHERE Cedula = '" + cedEsc + "'");
            return dt != null && Convert.ToInt32(dt.Rows[0][0]) > 0;
        }
    }
}
