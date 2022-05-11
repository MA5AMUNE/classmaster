namespace classmaster.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Subjects
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal SubjectCode { get; set; }

        [StringLength(50)]
        public string SubjectName { get; set; }

        public virtual Teachers Teachers { get; set; }
    }
}
