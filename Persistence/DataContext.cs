using Domain.Domain;
using Domain.Domain.Controls;
using Domain.Domain.Inventory;
using Domain.Domain.User;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class DataContext : IdentityDbContext<AppUser>
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<FormControls> FormControls { get; set; }
        public DbSet<OtherFields> OtherFields { get; set; }
        public DbSet<Items> Items { get; set; }

        public override int SaveChanges()
        {
            AddAuditInfo();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            AddAuditInfo();
            return base.SaveChangesAsync(cancellationToken);
        }
        private void AddAuditInfo()
        {
            var timestamp = DateTime.UtcNow;


            foreach (var entry in ChangeTracker.Entries().Where(x => x.Entity is BaseEntity && (x.State == EntityState.Added || x.State == EntityState.Modified)))
            {

                if (entry.State == EntityState.Added)
                {

                    ((BaseEntity)entry.Entity).CreatedDate = timestamp;
                }


                ((BaseEntity)entry.Entity).UpdatedDate = timestamp;
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<OtherFields>(entity =>
            {
                entity.HasOne(x => x.FormControls)
                .WithMany(x => x.OtherFields)
                .HasForeignKey(y => y.FormID)
                .OnDelete(DeleteBehavior.NoAction);
            });

            builder.Entity<Items>().Property(x => x.ArbName4S).HasComputedColumnSql("replace(replace(replace([ArbName],'ى','ي'),'أ','ا'),'ة','ه')");

        }

        }
}
