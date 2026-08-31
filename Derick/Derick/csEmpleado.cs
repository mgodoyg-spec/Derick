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
        public int IdSucursal { get; set; }
        public string NombreSucursal { get; set; }
        public string ContactoEmergencia { get; set; }
        public string TelefonoEmergencia { get; set; }
        public byte[] Foto { get; set; }

        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public string Rol { get; set; }

        private csConectaSQL conexion = new csConectaSQL();

        public DataTable Listar(string buscar = "",string departamento = "",string estado = "",string sucursal = "")
        {
            buscar = buscar.Replace("'", "''");
            departamento = departamento.Replace("'", "''");
            sucursal = sucursal.Replace("'", "''");

            string query = @"
        SELECT
            Codigo,
            Nombres + ' ' + Apellidos AS Empleado,
            Cargo,
            Departamento,
            Telefono,
            Correo,
            CASE
                WHEN Estado = 1 THEN 'Activo'
                ELSE 'Inactivo'
            END AS Estado,
            Foto,
            IdSucursal
        FROM Empleados
        WHERE 1 = 1";

            if (buscar != "")
            {
                query += @"
        AND (
            Codigo LIKE '%" + buscar + @"%'
            OR Nombres LIKE '%" + buscar + @"%'
            OR Apellidos LIKE '%" + buscar + @"%'
            OR Cargo LIKE '%" + buscar + @"%'
            OR Departamento LIKE '%" + buscar + @"%'
            OR Telefono LIKE '%" + buscar + @"%'
            OR Correo LIKE '%" + buscar + @"%'
        )";
            }

            if (departamento != "")
            {
                query += " AND Departamento = '" + departamento + "'";
            }

            if (estado == "Activo")
            {
                query += " AND Estado = 1";
            }

            if (estado == "Inactivo")
            {
                query += " AND Estado = 0";
            }

            if (sucursal != "")
            {
                query += @"
            AND IdSucursal IN
            (
                SELECT IdSucursal
                FROM Sucursales
                WHERE NombreSucursal = '" + sucursal + @"'
            )";
            }

            query += " ORDER BY IdEmpleado";

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
                "SELECT IdSucursal, NombreSucursal FROM Sucursales " +
                "WHERE NombreSucursal IS NOT NULL AND NombreSucursal<>'' ORDER BY NombreSucursal");
        }
        public string GenerarCodigo()
        {
            DataTable dt = conexion.RetornaRegistros(@"
        SELECT ISNULL(
            MAX(
                TRY_CONVERT(
                    INT,
                    SUBSTRING(Codigo, 2, 20)
                )
            ), 0
        )
        FROM Empleados
        WHERE Codigo LIKE 'E%'");

            // 1. Extraemos el número que nos devolvió SQL
            int maxCodigo = Convert.ToInt32(dt.Rows[0][0]);

            // 2. Le sumamos 1 para el nuevo empleado
            int nuevoCodigo = maxCodigo + 1;

            return "E" + nuevoCodigo.ToString("D3");
        }

        public csEmpleado BuscarPorCodigo(string codigo)
        {
            string codigoEsc = codigo.Replace("'", "''");

            string query = @"
SELECT
    e.IdEmpleado,
    e.Codigo,
    e.Nombres,
    e.Apellidos,
    e.Cedula,
    e.IdSucursal,
    s.NombreSucursal,  -- Aquí pedimos el texto
    e.FechaNacimiento,
    e.Genero,
    e.Telefono,
    e.Correo,
    e.Direccion,
    e.Cargo,
    e.Departamento,
    e.FechaIngreso,
    e.Salario,
    e.TipoContrato,
    e.Estado,
    e.ContactoEmergencia,
    e.TelefonoEmergencia,
    e.Foto,
    u.Usuario,
    u.Contrasena,
    r.NombreRol AS Rol

FROM Empleados e
LEFT JOIN Usuario u ON u.IdEmpleado = e.IdEmpleado
LEFT JOIN Rol r ON r.IdRol = u.IdRol
LEFT JOIN Sucursales s ON s.IdSucursal = e.IdSucursal -- ¡ESTA ES LA LÍNEA QUE FALTABA!

WHERE e.Codigo = '" + codigoEsc + "'";

            DataTable dt = conexion.RetornaRegistros(query);

            // Si no encontró al empleado
            if (dt == null || dt.Rows.Count == 0)
            {
                return null;
            }

            // Tomamos la primera fila encontrada
            DataRow fila = dt.Rows[0];

            // Creamos un empleado
            csEmpleado empleado = new csEmpleado();

            empleado.IdEmpleado =
                Convert.ToInt32(fila["IdEmpleado"]);

            empleado.Codigo =
                fila["Codigo"].ToString();

            empleado.Nombres =
                fila["Nombres"].ToString();

            empleado.Apellidos =
                fila["Apellidos"].ToString();

            empleado.Cedula =
                fila["Cedula"].ToString();

            empleado.IdSucursal =
    Convert.ToInt32(fila["IdSucursal"]);
            empleado.NombreSucursal = fila["NombreSucursal"].ToString();

            empleado.Genero =
                fila["Genero"].ToString();

            empleado.Telefono =
                fila["Telefono"].ToString();

            empleado.Correo =
                fila["Correo"].ToString();

            empleado.Direccion =
                fila["Direccion"].ToString();

            empleado.Cargo =
                fila["Cargo"].ToString();

            empleado.Departamento =
                fila["Departamento"].ToString();

            empleado.TipoContrato =
                fila["TipoContrato"].ToString();

            empleado.ContactoEmergencia =
                fila["ContactoEmergencia"].ToString();

            empleado.TelefonoEmergencia =
                fila["TelefonoEmergencia"].ToString();

            // Fecha de nacimiento
            if (fila["FechaNacimiento"] != DBNull.Value)
            {
                empleado.FechaNacimiento =
                    Convert.ToDateTime(fila["FechaNacimiento"]);
            }

            // Fecha de ingreso
            if (fila["FechaIngreso"] != DBNull.Value)
            {
                empleado.FechaIngreso =
                    Convert.ToDateTime(fila["FechaIngreso"]);
            }

            // Salario
            if (fila["Salario"] != DBNull.Value)
            {
                empleado.Salario =
                    Convert.ToDecimal(fila["Salario"]);
            }

            // Estado
            if (fila["Estado"] != DBNull.Value)
            {
                empleado.Estado =
                    Convert.ToBoolean(fila["Estado"]);
            }

            // Foto
            if (fila["Foto"] != DBNull.Value)
            {
                empleado.Foto =
                    (byte[])fila["Foto"];
            }

            // Usuario
            if (fila["Usuario"] != DBNull.Value)
            {
                empleado.Usuario =
                    fila["Usuario"].ToString();
            }

            // Contraseña
            if (fila["Contrasena"] != DBNull.Value)
            {
                empleado.Contrasena =
                    fila["Contrasena"].ToString();
            }

            // Rol
            if (fila["Rol"] != DBNull.Value)
            {
                empleado.Rol =
                    fila["Rol"].ToString();
            }

            return empleado;
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
        (Codigo, Nombres, Apellidos, Cedula, FechaNacimiento, Genero, 
         Telefono, Correo, Direccion, Cargo, Departamento, FechaIngreso, 
         Salario, TipoContrato, Estado, ContactoEmergencia, 
         TelefonoEmergencia, Foto, IdSucursal) 
        VALUES 
        (@Codigo, @Nombres, @Apellidos, @Cedula, @FechaNacimiento, @Genero, 
         @Telefono, @Correo, @Direccion, @Cargo, @Departamento, @FechaIngreso, 
         @Salario, @TipoContrato, @Estado, @ContactoEmergencia, 
         @TelefonoEmergencia, @Foto, @IdSucursal)";

            return conexion.ejecutarComando(sql,
                new SqlParameter("@Codigo", Codigo),
                new SqlParameter("@Nombres", Nombres),
                new SqlParameter("@Apellidos", Apellidos),
                new SqlParameter("@Cedula", Cedula),
                new SqlParameter("@FechaNacimiento", FechaNacimiento),
                new SqlParameter("@Genero", Genero),
                new SqlParameter("@Telefono", Telefono),
                new SqlParameter("@Correo", Correo),
                new SqlParameter("@Direccion", Direccion),
                new SqlParameter("@Cargo", Cargo),
                new SqlParameter("@Departamento", Departamento),
                new SqlParameter("@FechaIngreso", FechaIngreso),
                new SqlParameter("@Salario", Salario),
                new SqlParameter("@TipoContrato", TipoContrato),
                new SqlParameter("@Estado", Estado ? 1 : 0),
                new SqlParameter("@ContactoEmergencia", ContactoEmergencia),
                new SqlParameter("@TelefonoEmergencia", TelefonoEmergencia),
                new SqlParameter("@Foto", Foto == null ? (object)DBNull.Value : Foto),
                new SqlParameter("@IdSucursal", IdSucursal)
            );
        }

        public bool Editar()
        {
            string sql = @"
        UPDATE Empleados SET 
        Nombres=@Nombres, Apellidos=@Apellidos, Cedula=@Cedula, 
        FechaNacimiento=@FechaNacimiento, Genero=@Genero, 
        Telefono=@Telefono, Correo=@Correo, Direccion=@Direccion, 
        Cargo=@Cargo, Departamento=@Departamento, FechaIngreso=@FechaIngreso, 
        Salario=@Salario, TipoContrato=@TipoContrato, Estado=@Estado, 
        ContactoEmergencia=@ContactoEmergencia, 
        TelefonoEmergencia=@TelefonoEmergencia, Foto=@Foto, 
        IdSucursal=@IdSucursal 
        WHERE Codigo=@Codigo";

            return conexion.ejecutarComando(sql,
                new SqlParameter("@Codigo", Codigo),
                new SqlParameter("@Nombres", Nombres),
                new SqlParameter("@Apellidos", Apellidos),
                new SqlParameter("@Cedula", Cedula),
                new SqlParameter("@FechaNacimiento", FechaNacimiento),
                new SqlParameter("@Genero", Genero),
                new SqlParameter("@Telefono", Telefono),
                new SqlParameter("@Correo", Correo),
                new SqlParameter("@Direccion", Direccion),
                new SqlParameter("@Cargo", Cargo),
                new SqlParameter("@Departamento", Departamento),
                new SqlParameter("@FechaIngreso", FechaIngreso),
                new SqlParameter("@Salario", Salario),
                new SqlParameter("@TipoContrato", TipoContrato),
                new SqlParameter("@Estado", Estado ? 1 : 0),
                new SqlParameter("@ContactoEmergencia", ContactoEmergencia),
                new SqlParameter("@TelefonoEmergencia", TelefonoEmergencia),
                new SqlParameter("@Foto", Foto == null ? (object)DBNull.Value : Foto),
                new SqlParameter("@IdSucursal", IdSucursal) 
            );
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
        public bool CodigoExiste()
        {
            string query =
                "SELECT COUNT(*) FROM Empleados WHERE Codigo='" + Codigo + "'";

            DataTable dt = conexion.RetornaRegistros(query);

            int cantidad = Convert.ToInt32(dt.Rows[0][0]);

            if (cantidad > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}