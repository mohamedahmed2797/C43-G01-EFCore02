using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G01_EFCore02
{
    internal class Department
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Ins_Id { get; set; }
        public DateOnly HiringDate { get; set; }
        public ICollection<Student>? Students { get; set; } = new HashSet<Student>();
        public ICollection<Instructor>? Instructors { get; set; } = new HashSet<Instructor>();

    }
}
