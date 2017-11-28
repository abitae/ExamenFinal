namespace ExamenFinal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DataAlumnoExamen
    {   
        public int idData { get; set; }
        public int? CodiPregunta { get; set; }
        public int? CodiRespuesta { get; set; }
    }
}
