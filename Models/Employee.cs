using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef_task.Models
{
    internal class Employee : Admin_configuration
    {
        [Key]
        public int Ssn { get; set; }

        [Required, MaxLength(50), MinLength(2)]
        public string FName { get; set; } = string.Empty;

        [MaxLength(50), MinLength(2)]
        public string? LName { get; set; }

        public Gender Gender { get; set; }
        public string Address { get; set; } = string.Empty;
        public decimal Salary { get; set; }

        // 1:M - works in
        public int? DeptID { get; set; }
        public Department? Department { get; set; }

        // 1:1 - manages (FK is in Department)
        public Department? ManageDepartment { get; set; }

        // M:N
        public List<Projects> Projects { get; set; } = new();

        // 1:M dependents
        public List<Dependent> Dependents { get; set; } = new();

        // 1:M self relation
        public int? SuperVisorId { get; set; }
        public Employee? SuperVisor { get; set; }
        public List<Employee> Subordinates { get; set; } = new();
    }
    public enum Gender
    {
        Male,
        Female
    }
}
