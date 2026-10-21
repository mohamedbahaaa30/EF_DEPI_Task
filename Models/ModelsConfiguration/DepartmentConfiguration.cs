using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef_task.Models.ModelsConfiguration
{
    internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            //1:M with employee
            builder.HasMany(d => d.employees)
                .WithOne(e => e.Department)
                .HasForeignKey(e => e.DeptID)
                .OnDelete(DeleteBehavior.Cascade);

            //1:1 with employee
            builder.HasOne(d => d.employee)
                .WithOne(e => e.ManageDepartment)
                .HasForeignKey<Department>(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);

            //1:M with projects
            builder.HasMany(d => d.projects)
                .WithOne(p => p.Department)
                .HasForeignKey(p => p.DeptId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
