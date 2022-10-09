namespace MNST
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("STUDENT")]
    public partial class STUDENT
    {
        [Key]
        [StringLength(20)]
        public string Student_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string FullName { get; set; }

        [Required]
        [StringLength(6)]
        public string Gender { get; set; }

        [Required]
        [StringLength(100)]
        public string Addresss { get; set; }

        public double AvgScore { get; set; }

        public int Faculty_ID { get; set; }

        public virtual FACULTY FACULTY { get; set; }
    }
}
