using Ip2Location.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ip2Location.Api
{
    public partial class Ip2LocationContext : DbContext
    {
        public Ip2LocationContext()
        {
        }

        public Ip2LocationContext(DbContextOptions<Ip2LocationContext> options)
            : base(options)
        {
        }

        public virtual DbSet<IpGeoLocation> IpGeoLocation { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<IpGeoLocation>(entity =>
            {
                entity.ToTable("ip_geo_location");

                entity.HasIndex(e => e.IpFrom)
                    .HasName("IDX_ECF8386FAA7DFDFF");

                entity.HasIndex(e => e.IpTo)
                    .HasName("IDX_ECF8386FC881EB0B");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasColumnName("country_code")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasColumnName("country_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.DomainName)
                    .IsRequired()
                    .HasColumnName("domain_name")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.IpFrom).HasColumnName("ip_from");

                entity.Property(e => e.IpTo).HasColumnName("ip_to");

                entity.Property(e => e.IspName)
                    .IsRequired()
                    .HasColumnName("isp_name")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasColumnName("region")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.TimeZone)
                    .IsRequired()
                    .HasColumnName("time_zone")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .IsRequired()
                    .HasColumnName("zip_code")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });
        }
    }
}
