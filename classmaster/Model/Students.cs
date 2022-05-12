namespace classmaster.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Students
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string SecondName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Phone { get; set; }

        public DateTime Birthdate { get; set; }

        [Required]
        [StringLength(50)]
        public string HomeAdress { get; set; }

        public bool Sex { get; set; }

        [Required]
        [StringLength(50)]
        public string Nationality { get; set; }

        [Required]
        [StringLength(50)]
        public string OrderOfEnrollment { get; set; }

        [StringLength(50)]
        public string OrderOfExpulsion { get; set; }

        [Required]
        [StringLength(50)]
        public string BirthCertificate { get; set; }

        [StringLength(50)]
        public string IndividualTaxpayerNumber { get; set; }

        [StringLength(50)]
        public string HealthInsurancePolicy { get; set; }

        [StringLength(50)]
        public string InsuranceCertificate { get; set; }

        [StringLength(50)]
        public string Passport { get; set; }

        public virtual HealthCard HealthCard { get; set; }

        public virtual Parents Parents { get; set; }

        public virtual Сatering Сatering { get; set; }
    }
}
