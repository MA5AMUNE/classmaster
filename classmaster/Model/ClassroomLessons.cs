namespace classmaster.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ClassroomLessons
    {
        public DateTime? LessonDate { get; set; }

        [StringLength(50)]
        public string ThemeClassroomLesson { get; set; }

        public string Note { get; set; }

        public int Id { get; set; }
    }
}
