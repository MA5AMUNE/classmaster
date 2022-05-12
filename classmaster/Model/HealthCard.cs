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
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string HealthGroup { get; set; }

        [StringLength(50)]
        public string Diagnosis { get; set; }

        public string Recommendations { get; set; }

        public virtual Students Students { get; set; }
    }
}
