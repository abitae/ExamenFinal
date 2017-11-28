namespace ExamenFinal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Preguntas
    {
        public int CodiPregunta { get; set; } 
        public string CodiExamen { get; set; }
        public string Pregunta { get; set; }      
    }
}
