namespace Griveance.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ViewGetStudentInfo")]
    public partial class ViewGetStudentInfo
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [StringLength(100)]
        public string name { get; set; }

        public int? code { get; set; }

        [StringLength(20)]
        public string gender { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string course_name { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string class_name { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(100)]
        public string email { get; set; }

        public long? contact { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(100)]
        public string type { get; set; }

        public int? Display { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(5)]
        public string Status { get; set; }
    }
}
