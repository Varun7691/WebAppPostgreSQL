using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppPostgreSQL.Models
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string CourseName { get; set; }

        [Required]
        [Column(TypeName = "varchar(11)")]
        public string CourseDuration { get; set; }
    }
}
