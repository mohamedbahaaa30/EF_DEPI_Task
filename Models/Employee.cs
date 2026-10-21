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
        [Required , MaxLength(50) , MinLength(2)]
        public string FName { get; set; }
        [MaxLength(50), MinLength(2)]
        public string LName { get; set; }   
        public Gender Gender { get; set; }
        public string Addresss { get; set; }
        public decimal Salary { get; set; }

        //navigation properties

        // 1:M relation 
        public int DeptID { get; set; }
        public Department Department { get; set; }

        // 1:1 relation
        public Department ManageDepartment { get; set; }

        //M:N with projects 
        public List<Projects> Projects { get; set; }

        //1:M with dependents 
        public List<Dependent> dependents { get; set; }

        //1:M self relation 
        public int SuperVisorId { get; set; }
        public Employee SuperVisor { get; set; }

        public List<Employee> Subordinates { get; set; }

    }
    public enum Gender
    {
        Male,
        Female
    }
}
