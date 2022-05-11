namespace classmaster.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Parents
    {
        [Column(TypeName = "numeric")]
        public decimal? ParentCode { get; set; }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal StudentCode { get; set; }

        public string MothersFullName { get; set; }

        [StringLength(50)]
        public string MothersJob { get; set; }

        [StringLength(50)]
        public string MothersEducation { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MothersPhone { get; set; }

        public string FathersFullName { get; set; }

        [StringLength(50)]
        public string FathersJob { get; set; }

        [StringLength(50)]
        public string FathersEducation { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FathersPhone { get; set; }

        public string AdopterFullName { get; set; }

        [StringLength(50)]
        public string AdopterJob { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AdopterPhone { get; set; }

        public bool? ParentCommittee { get; set; }

        public bool? IntactFamily { get; set; }

        public bool? OrphanChild { get; set; }

        [StringLength(10)]
        public string NumberOfChildren { get; set; }

        public virtual Students Students { get; set; }
    }
}
