using Microsoft.EntityFrameworkCore;
using SchoolBus.Models.Abstracts;
using SchoolBus.Models.Concretes;

namespace SchoolBus.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = WIN-2FA9I1VU4LK; Initial Catalog = SchoolBusDb; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False");
        }

        public override int SaveChanges()
        {
            var datas = ChangeTracker.Entries<BaseEntity>();

            foreach (var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedTime = data.Entity.ModifiedTime = DateTime.Now,
                    EntityState.Modified => data.Entity.ModifiedTime = DateTime.Now,
                    _ => DateTime.UtcNow
                };
            }

            return base.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Parent>(entity =>
            {
                entity.HasMany(p => p.Students)
                    .WithOne(s => s.Parent)
                    .HasForeignKey(s => s.ParentId);

                entity.Property(p => p.FirstName).IsRequired();
                entity.Property(p => p.LastName).IsRequired();
                entity.Property(p => p.PhoneNumber).IsRequired();
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(s => s.FirstName).IsRequired();
                entity.Property(s => s.LastName).IsRequired();
                entity.Property(s => s.Address).IsRequired();
                entity.Property(s => s.OtherAddress);

                entity.HasOne(s => s.Parent)
                    .WithMany(p => p.Students)
                    .HasForeignKey(s => s.ParentId);

                entity.HasOne(s => s.Ride)
                    .WithMany(r => r.Students)
                    .HasForeignKey(s => s.RideId)
                    .OnDelete(DeleteBehavior.NoAction);

                entity.HasOne(s => s.Class)
                    .WithMany(c => c.Students)
                    .HasForeignKey(s => s.ClassId)
                    .OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<Ride>(entity =>
            {
                //entity.Property(r => r.CarId).IsRequired();
                entity.Property(r => r.CarId);

                entity.HasOne(r => r.Car)
                    .WithOne()
                    .HasForeignKey<Ride>(r => r.CarId)
                    .OnDelete(DeleteBehavior.NoAction);

                //entity.Property(r => r.DriverId).IsRequired();
                entity.Property(r => r.DriverId);


                entity.HasOne(r => r.Driver)
                    .WithOne(d => d.Ride)
                    .HasForeignKey<Ride>(r => r.DriverId)
                    .OnDelete(DeleteBehavior.NoAction);
                
            });

            modelBuilder.Entity<Driver>(entity =>
            {   
                entity.Property(d => d.FirstName).IsRequired();
                entity.Property(d => d.LastName).IsRequired();
                entity.Property(d => d.Phone).IsRequired();
                entity.Property(d => d.Address).IsRequired();
                entity.Property(d => d.License).IsRequired();

                entity.HasOne(d => d.Car)
                    .WithOne(c => c.Driver)
                    .HasForeignKey<Driver>(d => d.CarId);
                    //.OnDelete(DeleteBehavior.SetNull);
            });


            modelBuilder.Entity<Class>(entity =>
            {
                entity.Property(c => c.Name).IsRequired();
            });
        }
    }
}