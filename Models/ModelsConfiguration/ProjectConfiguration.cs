using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef_task.Models.ModelsConfiguration
{
    internal class ProjectConfiguration : IEntityTypeConfiguration<Projects>
    {
        public void Configure(EntityTypeBuilder<Projects> builder)
        {
            ////1:M with department
            //builder.HasOne(p => p.Department)
            //    .WithMany(d => d.projects)
            //    .HasForeignKey(p => p.DeptId)
            //    .OnDelete(DeleteBehavior.Cascade);

            ////M:N with employee
            //builder.HasMany(p => p.Employees)
            //    .WithMany(e => e.Projects)
            //    .UsingEntity(j => j.ToTable("EmployeeProject"));
        }
    }
}
