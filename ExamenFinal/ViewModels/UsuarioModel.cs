using ExamenFinal.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ExamenFinal.ViewModels
{
    public class UsuarioModel 
    {
        Conexion cn = new Conexion();
        ShareModel sm = new ShareModel();
        public DataTable UsuarioData(string Email)
        {
            DataTable dt = new DataTable("Usuario");
            dt = sm.ExeProcedure("SP_OptenerUserRoll", "@Email", Email);
            return dt;
        }
    }
}