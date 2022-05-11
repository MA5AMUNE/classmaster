namespace classmaster.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Teachers
    {
        [Column(TypeName = "numeric")]
        public decimal? TeacherCode { get; set; }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal SubjectCode { get; set; }

        public string TeacherFullName { get; set; }

        public virtual Subjects Subjects { get; set; }
    }
}
