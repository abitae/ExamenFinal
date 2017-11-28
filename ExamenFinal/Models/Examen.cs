namespace ExamenFinal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class Examen
    {
        public string CodiExamen { get; set; }
        public string Curso { get; set; }
        public string Id { get; set; }
        public DateTime? DateExamen { get; set; }      
    }
}
