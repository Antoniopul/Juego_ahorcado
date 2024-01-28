using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Blibliotecas_Clases
{
    public class Conexion
    {
        public string StrCnWindows = @"Data source=DESKTOP-935G057; Initial Catalog=Juego; integrated security=true;";

        //insert, update, delete
        public bool ejecutar(string query)
        {
            SqlConnection objCnx = new SqlConnection(StrCnWindows);
            try
            {
                objCnx.Open();
                SqlCommand obsqlcmd = new SqlCommand(query, objCnx);
                obsqlcmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //select
        public DataTable RegresaValores(string query)
        {
            SqlConnection objCnx = new SqlConnection(StrCnWindows);
            DataSet dtset = new DataSet();
            try
            {
                objCnx.Open();
                SqlCommand obsqlcmd = new SqlCommand(query, objCnx);
                obsqlcmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(obsqlcmd);
                da.Fill(dtset);
                return dtset.Tables[0];
            }
            catch
            {
                return null;
            }
        }
    }
}

