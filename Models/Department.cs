using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef_task.Models
{
    internal class Department : Admin_configuration
    {
        [Key]
        public int Number {  get; set; }
        [Required , MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public List<string> location { get; set; }
        public int NumberOfEmployees => employees.Count;

        // navigation properties

        // 1:M with employee
        public List<Employee> employees { get; set; }

        // 1:1 employee

        [ForeignKey(nameof(EmployeeId))]
        public int EmployeeId { get; set; }
        public Employee employee { get; set; }

        // 1:M with projects 
        public List <Projects> projects { get; set; }


    }
}
