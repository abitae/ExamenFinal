

namespace ExamenFinal.Pages
{
    using System;
    
    using ExamenFinal.ViewModels;
    using System.Web.UI.WebControls;

    public partial class MatriculaAlumno : System.Web.UI.Page
    {
        MatriculaModel matriculaModel = new MatriculaModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            MisExamenes();
        }
        private void MisExamenes()
        {
            grd_misexamenes.DataSource = matriculaModel.MisExamenes("a72159ab-7d05-4c21-8526-7568a0a59a1c");
            grd_misexamenes.DataBind();
        }

        protected void grd_misexamenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = grd_misexamenes.SelectedRow;
            string codiExamen = "";
            codiExamen = Convert.ToString(grd_misexamenes.DataKeys[row.RowIndex].Value);
            Response.Redirect("ExamenAlumno.aspx?codiExamen=" + codiExamen);
        }
    }
}