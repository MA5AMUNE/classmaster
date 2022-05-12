namespace classmaster.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Teachers
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int SubjectId { get; set; }

        [StringLength(150)]
        public string TeacherFullName { get; set; }

        public virtual Subjects Subjects { get; set; }
    }
}
