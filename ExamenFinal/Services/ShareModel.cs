using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace ExamenFinal.Services
{
    public class ShareModel
    {
        Conexion cn = new Conexion();
        public void ComboSelect (DropDownList cmb, String campover, string campovalor, string nomsp)
        {
            cmb.DataSource = ExeProcedure(nomsp);
            cmb.DataValueField = campovalor;
            cmb.DataTextField = campover;
            cmb.DataBind();
        }
        public DataTable ExeProcedure(string nom_sp)
        {
            //Llama a un sp que no requiera parámetros
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nom_sp;
            cn.Conectar();
            da.SelectCommand = cmd;
            da.Fill(dt);
            cn.Desconectar();
            return dt;

        }

        public DataTable ExeProcedure(string nom_sp, string nomparam, string valorparam)
        {
            //Llama a un sp que requiere un parámetro de tipo string 
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = nom_sp;
            cn.Conectar();
            da.SelectCommand = cmd;
            da.SelectCommand.Parameters.Add(nomparam, SqlDbType.NVarChar).Value = valorparam;
            da.Fill(dt);
            cn.Desconectar();
            return dt;

        }
        public DataTable ExeProcedure(string nom_sp, string nomparam1, int valorparam1)
        {
            //Llama a un sp que requiere un parámetro de tipo string 
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nom_sp;
            cn.Conectar();
            da.SelectCommand = cmd;
            da.SelectCommand.Parameters.Add(nomparam1, SqlDbType.Int).Value = valorparam1;
            da.Fill(dt);
            cn.Desconectar();
            return dt;

        }
        public DataTable ExeProcedure(string nom_sp, string nomparam1, double valorparam1, string nomparam2, double valorparam2)
        {
            //Llama a un sp que requiere un parámetro de tipo string 
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = nom_sp;
            cn.Conectar();
            da.SelectCommand = cmd;
            da.SelectCommand.Parameters.Add(nomparam1, SqlDbType.Money).Value = valorparam1;
            da.SelectCommand.Parameters.Add(nomparam2, SqlDbType.Money).Value = valorparam2;
            da.Fill(dt);
            cn.Desconectar();
            return dt;

        }

        public DataTable ExeProcedure(string nom_sp, string nomparam1, string valorparam1, string nomparam2, int valorparam2)
        {
            
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = nom_sp;
            cn.Conectar();
            da.SelectCommand = cmd;
            da.SelectCommand.Parameters.Add(nomparam1, SqlDbType.Char).Value = valorparam1;
            da.SelectCommand.Parameters.Add(nomparam2, SqlDbType.Int).Value = valorparam2;
            da.Fill(dt);
            cn.Desconectar();
            return dt;

        }
        public DataTable ExeProcedure(string nom_sp, string nomparam1, string valorparam1, string nomparam2, string valorparam2, string nomparam3, int valorparam3)
        {

            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = nom_sp;
            cn.Conectar();
            da.SelectCommand = cmd;
            da.SelectCommand.Parameters.Add(nomparam1, SqlDbType.Char).Value = valorparam1;
            da.SelectCommand.Parameters.Add(nomparam2, SqlDbType.Char).Value = valorparam2;
            da.SelectCommand.Parameters.Add(nomparam3, SqlDbType.Int).Value = valorparam3;
            da.Fill(dt);
            cn.Desconectar();
            return dt;

        }

    }



}