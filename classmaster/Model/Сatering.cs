namespace classmaster.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Сatering
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal StudentCode { get; set; }

        [Column("Сatering")]
        public bool? Сatering1 { get; set; }

        public virtual Students Students { get; set; }
    }
}
