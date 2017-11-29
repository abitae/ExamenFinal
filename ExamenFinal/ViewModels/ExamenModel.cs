
using ExamenFinal.Models;
using ExamenFinal.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ExamenFinal.ViewModels
{
    public class ExamenModel : Examen
    {
        Conexion cn = new Conexion();
        ShareModel sm = new ShareModel();
        public DataTable MiExamen(string codiExamen)
        {
            DataTable dt = new DataTable("Preguntas");
            dt = sm.ExeProcedure("SP_PreguntasExamenAlumno", "@CodiExamen", codiExamen);
            return dt;
        }

        internal void InsertData(string idAlumno, string codExamen, int pregunta, int respuesta)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "DataAlumnoInsert";
            cn.Conectar();
            da.SelectCommand = cmd;
            da.SelectCommand.Parameters.Add("@Id", SqlDbType.NVarChar).Value = idAlumno;
            da.SelectCommand.Parameters.Add("@CodiExamen", SqlDbType.Char).Value = codExamen;
            da.SelectCommand.Parameters.Add("@CodiPregunta", SqlDbType.Int).Value = pregunta;
            da.SelectCommand.Parameters.Add("@CodiRespuesta", SqlDbType.Int).Value = respuesta;
            da.Fill(dt);
            cn.Desconectar();
            
        }
    }
}