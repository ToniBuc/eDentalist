using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDentalist.WebAPI.Database
{
    public partial class eDentalistDbContext : DbContext
    {
        public eDentalistDbContext()
        {

        }

        public eDentalistDbContext(DbContextOptions<eDentalistDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Anamnesis> Anamnesis { get; set; }
        public virtual DbSet<Appointment> Appointment { get; set; }
        public virtual DbSet<AppointmentStatus> AppointmentStatus { get; set; }
        public virtual DbSet<Bill> Bill { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Equipment> Equipment { get; set; }
        public virtual DbSet<EquipmentType> EquipmentType { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<HygieneProcess> HygieneProcess { get; set; }
        public virtual DbSet<HygieneProcessType> HygieneProcessType { get; set; }
        public virtual DbSet<Material> Material { get; set; }
        public virtual DbSet<Procedure> Procedure { get; set; }
        public virtual DbSet<Requisition> Requisition { get; set; }
        public virtual DbSet<Shift> Shift { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserRole> UserRole{ get; set; }
        public virtual DbSet<UserWorkday> UserWorkday { get; set; }
        public virtual DbSet<Workday> Workday { get; set; }
        public virtual DbSet<Rating> Rating { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
