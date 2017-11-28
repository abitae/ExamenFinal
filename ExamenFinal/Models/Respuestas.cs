namespace ExamenFinal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Respuestas
    {
        public int CodiRespuesta { get; set; }
        public int CodiPregunta { get; set; }
        public string Respuesta { get; set; }
        public bool? value { get; set; }   
    }
}
