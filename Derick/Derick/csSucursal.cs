using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Derick
{
    public class csSucursal
    {
        public string Codigo { get; set; }
        public DateTime FechaRegistro { get; set; }

        public string NombreSucursal { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }

        public string EncargadoSucursal { get; set; }
        public string Estado { get; set; }

        public byte[] Imagen { get; set; }

        private csConectaSQL conexion = new csConectaSQL();


        public DataTable Listar(
           string buscar = "",
           string ciudad = "",
           string estado = "")
        {
            string buscarEsc =
                buscar.Trim().Replace("'", "''");

            string ciudadEsc =
                ciudad.Replace("'", "''");

            string estadoEsc =
                estado.Replace("'", "''");

            string query = @"
                SELECT
                    Codigo,
                    NombreSucursal,
                    Ciudad,
                    FechaRegistro,
                    Direccion,
                    Telefono,
                    EncargadoSucursal,
                    Estado
                FROM Sucursales
                WHERE
                    (Codigo LIKE '%" + buscarEsc + @"%'
                    OR NombreSucursal LIKE '%" + buscarEsc + @"%')

                    AND ('" + ciudadEsc + @"' = ''
                    OR Ciudad = '" + ciudadEsc + @"')

                    AND ('" + estadoEsc + @"' = ''
                    OR Estado = '" + estadoEsc + @"')
                ";

            return conexion.RetornaRegistros(query);
        }

        // Buscar una sucursal por su código
        public csSucursal BuscarPorCodigo(string codigo)
        {
            csConectaSQL oConexion = new csConectaSQL();

            // Evita problemas si el código contiene comillas
            string codigoEsc = codigo.Replace("'", "''");

            string query = @"
        SELECT
            Codigo,
            FechaRegistro,
            NombreSucursal,
            Ciudad,
            Direccion,
            Telefono,
            Correo,
            EncargadoSucursal,
            Estado,
            Imagen
        FROM Sucursales
        WHERE Codigo = '" + codigoEsc + "'";

            DataTable dt = oConexion.RetornaRegistros(query);

            // Si no encontró ninguna sucursal
            if (dt == null || dt.Rows.Count == 0)
            {
                return null;
            }

            DataRow fila = dt.Rows[0];

            csSucursal sucursal = new csSucursal();

            // Código
            sucursal.Codigo =
                fila["Codigo"].ToString();

            // Fecha
            if (fila["FechaRegistro"] != DBNull.Value)
            {
                sucursal.FechaRegistro =
                    Convert.ToDateTime(fila["FechaRegistro"]);
            }

            // Nombre
            sucursal.NombreSucursal =
                fila["NombreSucursal"].ToString();

            // Ciudad
            sucursal.Ciudad =
                fila["Ciudad"].ToString();

            // Dirección
            sucursal.Direccion =
                fila["Direccion"].ToString();

            // Teléfono
            sucursal.Telefono =
                fila["Telefono"].ToString();

            // Correo
            sucursal.Correo =
                fila["Correo"].ToString();

            // Encargado
            sucursal.EncargadoSucursal =
                fila["EncargadoSucursal"].ToString();

            // Estado
            sucursal.Estado =
                fila["Estado"].ToString();

            // Imagen VARBINARY(MAX)
            if (fila["Imagen"] != DBNull.Value)
            {
                sucursal.Imagen =
                    (byte[])fila["Imagen"];
            }
            else
            {
                sucursal.Imagen = null;
            }

            return sucursal;
        }


        // Editar sucursal
        public bool Editar()
        {
            csConectaSQL oConexion = new csConectaSQL();

            string sql = @"
        UPDATE Sucursales
        SET
            NombreSucursal = @NombreSucursal,
            Ciudad = @Ciudad,
            Direccion = @Direccion,
            Telefono = @Telefono,
            Correo = @Correo,
            EncargadoSucursal = @EncargadoSucursal,
            Estado = @Estado,
            Imagen = @Imagen
        WHERE Codigo = @Codigo";

            SqlParameter parametroImagen =
                new SqlParameter("@Imagen", SqlDbType.VarBinary, -1);

            if (Imagen != null && Imagen.Length > 0)
            {
                parametroImagen.Value = Imagen;
            }
            else
            {
                parametroImagen.Value = DBNull.Value;
            }

            return oConexion.ejecutarComando(
                sql,

                new SqlParameter(
                    "@NombreSucursal",
                    NombreSucursal),

                new SqlParameter(
                    "@Ciudad",
                    Ciudad),

                new SqlParameter(
                    "@Direccion",
                    Direccion),

                new SqlParameter(
                    "@Telefono",
                    Telefono),

                new SqlParameter(
                    "@Correo",
                    Correo),

                new SqlParameter(
                    "@EncargadoSucursal",
                    EncargadoSucursal),

                new SqlParameter(
                    "@Estado",
                    Estado),

                parametroImagen,

                new SqlParameter(
                    "@Codigo",
                    Codigo)
            );
        }
    }
}
