﻿// <auto-generated />
using System;
using HandsOnEFCodeFirst.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HandsOnEFCodeFirst.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HandsOnEFCodeFirst.Entities.Order", b =>
                {
                    b.Property<string>("OId")
                        .HasColumnType("nvarchar(5)")
                        .HasMaxLength(5);

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Pid")
                        .HasColumnType("int");

                    b.HasKey("OId");

                    b.HasIndex("Pid");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("HandsOnEFCodeFirst.Entities.Product", b =>
                {
                    b.Property<int>("Pid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Pname")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<int?>("Price")
                        .HasColumnType("int");

                    b.Property<int?>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Pid");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("HandsOnEFCodeFirst.Entities.Order", b =>
                {
                    b.HasOne("HandsOnEFCodeFirst.Entities.Product", "Product")
                        .WithMany("Orders")
                        .HasForeignKey("Pid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
