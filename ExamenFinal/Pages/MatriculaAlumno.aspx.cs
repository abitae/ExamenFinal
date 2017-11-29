

namespace ExamenFinal.Pages
{
    using System;
    
    using ExamenFinal.ViewModels;
    using System.Web.UI.WebControls;

    public partial class MatriculaAlumno : System.Web.UI.Page
    {
       
           MatriculaModel matriculaModel = new MatriculaModel();
       internal string valor;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
               
                valor = Convert.ToString(Request.QueryString["ca"]);
                if (!String.IsNullOrEmpty(valor))
                {
                    grd_misexamenes.DataSource = matriculaModel.MisExamenes(valor);
                    grd_misexamenes.DataBind();
                }
            }
            catch
            {

            }
            
        }
        private void MisExamenes(string id)
        {

            
        }

        protected void grd_misexamenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = grd_misexamenes.SelectedRow;
            string codiExamen = "";
            codiExamen = Convert.ToString(grd_misexamenes.DataKeys[row.RowIndex].Value);
            Response.Redirect("ExamenAlumno.aspx?ca="+valor+"?ce="+ codiExamen);
        }
    }
}