using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace TesstEL.Model
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=ModelTest")
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeType> EmployeeTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeType>()
                .HasMany(e => e.Employees)
                .WithOptional(e => e.EmployeeType1)
                .HasForeignKey(e => e.EmployeeType);
        }
    }
}
