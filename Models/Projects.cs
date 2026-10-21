using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef_task.Models
{
    [Table("Project")]
    internal class Projects
    {
        [Key]
        public int Number {  get; set; }
        [Required]
        public string Name { get; set; }
        public string Location { get; set; }

        // navigation porperties 

        // 1:M with departmets 
        public int DeptId { get; set; }
        [ForeignKey(nameof(DeptId))]
        public Department Department { get; set; }

        // M:N with employee 
        public List<Employee> Employees { get; set; }
    }
}
