namespace classmaster.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Parents
    {
        public int Id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ParentsId { get; set; }

        [StringLength(150)]
        public string MothersFullName { get; set; }

        [StringLength(50)]
        public string MothersJob { get; set; }

        [StringLength(50)]
        public string MothersEducation { get; set; }

        [StringLength(15)]
        public string MothersPhone { get; set; }

        [StringLength(150)]
        public string FathersFullName { get; set; }

        [StringLength(50)]
        public string FathersJob { get; set; }

        [StringLength(50)]
        public string FathersEducation { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FathersPhone { get; set; }

        [StringLength(150)]
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
