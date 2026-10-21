using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef_task.Models
{
    [PrimaryKey(nameof(EmployeeSsn),nameof(Name))]
    internal class Dependent : Admin_configuration
    {
        public int EmployeeSsn { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        [Required]
        public string Relationship { get; set; }

        //navigation properties 

        [Required]
        public int EmployeeId { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        public Employee Employee { get; set; }

    }
}
