namespace classmaster.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Сatering
    {
        public int Id { get; set; }

        [Column("Сatering")]
        public bool? Сatering1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        public virtual Students Students { get; set; }
    }
}
