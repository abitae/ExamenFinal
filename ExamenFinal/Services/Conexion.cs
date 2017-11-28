using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ExamenFinal.Services
{
    public class Conexion
    {
        public static string cn = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
        public SqlConnection sqlcad = new SqlConnection("Data Source=serverdbexamen.database.windows.net;Initial Catalog=ExamenDB;Persist Security Info=True;User ID=abitae;Password=lobomalo123A@");

        public void Conectar()
        {
            sqlcad.Open();
        }
        public void Desconectar()
        {
            sqlcad.Close();
        }
    }
}