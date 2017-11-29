using ExamenFinal.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExamenFinal.Pages
{
    public partial class ExamenAlumno : System.Web.UI.Page
    {
        ExamenModel examenModel = new ExamenModel();
        private string valor;
        private string valor2;
        bool control;
        protected void Page_Load(object sender, EventArgs e)
        {
            try {
                control = false;
                MiExamen();
            }
            catch { }
            
        }
        private void MiExamen()
        {   valor = Convert.ToString(Request.QueryString["ce"]);
            valor2 = Convert.ToString(Request.QueryString["ca"]);
            if (String.IsNullOrEmpty(valor) && String.IsNullOrEmpty(valor2)) {
                Response.Redirect("MatriculaAlumno.aspx");
            }
            else {
                DataTable dt = new DataTable();
                dt = examenModel.MiExamen(valor);

                int i = 0;
                int[] CodiPregunta = new int[40];
                int[] CodiRespuesta = new int[40];
                string[] Pregunta = new string[40];
                string[] Respuesta = new string[40];
                foreach (DataRow row in dt.Rows)
                {
                    CodiPregunta[i] = Convert.ToInt32(row["CodiPregunta"].ToString());
                    CodiRespuesta[i] = Convert.ToInt32(row["CodiRespuesta"].ToString());
                    Pregunta[i] = row["Pregunta"].ToString();
                    Respuesta[i] = row["Respuesta"].ToString();
                    i++;
                    if (i == 40) { break; }
                }
                //Carga Examen
                //pre1
                preg1.Text = Pregunta[0];
                rp11.Text = Respuesta[0];
                rp12.Text = Respuesta[1];
                rp13.Text = Respuesta[2];
                rp14.Text = Respuesta[3];
                //pre1
                preg2.Text = Pregunta[4];
                rp21.Text = Respuesta[4];
                rp22.Text = Respuesta[5];
                rp23.Text = Respuesta[6];
                rp24.Text = Respuesta[7];
                //pre1
                preg3.Text = Pregunta[8];
                rp31.Text = Respuesta[8];
                rp32.Text = Respuesta[9];
                rp33.Text = Respuesta[10];
                rp34.Text = Respuesta[11];
                //pre1
                preg4.Text = Pregunta[12];
                rp41.Text = Respuesta[12];
                rp42.Text = Respuesta[13];
                rp43.Text = Respuesta[14];
                rp44.Text = Respuesta[15];
                //pre1
                preg5.Text = Pregunta[16];
                rp51.Text = Respuesta[16];
                rp52.Text = Respuesta[17];
                rp53.Text = Respuesta[18];
                rp54.Text = Respuesta[19];
                //pre1
                preg6.Text = Pregunta[20];
                rp61.Text = Respuesta[20];
                rp62.Text = Respuesta[21];
                rp63.Text = Respuesta[22];
                rp64.Text = Respuesta[23];
                //pre1
                preg7.Text = Pregunta[24];
                rp71.Text = Respuesta[24];
                rp72.Text = Respuesta[25];
                rp73.Text = Respuesta[26];
                rp74.Text = Respuesta[27];
                //pre1
                preg8.Text = Pregunta[28];
                rp81.Text = Respuesta[28];
                rp82.Text = Respuesta[29];
                rp83.Text = Respuesta[30];
                rp84.Text = Respuesta[31];
                //pre1
                preg9.Text = Pregunta[32];
                rp91.Text = Respuesta[32];
                rp92.Text = Respuesta[33];
                rp93.Text = Respuesta[34];
                rp94.Text = Respuesta[35];
                //pre1
                preg10.Text = Pregunta[36];
                rp101.Text = Respuesta[36];
                rp102.Text = Respuesta[37];
                rp103.Text = Respuesta[38];
                rp104.Text = Respuesta[39];

                int[] Preg = CodiPregunta.Distinct().ToArray();
                int[] Resp = CodiRespuesta;

                if (control) {
                    ValidateData(Preg, Resp, valor, valor2);
                }
                
            }
        }
        private void ValidateData(int[] p, int[] r,string codExamen,string idAlumno)
        {
            int respreg1 = 0;
            if (rp11.Checked)
            {
                respreg1 = r[0];
            }
            else if (rp12.Checked)
            {
                respreg1 = r[1];
            }
            else if (rp13.Checked)
            {
                respreg1 = r[2];
            }
            else if (rp14.Checked)
            {
                respreg1 = r[3];
            }
            else
            {
                Info.Text = "Responda la preguna 1";
               
            }
            

            int respreg2 = 0;
            if (rp21.Checked)
            {
                respreg2 = r[4];
            }
            else if (rp22.Checked)
            {
                respreg2 = r[5];
            }
            else if (rp23.Checked)
            {
                respreg2 = r[6];
            }
            else if (rp24.Checked)
            {
                respreg2 = r[7];
            }
            else
            {
                Info.Text = "Responda la preguna 2";
                
            }
           
            //::______

            int respreg3 = 0;
            if (rp31.Checked)
            {
                respreg3 = r[8];
            }
            else if (rp32.Checked)
            {
                respreg3 = r[9];
            }
            else if (rp33.Checked)
            {
                respreg3 = r[10];
            }
            else if (rp34.Checked)
            {
                respreg3 = r[11];
            }
            else
            {
                Info.Text = "Responda la preguna 3";
               
            }
            
            //__________________________

            int respreg4 = 0;
            if (rp41.Checked)
            {
                respreg4 = r[12];
            }
            else if (rp42.Checked)
            {
                respreg4 = r[13];
            }
            else if (rp43.Checked)
            {
                respreg4 = r[14];
            }
            else if (rp44.Checked)
            {
                respreg4 = r[15];
            }
            else
            {
                Info.Text = "Responda la preguna 4";
                
            }
            
            ///----
            ///
            int respreg5 = 0;
            if (rp51.Checked)
            {
                respreg5 = r[16];
            }
            else if (rp52.Checked)
            {
                respreg5 = r[17];
            }
            else if (rp53.Checked)
            {
                respreg5 = r[18];
            }
            else if (rp54.Checked)
            {
                respreg5 = r[19];
            }
            else
            {
                Info.Text = "Responda la preguna 5";
                
            }
           
            ///----
            /// 
            int respreg6 = 0;
            if (rp61.Checked)
            {
                respreg6 = r[20];
            }
            else if (rp62.Checked)
            {
                respreg6 = r[21];
            }
            else if (rp63.Checked)
            {
                respreg6 = r[22];
            }
            else if (rp64.Checked)
            {
                respreg6 = r[23];
            }
            else
            {
                Info.Text = "Responda la preguna 6";
                
            }
            
            ///----
            int respreg7 = 0;
            if (rp71.Checked)
            {
                respreg7 = r[24];
            }
            else if (rp72.Checked)
            {
                respreg7 = r[25];
            }
            else if (rp73.Checked)
            {
                respreg7 = r[26];
            }
            else if (rp74.Checked)
            {
                respreg7 = r[27];
            }
            else
            {
                Info.Text = "Responda la preguna 7";
               
            }
            
            ///----
            int respreg8 = 0;
            if (rp81.Checked)
            {
                respreg8 = r[28];
            }
            else if (rp82.Checked)
            {
                respreg8 = r[29];
            }
            else if (rp83.Checked)
            {
                respreg8 = r[30];
            }
            else if (rp84.Checked)
            {
                respreg8 = r[31];
            }
            else
            {
                Info.Text = "Responda la preguna 8";
                
            }
           
            ///----
            int respreg9 = 0;
            if (rp91.Checked)
            {
                respreg9 = r[32];
            }
            else if (rp92.Checked)
            {
                respreg9 = r[33];
            }
            else if (rp93.Checked)
            {
                respreg9 = r[34];
            }
            else if (rp94.Checked)
            {
                respreg9 = r[35];
            }
            else
            {
                Info.Text = "Responda la preguna 9";
                
            }
            
            ///----
            int respreg10 = 0;
            if (rp101.Checked)
            {
                respreg10 = r[36];
            }
            else if (rp102.Checked)
            {
                respreg10 = r[37];
            }
            else if (rp103.Checked)
            {
                respreg10 = r[38];
            }
            else if (rp104.Checked)
            {
                respreg10 = r[39];
            }
            else
            {
                Info.Text = "Responda la preguna 10";
                


            }
            if (respreg1 != 0 && respreg2 != 0 && respreg3 != 0 && respreg4 != 0 &&  respreg5  != 0 && respreg6  != 0 && respreg7 != 0 && respreg8  != 0 && respreg9 != 0 && respreg10 != 0 ) {
                examenModel.InsertData(idAlumno, codExamen, p[0], respreg1);
                examenModel.InsertData(idAlumno, codExamen, p[1], respreg2);
                examenModel.InsertData(idAlumno, codExamen, p[2], respreg3);
                examenModel.InsertData(idAlumno, codExamen, p[3], respreg4);
                examenModel.InsertData(idAlumno, codExamen, p[4], respreg5);
                examenModel.InsertData(idAlumno, codExamen, p[5], respreg6);
                examenModel.InsertData(idAlumno, codExamen, p[6], respreg7);
                examenModel.InsertData(idAlumno, codExamen, p[7], respreg8);
                examenModel.InsertData(idAlumno, codExamen, p[8], respreg9);
                examenModel.InsertData(idAlumno, codExamen, p[9], respreg10);
                control = false;
            }
        }

        protected void BtnFinalizar_Click(object sender, EventArgs e)
        {
            try {
                control = true;

                MiExamen();
                Response.Redirect("~/Pages/MatriculaAlumno.aspx?ca=" + valor2 + "?ce=" + valor);
            } catch { }
            
           
        }

    }
}