namespace classmaster.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HealthCard")]
    public partial class HealthCard
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal StudentCode { get; set; }

        [StringLength(50)]
        public string HealthGroup { get; set; }

        [StringLength(50)]
        public string Diagnosis { get; set; }

        public string Recommendations { get; set; }

        public virtual Students Students { get; set; }
    }
}
