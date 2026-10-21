using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ef_task.Models.ModelsConfiguration
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            //with department 1:M
            builder.HasOne(e => e.Department)
                .WithMany(d => d.employees)
                .HasForeignKey(e => e.DeptID)
                .OnDelete(DeleteBehavior.Cascade);

            //with department 1:1
            builder.HasOne(e => e.ManageDepartment)
                .WithOne(d => d.employee)
                .HasForeignKey<Department>(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);

            //with project N:M
            builder.HasMany(e => e.Projects)
                .WithMany(p => p.Employees)
                .UsingEntity(j => j.ToTable("EmployeeProject"));

            //1:M with Dependents 
            builder.HasOne(e => e.Department)
                .WithMany(d => d.employees)
                .HasForeignKey(d => d.DeptID)
                .OnDelete(DeleteBehavior.Cascade);

            //1:M self relation
            builder.HasOne(e => e.SuperVisor)
                .WithMany(e => e.Subordinates)
                .HasForeignKey(e => e.SuperVisorId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
