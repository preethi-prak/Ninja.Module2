using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CodeModel
{
    public partial class AWModel : DbContext
    {
        public AWModel()
            : base("name=AWModel")
        {
        }

        public virtual DbSet<brand> brands { get; set; }
        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<order> orders { get; set; }
        public virtual DbSet<staff> staffs { get; set; }
        public virtual DbSet<store> stores { get; set; }
        public virtual DbSet<vw_CustomerData> vw_CustomerData { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<brand>()
                .Property(e => e.brand_name)
                .IsUnicode(false);

            modelBuilder.Entity<category>()
                .Property(e => e.category_name)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.first_name)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.last_name)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.street)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.state)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.zip_code)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .HasMany(e => e.orders)
                .WithOptional(e => e.customer)
                .WillCascadeOnDelete();

            modelBuilder.Entity<staff>()
                .Property(e => e.first_name)
                .IsUnicode(false);

            modelBuilder.Entity<staff>()
                .Property(e => e.last_name)
                .IsUnicode(false);

            modelBuilder.Entity<staff>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<staff>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<staff>()
                .HasMany(e => e.orders)
                .WithRequired(e => e.staff)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<staff>()
                .HasMany(e => e.staffs1)
                .WithOptional(e => e.staff1)
                .HasForeignKey(e => e.manager_id);

            modelBuilder.Entity<store>()
                .Property(e => e.store_name)
                .IsUnicode(false);

            modelBuilder.Entity<store>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<store>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<store>()
                .Property(e => e.street)
                .IsUnicode(false);

            modelBuilder.Entity<store>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<store>()
                .Property(e => e.state)
                .IsUnicode(false);

            modelBuilder.Entity<store>()
                .Property(e => e.zip_code)
                .IsUnicode(false);

            modelBuilder.Entity<vw_CustomerData>()
                .Property(e => e.first_name)
                .IsUnicode(false);

            modelBuilder.Entity<vw_CustomerData>()
                .Property(e => e.email)
                .IsUnicode(false);
        }
    }
}
