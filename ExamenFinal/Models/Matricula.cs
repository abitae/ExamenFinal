namespace ExamenFinal.Models
{
    using ExamenFinal.Services;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.Entity.Spatial;
    using System.Data.SqlClient;

    public partial class Matricula
    {    
        public int CodMatricula { get; set; }      
        public string CodiExamen { get; set; }
        public string Id { get; set; }
        public decimal? Nota { get; set; }
        public int? IdData { get; set; }

        public Matricula()
        {

        }
        public DataTable SP_MatriculaAlumnoView(string idAlumno)
        {
            DataTable DtResultado = new DataTable("Matricula");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SP_MatriculaAlumnoView";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlParameter IdAlumno = new SqlParameter();
                IdAlumno.ParameterName = "@IdAlumno";
                IdAlumno.SqlDbType = SqlDbType.Char;
                
                IdAlumno.Value = idAlumno;
                SqlCmd.Parameters.Add(IdAlumno);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }
    }
}
