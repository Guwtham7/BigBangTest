﻿// <auto-generated />
using System;
using BigBangTest.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BigBangTest.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BigBangTest.Models.Admin", b =>
                {
                    b.Property<int>("Admin_id")
                        .HasColumnType("int");

                    b.Property<string>("Admin_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Admin_id");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("BigBangTest.Models.Customer", b =>
                {
                    b.Property<int>("customer_id")
                        .HasColumnType("int");

                    b.Property<string>("customer_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("customer_id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("BigBangTest.Models.Motel", b =>
                {
                    b.Property<int>("motel_Id")
                        .HasColumnType("int");

                    b.Property<string>("Amenities")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoomOptions")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("motel_Id");

                    b.ToTable("Motel");
                });

            modelBuilder.Entity("BigBangTest.Models.Room", b =>
                {
                    b.Property<int>("room_Id")
                        .HasColumnType("int");

                    b.Property<bool>("Available_Status")
                        .HasColumnType("bit");

                    b.Property<string>("Property_Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Room_Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("motel_Id")
                        .HasColumnType("int");

                    b.Property<int?>("motel_Id1")
                        .HasColumnType("int");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.Property<int?>("room_Number")
                        .HasColumnType("int");

                    b.HasKey("room_Id");

                    b.HasIndex("motel_Id1");

                    b.ToTable("Room");
                });

            modelBuilder.Entity("BigBangTest.Models.Room", b =>
                {
                    b.HasOne("BigBangTest.Models.Motel", null)
                        .WithMany("Room")
                        .HasForeignKey("motel_Id1");
                });

            modelBuilder.Entity("BigBangTest.Models.Motel", b =>
                {
                    b.Navigation("Room");
                });
#pragma warning restore 612, 618
        }
    }
}
