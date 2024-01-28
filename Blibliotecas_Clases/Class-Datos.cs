using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Blibliotecas_Clases
{
    public class Class
    {
        public string Palab { get; set; }
        public string Pista { get; set; }
        public string ID_palabra { get; set; }

        Conexion con = new Conexion();

        public bool insertar_palabra()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("INSERT INTO Palabras (Palabra)");
            sql.AppendLine("VALUES('" + Palab + "')");

            if (con.ejecutar(sql.ToString()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool insertar_pista()
        {
            StringBuilder sql = new StringBuilder();

            sql.AppendLine("INSERT INTO Pistas(Pista,ID_Palabra)");
            sql.AppendLine("VALUES('" + Pista + "',");
            sql.AppendLine("'" + ID_palabra + "')");

            if (con.ejecutar(sql.ToString()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable actualizarpalbra()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("select * from Palabras");
            Conexion con = new Conexion();
            return con.RegresaValores(sql.ToString());
        }

        public DataTable actualizarpista()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("select * from Pistas");
            Conexion con = new Conexion();
            return con.RegresaValores(sql.ToString());
        }

        public DataTable Mostrar_ID()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("select * from Pistas Where ID_Palabra ="+ ID_palabra );
            return con.RegresaValores(sql.ToString());   
        }

        public void validacion(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
