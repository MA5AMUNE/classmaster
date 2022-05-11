namespace classmaster.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Skips
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal StudentCode { get; set; }

        public DateTime? Date { get; set; }

        public bool? ResonableExcuse { get; set; }

        public bool? BadExcuse { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Total { get; set; }

        public virtual Students Students { get; set; }
    }
}
