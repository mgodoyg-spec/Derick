using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Text;

namespace Derick
{
    internal class csConectaSQL
    {
        SqlConnection oCon;
        string Server;
        string Database;
        string Usuario;
        string Clave;
        string Cadena;
        DataTable ODT;
        SqlCommand oCom;
        SqlDataAdapter oDA;
        public csConectaSQL()
        {
            Server = "100.123.50.34,1433";
            Database = "Derick";
            Usuario = "Michelle";
            Clave = "Michelle@27";
        }

        public csConectaSQL(string Server, string Database, string Usuario, string Clave)
        {
            this.Server = Server;
            this.Database = Database;
            this.Usuario = Usuario;
            this.Clave = Clave;
        }

        public bool abrirConexion()
        {
            try
            {
                oCon = new SqlConnection();
                oCon.ConnectionString = Cadena = "Server=" + Server + "; Database=" + Database
                    + "; User id=" + Usuario + "; Password=" + Clave + "; TrustServerCertificate=True;";
                oCon.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool cerrarConexion()
        {
            try
            {
                if (oCon != null)
                    oCon.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public DataTable RetornaRegistros(string sql)
        {
            try
            {
                if (abrirConexion())
                {
                    oDA = new SqlDataAdapter(sql, oCon);
                    ODT = new DataTable();
                    oDA.Fill(ODT);
                    cerrarConexion();
                    return ODT;
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public bool insertDatos(string tabla, string campos, string datos)
        {
            try
            {
                if (abrirConexion())
                {
                    Cadena = "insert into " + tabla + " (" + campos + ") values (" + datos + ")";
                    oCom = new SqlCommand(Cadena, oCon);
                    oCom.ExecuteNonQuery();
                    cerrarConexion();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
