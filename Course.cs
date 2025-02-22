using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace C43_G01_EFCore02

{
    internal class Course
    {
        [Key]
        public int Id { get; set; }
        public int Duration { get; set; }
        [Required]
        [Column("EmpName", TypeName = "varchar(50)")]
        public string Name { get; set; }
        public string Description { get; set; }
        public Topic Top_Id { get; set; } = null!;

    }
}
