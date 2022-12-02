﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shoess.Models;

#nullable disable

namespace Shoess.Migrations
{
    [DbContext(typeof(ShoeDbContext))]
    partial class ShoeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Shoess.Models.Shoe", b =>
                {
                    b.Property<int>("ShoeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShoeId"));

                    b.Property<string>("ShoeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShoeTypeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoeId");

                    b.ToTable("Shoes");
                });

            modelBuilder.Entity("Shoess.Models.ShoeType", b =>
                {
                    b.Property<int>("ShoeTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShoeTypeId"));

                    b.Property<string>("ShoeTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoeTypeId");

                    b.ToTable("ShoeTypes");
                });
#pragma warning restore 612, 618
        }
    }
}