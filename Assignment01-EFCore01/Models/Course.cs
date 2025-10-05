using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01_EFCore01.Models
{
    internal class Course //By DataAnotations
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("Crs_Name",TypeName ="varchar")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Range(1,3)]
        public DateTime Duration { get; set; }

        [AllowNull]
        [StringLength(500)]
        public string? Description { get; set; }

        [Required]
        public int Top_Id { get; set; }
    }
}