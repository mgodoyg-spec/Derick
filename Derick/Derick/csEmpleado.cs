using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace Derick
{
    public class csEmpleado
    {
        public int IdEmpleado { get; set; }
        public string Codigo { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Cedula { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Genero { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public string Cargo { get; set; }
        public string Departamento { get; set; }
        public DateTime FechaIngreso { get; set; }
        public decimal Salario { get; set; }
        public string TipoContrato { get; set; }
        public bool Estado { get; set; }
        public string ContactoEmergencia { get; set; }
        public string TelefonoEmergencia { get; set; }
        public byte[] Foto { get; set; }

        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public string Rol { get; set; }

        private csConectaSQL conexion = new csConectaSQL();

        public DataTable Listar(string buscar = "", string departamento = "", string estado = "", string sucursal = "")
        {
            string b = (buscar ?? "").Trim().Replace("'", "''");
            string d = (departamento ?? "").Replace("'", "''");
            string e = (estado ?? "").Replace("'", "''");
            string s = (sucursal ?? "").Replace("'", "''");
            int estadoBit = estado == "Activo" ? 1 : 0;

            string query = @"
                SELECT Codigo, ISNULL(Nombres,'') + ' ' + ISNULL(Apellidos,'') AS Empleado,
                       Cargo, Departamento, Telefono, Correo,
                       CASE WHEN Estado=1 THEN 'Activo' ELSE 'Inactivo' END AS Estado, Foto
                FROM Empleados
                WHERE (ISNULL(Codigo,'') LIKE '%" + b + @"%' OR ISNULL(Nombres,'') LIKE '%" + b + @"%'
                    OR ISNULL(Apellidos,'') LIKE '%" + b + @"%'
                    OR ISNULL(Nombres,'') + ' ' + ISNULL(Apellidos,'') LIKE '%" + b + @"%'
                    OR ISNULL(Cargo,'') LIKE '%" + b + @"%' OR ISNULL(Departamento,'') LIKE '%" + b + @"%'
                    OR ISNULL(Telefono,'') LIKE '%" + b + @"%' OR ISNULL(Correo,'') LIKE '%" + b + @"%')
                AND ('" + d + @"'='' OR Departamento='" + d + @"')
                AND ('" + e + @"'='' OR Estado=" + estadoBit + @")
                AND ('" + s + @"'='' OR IdSucursal IN
                    (SELECT IdSucursal FROM Sucursales WHERE NombreSucursal='" + s + @"'))
                ORDER BY IdEmpleado";

            return conexion.RetornaRegistros(query);
        }

        public DataTable ObtenerDepartamentos()
        {
            return conexion.RetornaRegistros(
                "SELECT DISTINCT Departamento FROM Empleados " +
                "WHERE Departamento IS NOT NULL AND Departamento<>'' ORDER BY Departamento");
        }

        public DataTable ObtenerSucursales()
        {
            return conexion.RetornaRegistros(
                "SELECT DISTINCT NombreSucursal FROM Sucursales " +
                "WHERE NombreSucursal IS NOT NULL AND NombreSucursal<>'' ORDER BY NombreSucursal");
        }

        public string GenerarCodigo()
        {
            DataTable dt = conexion.RetornaRegistros(@"
        SELECT ISNULL(
            MAX(
                TRY_CONVERT(
                    INT,
                    SUBSTRING(Codigo, 3, 20)
                )
            ), 0
        )
        FROM Empleados
        WHERE Codigo LIKE 'SC%'");

            int ultimo = Convert.ToInt32(dt.Rows[0][0]);

            return "SC" + (ultimo + 1).ToString("D3");
        }

        public csEmpleado BuscarPorCodigo(string codigo)
        {
            string c = (codigo ?? "").Replace("'", "''");

            DataTable dt = conexion.RetornaRegistros(@"
                SELECT e.IdEmpleado,e.Codigo,e.Nombres,e.Apellidos,e.Cedula,e.FechaNacimiento,
                       e.Genero,e.Telefono,e.Correo,e.Direccion,e.Cargo,e.Departamento,e.FechaIngreso,
                       e.Salario,e.TipoContrato,e.Estado,e.ContactoEmergencia,e.TelefonoEmergencia,e.Foto,
                       u.Usuario,u.Contrasena,r.NombreRol AS Rol
                FROM Empleados e
                LEFT JOIN Usuario u ON u.IdEmpleado=e.IdEmpleado
                LEFT JOIN Rol r ON r.IdRol=u.IdRol
                WHERE e.Codigo='" + c + "'");

            if (dt == null || dt.Rows.Count == 0) return null;
            DataRow f = dt.Rows[0];

            return new csEmpleado
            {
                IdEmpleado = Convert.ToInt32(f["IdEmpleado"]),
                Codigo = f["Codigo"].ToString(),
                Nombres = f["Nombres"].ToString(),
                Apellidos = f["Apellidos"].ToString(),
                Cedula = f["Cedula"].ToString(),
                FechaNacimiento = f["FechaNacimiento"] == DBNull.Value ? DateTime.Today : Convert.ToDateTime(f["FechaNacimiento"]),
                Genero = f["Genero"].ToString(),
                Telefono = f["Telefono"].ToString(),
                Correo = f["Correo"].ToString(),
                Direccion = f["Direccion"].ToString(),
                Cargo = f["Cargo"].ToString(),
                Departamento = f["Departamento"].ToString(),
                FechaIngreso = f["FechaIngreso"] == DBNull.Value ? DateTime.Today : Convert.ToDateTime(f["FechaIngreso"]),
                Salario = f["Salario"] == DBNull.Value ? 0 : Convert.ToDecimal(f["Salario"]),
                TipoContrato = f["TipoContrato"].ToString(),
                Estado = f["Estado"] != DBNull.Value && Convert.ToBoolean(f["Estado"]),
                ContactoEmergencia = f["ContactoEmergencia"].ToString(),
                TelefonoEmergencia = f["TelefonoEmergencia"].ToString(),
                Foto = f["Foto"] == DBNull.Value ? null : (byte[])f["Foto"],
                Usuario = f["Usuario"] == DBNull.Value ? "" : f["Usuario"].ToString(),
                Contrasena = f["Contrasena"] == DBNull.Value ? "" : f["Contrasena"].ToString(),
                Rol = f["Rol"] == DBNull.Value ? "" : f["Rol"].ToString()
            };
        }

        public bool CedulaExiste()
        {
            string ced = (Cedula ?? "").Replace("'", "''");
            string cod = (Codigo ?? "").Replace("'", "''");
            DataTable dt = conexion.RetornaRegistros(
                "SELECT COUNT(*) FROM Empleados WHERE Cedula='" + ced + "' AND Codigo<>'" + cod + "'");
            return dt != null && Convert.ToInt32(dt.Rows[0][0]) > 0;
        }

        public bool UsuarioExiste()
        {
            if (string.IsNullOrWhiteSpace(Usuario)) return false;

            string u = Usuario.Replace("'", "''");
            string c = (Codigo ?? "").Replace("'", "''");
            DataTable dt = conexion.RetornaRegistros(@"
                SELECT COUNT(*) FROM Usuario u
                INNER JOIN Empleados e ON e.IdEmpleado=u.IdEmpleado
                WHERE u.Usuario='" + u + "' AND e.Codigo<>'" + c + "'");

            return dt != null && Convert.ToInt32(dt.Rows[0][0]) > 0;
        }

        public bool Registrar()
        {
            string sql = @"
                INSERT INTO Empleados
                (Codigo,Nombres,Apellidos,Cedula,FechaNacimiento,Genero,Telefono,Correo,Direccion,Cargo,
                 Departamento,FechaIngreso,Salario,TipoContrato,Estado,ContactoEmergencia,TelefonoEmergencia,Foto)
                VALUES
                (@Codigo,@Nombres,@Apellidos,@Cedula,@FechaNacimiento,@Genero,@Telefono,@Correo,@Direccion,@Cargo,
                 @Departamento,@FechaIngreso,@Salario,@TipoContrato,@Estado,@ContactoEmergencia,@TelefonoEmergencia,@Foto)";

            return conexion.ejecutarComando(sql, ParametrosEmpleado());
        }

        public bool Editar()
        {
            string sql = @"
                UPDATE Empleados SET Nombres=@Nombres,Apellidos=@Apellidos,Cedula=@Cedula,
                    FechaNacimiento=@FechaNacimiento,Genero=@Genero,Telefono=@Telefono,Correo=@Correo,
                    Direccion=@Direccion,Cargo=@Cargo,Departamento=@Departamento,FechaIngreso=@FechaIngreso,
                    Salario=@Salario,TipoContrato=@TipoContrato,Estado=@Estado,
                    ContactoEmergencia=@ContactoEmergencia,TelefonoEmergencia=@TelefonoEmergencia,Foto=@Foto
                WHERE Codigo=@Codigo";

            return conexion.ejecutarComando(sql, ParametrosEmpleado());
        }

        public bool GuardarAcceso()
        {
            string sql = @"
                DECLARE @IdEmpleado INT=(SELECT IdEmpleado FROM Empleados WHERE Codigo=@Codigo);
                DECLARE @IdRol INT=(SELECT IdRol FROM Rol WHERE NombreRol=@Rol);

                IF EXISTS(SELECT 1 FROM Usuario WHERE IdEmpleado=@IdEmpleado)
                    UPDATE Usuario SET IdRol=@IdRol,Usuario=@Usuario,Contrasena=@Clave,Estado=1
                    WHERE IdEmpleado=@IdEmpleado;
                ELSE
                    INSERT INTO Usuario(IdEmpleado,IdRol,Usuario,Contrasena,Estado)
                    VALUES(@IdEmpleado,@IdRol,@Usuario,@Clave,1);";

            return conexion.ejecutarComando(sql,
                new SqlParameter("@Codigo", Codigo),
                new SqlParameter("@Rol", Rol),
                new SqlParameter("@Usuario", Usuario),
                new SqlParameter("@Clave", Contrasena));
        }

        public bool Eliminar()
        {
            string codigoEsc = Codigo.Replace("'", "''");

            DataTable dt = conexion.RetornaRegistros(@"
        SELECT COUNT(*)
        FROM Ventas v
        INNER JOIN Empleados e
            ON e.IdEmpleado = v.IdEmpleado
        WHERE e.Codigo = '" + codigoEsc + "'");

            if (dt != null && Convert.ToInt32(dt.Rows[0][0]) > 0)
            {
                return false;
            }

            string sql = @"
        DECLARE @IdEmpleado INT =
        (
            SELECT IdEmpleado
            FROM Empleados
            WHERE Codigo = @Codigo
        );

        DELETE FROM Usuario
        WHERE IdEmpleado = @IdEmpleado;

        DELETE FROM Empleados
        WHERE IdEmpleado = @IdEmpleado;";

            return conexion.ejecutarComando(
                sql,
                new SqlParameter("@Codigo", Codigo)
            );
        }
        private SqlParameter[] ParametrosEmpleado()
        {
            SqlParameter salario = new SqlParameter("@Salario", SqlDbType.Decimal)
            { Precision = 12, Scale = 2, Value = Salario };

            SqlParameter foto = new SqlParameter("@Foto", SqlDbType.VarBinary, -1)
            { Value = Foto == null ? (object)DBNull.Value : Foto };

            return new SqlParameter[]
            {
                new SqlParameter("@Codigo",Codigo), new SqlParameter("@Nombres",Nombres),
                new SqlParameter("@Apellidos",Apellidos), new SqlParameter("@Cedula",Cedula),
                new SqlParameter("@FechaNacimiento",FechaNacimiento.Date), new SqlParameter("@Genero",Genero),
                new SqlParameter("@Telefono",Telefono), new SqlParameter("@Correo",Correo),
                new SqlParameter("@Direccion",Direccion), new SqlParameter("@Cargo",Cargo),
                new SqlParameter("@Departamento",Departamento), new SqlParameter("@FechaIngreso",FechaIngreso.Date),
                salario, new SqlParameter("@TipoContrato",TipoContrato), new SqlParameter("@Estado",Estado ? 1 : 0),
                new SqlParameter("@ContactoEmergencia",ContactoEmergencia),
                new SqlParameter("@TelefonoEmergencia",TelefonoEmergencia), foto
            };
        }
    }
}