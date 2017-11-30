
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
        public int CorregirPregunta(string codiExamen,int codiPregunta)
        {
            DataTable dt = new DataTable("Preguntas");
            dt = sm.ExeProcedure("SP_CorregirPregunta", "@CodiExamen", codiExamen, "@CodiPregunta", codiPregunta);
            int CodiRespuesta = 0;
            foreach (DataRow row in dt.Rows)
            {
                
                CodiRespuesta = Convert.ToInt32(row["CodiRespuesta"].ToString());
                
            }
            return CodiRespuesta;
        }

        public bool SP_UpdateNota(string ce, string id,int nota) {
            try {
                DataTable dt = new DataTable("Preguntas");
                dt = sm.ExeProcedure("SP_UpdateNota", "@CodiExamen", ce, "@Id", id, "@nota", nota);
                return true;
            } catch {
                return false;
            }
            

        }
    }
}