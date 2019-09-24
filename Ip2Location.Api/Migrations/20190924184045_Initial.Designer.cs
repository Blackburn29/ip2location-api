﻿// <auto-generated />
using Ip2Location.Api;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ip2Location.Api.Migrations
{
    [DbContext(typeof(Ip2LocationContext))]
    [Migration("20190924184045_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("Ip2Location.Api.Entities.IpGeoLocation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int(11)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnName("city")
                        .HasMaxLength(128)
                        .IsUnicode(false);

                    b.Property<string>("CountryCode")
                        .IsRequired()
                        .HasColumnName("country_code")
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnName("country_name")
                        .HasMaxLength(64)
                        .IsUnicode(false);

                    b.Property<string>("DomainName")
                        .IsRequired()
                        .HasColumnName("domain_name")
                        .HasMaxLength(256)
                        .IsUnicode(false);

                    b.Property<double>("IpFrom")
                        .HasColumnName("ip_from");

                    b.Property<double>("IpTo")
                        .HasColumnName("ip_to");

                    b.Property<string>("IspName")
                        .IsRequired()
                        .HasColumnName("isp_name")
                        .HasMaxLength(256)
                        .IsUnicode(false);

                    b.Property<double>("Latitude")
                        .HasColumnName("latitude");

                    b.Property<double>("Longitude")
                        .HasColumnName("longitude");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnName("region")
                        .HasMaxLength(128)
                        .IsUnicode(false);

                    b.Property<string>("TimeZone")
                        .IsRequired()
                        .HasColumnName("time_zone")
                        .HasMaxLength(7)
                        .IsUnicode(false);

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnName("zip_code")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.HasIndex("IpFrom")
                        .HasName("IDX_ECF8386FAA7DFDFF");

                    b.HasIndex("IpTo")
                        .HasName("IDX_ECF8386FC881EB0B");

                    b.ToTable("ip_geo_location");
                });
#pragma warning restore 612, 618
        }
    }
}
