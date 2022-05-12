namespace classmaster.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sobytiya")]
    public partial class Sobytiya
    {
        [Column(TypeName = "date")]
        public DateTime? EventDate { get; set; }

        [StringLength(100)]
        public string Event { get; set; }

        public string Note { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }
    }
}
