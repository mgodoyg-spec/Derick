using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;

namespace Derick
{
    internal class csVenta
    {
        private csConectaSQL conexion = new csConectaSQL();

        public string GenerarCodigo()
        {
            DataTable dt = conexion.RetornaRegistros(@"
                SELECT ISNULL(MAX(TRY_CONVERT(INT, SUBSTRING(Codigo, 2, 20))), 0)
                FROM Ventas
                WHERE Codigo LIKE 'V%'");

            int maxCodigo = Convert.ToInt32(dt.Rows[0][0]);
            int nuevoCodigo = maxCodigo + 1;
            return "V" + nuevoCodigo.ToString("D3");
        }

        public bool Registrar(
            string codigo, DateTime fecha, TimeSpan hora,
            int idEmpleado, int idSucursal, int idCliente,
            decimal subtotal, decimal descuento, decimal iva, decimal total,
            string metodoPago, DataGridView dgvProductos)
        {
            string sqlVenta = @"
                INSERT INTO Ventas (Codigo, Fecha, Hora, IdEmpleado, IdSucursal, IdCliente,
                                     Subtotal, Descuento, IVA, Total, MetodoPago, Estado)
                VALUES (@Codigo, @Fecha, @Hora, @IdEmpleado, @IdSucursal, @IdCliente,
                        @Subtotal, @Descuento, @IVA, @Total, @MetodoPago, 1)";

            int idVenta = conexion.EjecutarConRetorno(sqlVenta,
                new SqlParameter("@Codigo", codigo),
                new SqlParameter("@Fecha", fecha.Date),
                new SqlParameter("@Hora", hora),
                new SqlParameter("@IdEmpleado", idEmpleado),
                new SqlParameter("@IdSucursal", idSucursal),
                new SqlParameter("@IdCliente", idCliente),
                new SqlParameter("@Subtotal", subtotal),
                new SqlParameter("@Descuento", descuento),
                new SqlParameter("@IVA", iva),
                new SqlParameter("@Total", total),
                new SqlParameter("@MetodoPago", metodoPago)
            );

            if (idVenta <= 0) return false;

            foreach (DataGridViewRow fila in dgvProductos.Rows)
            {
                int idInventario = Convert.ToInt32(fila.Tag);
                int cantidad = Convert.ToInt32(fila.Cells["colCantidad"].Value);
                decimal precio = Convert.ToDecimal(fila.Cells["colPrecio"].Value);
                decimal subtotalLinea = Convert.ToDecimal(fila.Cells["colSubtotal"].Value);

                string sqlDetalle = @"
                    INSERT INTO DetalleVenta (IdVenta, IdProducto, Cantidad, PrecioUnitario, Descuento, Subtotal)
                    VALUES (@IdVenta, (SELECT IdProducto FROM Inventario WHERE IdInventario = @IdInventario), @Cantidad, @Precio, 0, @Subtotal)";

                conexion.ejecutarComando(sqlDetalle,
                    new SqlParameter("@IdVenta", idVenta),
                    new SqlParameter("@IdInventario", idInventario),
                    new SqlParameter("@Cantidad", cantidad),
                    new SqlParameter("@Precio", precio),
                    new SqlParameter("@Subtotal", subtotalLinea)
                );

                string sqlStock = @"
                    UPDATE Inventario SET Stock = Stock - @Cantidad
                    WHERE IdInventario = @IdInventario";

                conexion.ejecutarComando(sqlStock,
                    new SqlParameter("@Cantidad", cantidad),
                    new SqlParameter("@IdInventario", idInventario)
                );
            }

            return true;
        }
    }
}
