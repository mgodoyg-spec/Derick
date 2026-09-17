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
        public decimal? Latitud { get; set; }
        public decimal? Longitud { get; set; }

        private csConectaSQL conexion = new csConectaSQL();


        public DataTable Listar(string buscar = "", string ciudad = "", string estado = "")
        {
            try
            {
                buscar = buscar.Trim().Replace("'", "''");
                ciudad = ciudad.Trim().Replace("'", "''");
                estado = estado.Trim().Replace("'", "''");

                string sql =
                    "Select Codigo, NombreSucursal, Ciudad, FechaRegistro, " +
                    "Direccion, Telefono, EncargadoSucursal, Estado " +
                    "from Sucursales " +
                    "where (Codigo like '%" + buscar + "%' " +
                    "or NombreSucursal like '%" + buscar + "%') " +
                    "and ('" + ciudad + "' = '' or Ciudad = '" + ciudad + "') " +
                    "and ( " +
                    "('" + estado + "' = '' and " +
                    "(Estado = 'Activa' or Estado = 'Remodelación')) " +
                    "or " +
                    "('" + estado + "' <> '' and Estado = '" + estado + "') " +
                    ")";

                DataTable datos = conexion.RetornaRegistros(sql);

                return datos;
            }
            catch (Exception)
            {
                return null;
            }
        }

        // Buscar una sucursal por su código
        public csSucursal BuscarPorCodigo(string codigo)
        {
            try
            {
                codigo = codigo.Replace("'", "''");

                string sql ="select Codigo, FechaRegistro, NombreSucursal, Ciudad, " +
                             "Direccion, Telefono, Correo, EncargadoSucursal, Estado, Imagen, Latitud, Longitud " +
                             "from Sucursales " +
                             "where Codigo = '" + codigo + "'";

                DataTable datos = conexion.RetornaRegistros(sql);

                if (datos == null || datos.Rows.Count == 0)
                {
                    return null;
                }

                DataRow fila = datos.Rows[0];

                csSucursal sucursal = new csSucursal();

                sucursal.Codigo = fila["Codigo"].ToString();
                sucursal.NombreSucursal = fila["NombreSucursal"].ToString();
                sucursal.Ciudad = fila["Ciudad"].ToString();
                sucursal.Direccion = fila["Direccion"].ToString();
                sucursal.Telefono = fila["Telefono"].ToString();
                sucursal.Correo = fila["Correo"].ToString();
                sucursal.EncargadoSucursal = fila["EncargadoSucursal"].ToString();
                sucursal.Estado = fila["Estado"].ToString();

                if (fila["FechaRegistro"] != DBNull.Value)
                {
                    sucursal.FechaRegistro =
                        Convert.ToDateTime(fila["FechaRegistro"]);
                }

                if (fila["Imagen"] != DBNull.Value)
                {
                    sucursal.Imagen = (byte[])fila["Imagen"];
                }
                else
                {
                    sucursal.Imagen = null;
                }
                if (fila["Latitud"] != DBNull.Value)
                    sucursal.Latitud = Convert.ToDecimal(fila["Latitud"]);

                if (fila["Longitud"] != DBNull.Value)
                    sucursal.Longitud = Convert.ToDecimal(fila["Longitud"]);

                return sucursal;
            }
            catch (Exception)
            {
                return null;
            }
        }


        // Editar sucursal
        public bool Editar()
        {
            try
            {
                string sql =
                        "Update Sucursales set " +
                        "NombreSucursal = @NombreSucursal, " +
                        "Ciudad = @Ciudad, " +
                        "Direccion = @Direccion, " +
                        "Telefono = @Telefono, " +
                        "Correo = @Correo, " +
                        "EncargadoSucursal = @EncargadoSucursal, " +
                        "Estado = @Estado, " +
                        "Imagen = @Imagen, " +
                        "Latitud = @Latitud, " +
                        "Longitud = @Longitud " +
                        "where Codigo = @Codigo";

                SqlParameter pNombre =new SqlParameter("@NombreSucursal", NombreSucursal);
                SqlParameter pCiudad =new SqlParameter("@Ciudad", Ciudad);
                SqlParameter pDireccion =new SqlParameter("@Direccion", Direccion);
                SqlParameter pTelefono =new SqlParameter("@Telefono", Telefono);
                SqlParameter pCorreo = new SqlParameter("@Correo", Correo);
                SqlParameter pEncargado = new SqlParameter("@EncargadoSucursal", EncargadoSucursal);
                SqlParameter pEstado = new SqlParameter("@Estado", Estado);
                SqlParameter pCodigo =new SqlParameter("@Codigo", Codigo);
                SqlParameter pImagen =new SqlParameter("@Imagen", SqlDbType.VarBinary, -1);
                SqlParameter pLatitud = new SqlParameter("@Latitud", Latitud ?? (object)DBNull.Value);
                SqlParameter pLongitud = new SqlParameter("@Longitud", Longitud ?? (object)DBNull.Value);

                if (Imagen != null && Imagen.Length > 0)
                {
                    pImagen.Value = Imagen;
                }
                else
                {
                    pImagen.Value = DBNull.Value;
                }

                bool resultado = conexion.ejecutarComando(
                    sql,
                    pNombre,
                    pCiudad,
                    pDireccion,
                    pTelefono,
                    pCorreo,
                    pEncargado,
                    pEstado,
                    pImagen,
                    pLatitud,
                    pLongitud,
                    pCodigo
                );

                return resultado;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //desactivar sucursal
        public bool CambiarEstado(string nuevoEstado)
        {
            try
            {
                string sql =
                    "Update Sucursales " +
                    "set Estado = @Estado " +
                    "where Codigo = @Codigo";

                SqlParameter pEstado =new SqlParameter("@Estado", nuevoEstado);
                SqlParameter pCodigo = new SqlParameter("@Codigo", Codigo);

                bool resultado =conexion.ejecutarComando(sql,pEstado, pCodigo);
                return resultado;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //comprobar si sucursal tiene otros datos enlazados
        public bool TieneDatosRelacionados()
        {
            try
            {
                string sql =
                    "select IdSucursal from Sucursales " +
                    "where Codigo = '" + Codigo + "'";

                DataTable datos = conexion.RetornaRegistros(sql);

                if (datos == null || datos.Rows.Count == 0)
                    return false;

                int idSucursal =
                    Convert.ToInt32(datos.Rows[0]["IdSucursal"]);

                string sqlEmpleados =
                    "select count(*) from Empleados " +
                    "where IdSucursal = " + idSucursal;

                DataTable empleados =
                    conexion.RetornaRegistros(sqlEmpleados);

                if (empleados != null &&
                    Convert.ToInt32(empleados.Rows[0][0]) > 0)
                    return true;

                string sqlInventario =
                    "select count(*) from Inventario " +
                    "where IdSucursal = " + idSucursal;

                DataTable inventario =
                    conexion.RetornaRegistros(sqlInventario);

                if (inventario != null &&
                    Convert.ToInt32(inventario.Rows[0][0]) > 0)
                    return true;

                string sqlVentas =
                    "select count(*) from Ventas " +
                    "where IdSucursal = " + idSucursal;

                DataTable ventas =
                    conexion.RetornaRegistros(sqlVentas);

                if (ventas != null &&
                    Convert.ToInt32(ventas.Rows[0][0]) > 0)
                    return true;

                return false;
            }
            catch (Exception)
            {
                return true;
            }
        }
        public bool Eliminar()
        {
            try
            {
                if (TieneDatosRelacionados())
                    return false;

                string sql =
                    "delete from Sucursales " +
                    "where Codigo = '" + Codigo + "'";

                bool resultado = conexion.ejecutarComando(sql);

                return resultado;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
