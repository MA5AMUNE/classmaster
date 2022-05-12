namespace classmaster.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ClassEvents
    {
        [Column(TypeName = "date")]
        public DateTime? EventDate { get; set; }

        [StringLength(100)]
        public string Event { get; set; }

        public string Note { get; set; }

        public int Id { get; set; }
    }
}
