using ExamenFinal.Models;
using ExamenFinal.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ExamenFinal.ViewModels
{
    public class MatriculaModel : Matricula
    {
        ShareModel sm = new ShareModel();
        public DataTable MisExamenes(string id)
        {
            DataTable dt = new DataTable("Matricula");
            dt = sm.ExeProcedure("SP_MatriculaAlumnoView", "@IdAlumno", id);
            return dt;
        }
    }
}