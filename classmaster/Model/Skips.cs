namespace classmaster.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Skips
    {
        public int StudentId { get; set; }

        public DateTime? Date { get; set; }

        public bool? ResonableExcuse { get; set; }

        public int Id { get; set; }
    }
}
