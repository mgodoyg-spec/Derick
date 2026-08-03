using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Derick
{
    public partial class FormBusc_Product : Form
    {
        private BindingList<Producto> listaproductos = new BindingList<Producto>();
        public FormBusc_Product()
        {
            InitializeComponent();
            C_list();
            C_product();
        }

        private void gcb_busc1_SelectedIndexChanged(object sender, EventArgs e)
        {
            gcb_busc1.Items.Add("Todas las categorías");
            gcb_busc1.SelectedIndex = 0;
        }

        private void gcb_busc2_SelectedIndexChanged(object sender, EventArgs e)
        {
            gcb_busc2.Items.Add("Estado");
            gcb_busc2.SelectedIndex = 0;
        }
        private void C_list()
        {
            dtg_busc1.AutoGenerateColumns = false;
            dtg_busc1.Columns.Clear();
            dtg_busc1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dtg_busc1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colId",
                HeaderText = "ID",
                DataPropertyName = "Id",
                Width = 40
            });

            dtg_busc1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colProducto",
                HeaderText = "Producto",
                DataPropertyName = "Nombre",
                Width = 200
            });

            dtg_busc1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCategoria",
                HeaderText = "Categoría",
                DataPropertyName = "Categoria",
                Width = 100
            });

            dtg_busc1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colPrecio",
                HeaderText = "Precio",
                DataPropertyName = "Precio",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" } // $45.00
            });

            dtg_busc1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colStock",
                HeaderText = "Stock",
                DataPropertyName = "Stock",
                Width = 60
            });

            dtg_busc1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colEstado",
                HeaderText = "Estado",
                DataPropertyName = "Estado",
                Width = 80
            });

            dtg_busc1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCodigo",
                HeaderText = "Código",
                DataPropertyName = "Codigo",
                Width = 100
            });

            dtg_busc1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colColor",
                HeaderText = "Color",
                DataPropertyName = "Color",
                Width = 100
            });

            dtg_busc1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colTalla",
                HeaderText = "Talla",
                DataPropertyName = "Talla",
                Width = 80
            });

            dtg_busc1.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "colVer",
                HeaderText = "",
                Text = "👁",
                UseColumnTextForButtonValue = true,
                Width = 40
            });

            dtg_busc1.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "colEditar",
                HeaderText = "",
                Text = "✏",
                UseColumnTextForButtonValue = true,
                Width = 40
            });

            dtg_busc1.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "colEliminar",
                HeaderText = "",
                Text = "🗑",
                UseColumnTextForButtonValue = true,
                Width = 40
            });
            dtg_busc1.AllowUserToAddRows = false;
            dtg_busc1.RowHeadersVisible = false;
        }
        private void C_product()
        {
            listaproductos.Add(new Producto(1, "Camiseta Básica", "Camiseta de algodón manga corta", "Camisetas", "Blanco", "M", 12.99m, 45, "Activo", "CAM-BAS-001"));
            listaproductos.Add(new Producto(2, "Camiseta Estampada", "Camiseta con diseño gráfico", "Camisetas", "Negro", "L", 15.99m, 30, "Activo", "CAM-EST-002"));
            listaproductos.Add(new Producto(3, "Jean Slim Fit", "Pantalón de mezclilla ajustado", "Pantalones", "Azul", "32", 34.99m, 20, "Activo", "JEA-SLI-003"));
            listaproductos.Add(new Producto(4, "Jean Recto", "Pantalón de mezclilla corte recto", "Pantalones", "Azul Oscuro", "34", 32.99m, 15, "Activo", "JEA-REC-004"));
            listaproductos.Add(new Producto(5, "Chaqueta de Cuero", "Chaqueta biker de cuero sintético", "Chaquetas", "Negro", "L", 89.99m, 8, "Activo", "CHA-CUE-005"));
            listaproductos.Add(new Producto(6, "Chaqueta Denim", "Chaqueta de mezclilla clásica", "Chaquetas", "Azul Claro", "M", 54.99m, 12, "Activo", "CHA-DEN-006"));
            listaproductos.Add(new Producto(7, "Sudadera con Capucha", "Hoodie unisex de algodón", "Sudaderas", "Gris", "XL", 29.99m, 25, "Activo", "SUD-CAP-007"));
            listaproductos.Add(new Producto(8, "Sudadera Oversize", "Sudadera holgada estilo urbano", "Sudaderas", "Beige", "L", 27.99m, 18, "Activo", "SUD-OVE-008"));
            listaproductos.Add(new Producto(9, "Vestido Casual", "Vestido de verano ligero", "Vestidos", "Floral", "S", 24.99m, 10, "Activo", "VES-CAS-009"));
            listaproductos.Add(new Producto(10, "Vestido de Noche", "Vestido elegante para ocasiones especiales", "Vestidos", "Negro", "M", 45.99m, 6, "Activo", "VES-NOC-010"));
            listaproductos.Add(new Producto(11, "Falda Plisada", "Falda midi con pliegues", "Faldas", "Rosa", "S", 19.99m, 14, "Activo", "FAL-PLI-011"));
            listaproductos.Add(new Producto(12, "Short Deportivo", "Short de tela ligera para ejercicio", "Shorts", "Negro", "M", 14.99m, 22, "Activo", "SHO-DEP-012"));
            listaproductos.Add(new Producto(13, "Short Casual", "Short de mezclilla corte alto", "Shorts", "Azul", "Única", 18.99m, 16, "Activo", "SHO-CAS-013"));
            listaproductos.Add(new Producto(14, "Polo Clásico", "Camisa polo de algodón piqué", "Camisas", "Verde", "L", 22.99m, 20, "Activo", "POL-CLA-014"));
            listaproductos.Add(new Producto(15, "Camisa Formal", "Camisa de vestir manga larga", "Camisas", "Blanco", "M", 26.99m, 17, "Activo", "CAM-FOR-015"));
            listaproductos.Add(new Producto(16, "Blusa Elegante", "Blusa de seda sintética", "Blusas", "Vino", "S", 21.99m, 9, "Inactivo", "BLU-ELE-016"));
            listaproductos.Add(new Producto(17, "Suéter de Lana", "Suéter tejido para clima frío", "Suéteres", "Café", "L", 38.99m, 11, "Activo", "SUE-LAN-017"));
            listaproductos.Add(new Producto(18, "Leggings Deportivos", "Mallas elásticas de alto rendimiento", "Deportivo", "Negro", "M", 17.99m, 28, "Activo", "LEG-DEP-018"));
            listaproductos.Add(new Producto(19, "Bufanda de Invierno", "Bufanda tejida gruesa", "Accesorios", "Gris", "Única", 9.99m, 35, "Activo", "BUF-INV-019"));
            listaproductos.Add(new Producto(20, "Gorra Deportiva", "Gorra ajustable con visera curva", "Accesorios", "Negro", "Única", 11.99m, 40, "Inactivo", "GOR-DEP-020"));

            dtg_busc1.DataSource = listaproductos;
        }

        private void gbtn_volver1_Click(object sender, EventArgs e)
        {
            FormProductos frm = this.Parent.Parent as FormProductos;
            frm.MostrarFrm();
        }
    }
}
