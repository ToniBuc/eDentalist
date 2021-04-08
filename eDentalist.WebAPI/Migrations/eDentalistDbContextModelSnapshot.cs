﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eDentalist.WebAPI.Database;

namespace eDentalist.WebAPI.Migrations
{
    [DbContext(typeof(eDentalistDbContext))]
    partial class eDentalistDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("eDentalist.WebAPI.Database.Anamnesis", b =>
                {
                    b.Property<int>("AnamnesisID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdditionalNotes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AnamnesisContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AppointmentID")
                        .HasColumnType("int");

                    b.Property<string>("Therapy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AnamnesisID");

                    b.HasIndex("AppointmentID");

                    b.ToTable("Anamnesis");
                });

            modelBuilder.Entity("eDentalist.WebAPI.Database.Appointment", b =>
                {
                    b.Property<int>("AppointmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AppointmentStatusID")
                        .HasColumnType("int");

                    b.Property<int?>("DentistID")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("From")
                        .HasColumnType("time");

                    b.Property<int>("PatientID")
                        .HasColumnType("int");

                    b.Property<int>("ProcedureID")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("To")
                        .HasColumnType("time");

                    b.Property<int>("WorkdayID")
                        .HasColumnType("int");

                    b.HasKey("AppointmentID");

                    b.HasIndex("AppointmentStatusID");

                    b.HasIndex("DentistID");

                    b.HasIndex("PatientID");

                    b.HasIndex("ProcedureID");

                    b.HasIndex("WorkdayID");

                    b.ToTable("Appointment");
                });

            modelBuilder.Entity("eDentalist.WebAPI.Database.AppointmentStatus", b =>
                {
                    b.Property<int>("AppointmentStatusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AppointmentStatusID");

                    b.ToTable("AppointmentStatus");
                });

            modelBuilder.Entity("eDentalist.WebAPI.Database.Bill", b =>
                {
                    b.Property<int>("BillID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AppointmentID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsPaid")
                        .HasColumnType("BIT");

                    b.Property<decimal>("PaymentAmount")
                        .HasColumnType("DECIMAL(18,2)");

                    b.HasKey("BillID");

                    b.HasIndex("AppointmentID");

                    b.ToTable("Bill");
                });

            modelBuilder.Entity("eDentalist.WebAPI.Database.City", b =>
                {
                    b.Property<int>("CityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CountryID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZIPCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CityID");

                    b.HasIndex("CountryID");

                    b.ToTable("City");
                });

            modelBuilder.Entity("eDentalist.WebAPI.Database.Country", b =>
                {
                    b.Property<int>("CountryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryID");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("eDentalist.WebAPI.Database.Equipment", b =>
                {
                    b.Property<int>("EquipmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<bool>("Condition")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EquipmentTypeID")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastUsed")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EquipmentID");

                    b.HasIndex("EquipmentTypeID");

                    b.ToTable("Equipment");
                });

            modelBuilder.Entity("eDentalist.WebAPI.Database.EquipmentType", b =>
                {
                    b.Property<int>("EquipmentTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EquipmentTypeID");

                    b.ToTable("EquipmentType");
                });

            modelBuilder.Entity("eDentalist.WebAPI.Database.Gender", b =>
                {
                    b.Property<int>("GenderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenderID");

                    b.ToTable("Gender");
                });

            modelBuilder.Entity("eDentalist.WebAPI.Database.HygieneProcess", b =>
                {
                    b.Property<int>("HygieneProcessID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfPerformance")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HygieneProcessTypeID")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("HygieneProcessID");

                    b.HasIndex("HygieneProcessTypeID");

                    b.HasIndex("UserID");

                    b.ToTable("HygieneProcess");
                });

            modelBuilder.Entity("eDentalist.WebAPI.Database.HygieneProcessType", b =>
                {
                    b.Property<int>("HygieneProcessTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HygieneProcessTypeID");

                    b.ToTable("HygieneProcessType");
                });

            modelBuilder.Entity("eDentalist.WebAPI.Database.Material", b =>
                {
                    b.Property<int>("MaterialID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUsed")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaterialID");

                    b.ToTable("Material");
                });

            modelBuilder.Entity("eDentalist.WebAPI.Database.Procedure", b =>
                {
                    b.Property<int>("ProcedureID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("time");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("DECIMAL(18,2)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.HasKey("ProcedureID");

                    b.ToTable("Procedure");
                });

            modelBuilder.Entity("eDentalist.WebAPI.Database.Rating", b =>
                {
                    b.Property<int>("RatingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.Property<int>("ProcedureID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("RatingID");

                    b.HasIndex("ProcedureID");

                    b.HasIndex("UserID");

                    b.ToTable("Rating");
                });

            modelBuilder.Entity("eDentalist.WebAPI.Database.Requisition", b =>
                {
                    b.Property<int>("RequisitionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateRequisitioned")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EquipmentID")
                        .HasColumnType("int");

                    b.Property<int?>("MaterialID")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("RequisitionID");

                    b.HasIndex("EquipmentID");

                    b.HasIndex("MaterialID");

                    b.HasIndex("UserID");

                    b.ToTable("Requisition");
                });

            modelBuilder.Entity("eDentalist.WebAPI.Database.Shift", b =>
                {
                    b.Property<int>("ShiftID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<TimeSpan>("From")
                        .HasColumnType("time");

                    b.Property<int>("ShiftNumber")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("To")
                        .HasColumnType("time");

                    b.HasKey("ShiftID");

                    b.ToTable("Shift");
                });

            modelBuilder.Entity("eDentalist.WebAPI.Database.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CityID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenderID")
                        .HasColumnType("int");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("JMBG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordSalt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserRoleID")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.HasIndex("CityID");

                    b.HasIndex("GenderID");

                    b.HasIndex("UserRoleID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("eDentalist.WebAPI.Database.UserRole", b =>
                {
                    b.Property<int>("UserRoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserRoleID");

                    b.ToTable("UserRole");
                });

            modelBuilder.Entity("eDentalist.WebAPI.Database.UserWorkday", b =>
                {
                    b.Property<int>("UserWorkdayID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ShiftID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<int>("WorkdayID")
                        .HasColumnType("int");

                    b.HasKey("UserWorkdayID");

                    b.HasIndex("ShiftID");

                    b.HasIndex("UserID");

                    b.HasIndex("WorkdayID");

                    b.ToTable("UserWorkday");
                });

            modelBuilder.Entity("eDentalist.WebAPI.Database.Workday", b =>
                {
                    b.Property<int>("WorkdayID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.HasKey("WorkdayID");

                    b.ToTable("Workday");
                });

            modelBuilder.Entity("eDentalist.WebAPI.Database.Anamnesis", b =>
                {
                    b.HasOne("eDentalist.WebAPI.Database.Appointment", "Appointment")
                        .WithMany()
                        .HasForeignKey("AppointmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Appointment");
                });

            modelBuilder.Entity("eDentalist.WebAPI.Database.Appointment", b =>
                {
                    b.HasOne("eDentalist.WebAPI.Database.AppointmentStatus", "AppointmentStatus")
                        .WithMany()
                        .HasForeignKey("AppointmentStatusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eDentalist.WebAPI.Database.User", "Dentist")
                        .WithMany()
                        .HasForeignKey("DentistID");

                    b.HasOne("eDentalist.WebAPI.Database.User", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eDentalist.WebAPI.Database.Procedure", "Procedure")
                        .WithMany()
                        .HasForeignKey("ProcedureID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eDentalist.WebAPI.Database.Workday", "Workday")
                        .WithMany()
                        .HasForeignKey("WorkdayID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppointmentStatus");

                    b.Navigation("Dentist");

                    b.Navigation("Patient");

                    b.Navigation("Procedure");

                    b.Navigation("Workday");
                });

            modelBuilder.Entity("eDentalist.WebAPI.Database.Bill", b =>
                {
                    b.HasOne("eDentalist.WebAPI.Database.Appointment", "Appointment")
                        .WithMany()
                        .HasForeignKey("AppointmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Appointment");
                });

            modelBuilder.Entity("eDentalist.WebAPI.Database.City", b =>
                {
                    b.HasOne("eDentalist.WebAPI.Database.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("eDentalist.WebAPI.Database.Equipment", b =>
                {
                    b.HasOne("eDentalist.WebAPI.Database.EquipmentType", "EquipmentType")
                        .WithMany()
                        .HasForeignKey("EquipmentTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EquipmentType");
                });

            modelBuilder.Entity("eDentalist.WebAPI.Database.HygieneProcess", b =>
                {
                    b.HasOne("eDentalist.WebAPI.Database.HygieneProcessType", "HygieneProcessType")
                        .WithMany()
                        .HasForeignKey("HygieneProcessTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eDentalist.WebAPI.Database.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HygieneProcessType");

                    b.Navigation("User");
                });

            modelBuilder.Entity("eDentalist.WebAPI.Database.Rating", b =>
                {
                    b.HasOne("eDentalist.WebAPI.Database.Procedure", "Procedure")
                        .WithMany()
                        .HasForeignKey("ProcedureID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eDentalist.WebAPI.Database.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Procedure");

                    b.Navigation("User");
                });

            modelBuilder.Entity("eDentalist.WebAPI.Database.Requisition", b =>
                {
                    b.HasOne("eDentalist.WebAPI.Database.Equipment", "Equipment")
                        .WithMany()
                        .HasForeignKey("EquipmentID");

                    b.HasOne("eDentalist.WebAPI.Database.Material", "Material")
                        .WithMany()
                        .HasForeignKey("MaterialID");

                    b.HasOne("eDentalist.WebAPI.Database.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipment");

                    b.Navigation("Material");

                    b.Navigation("User");
                });

            modelBuilder.Entity("eDentalist.WebAPI.Database.User", b =>
                {
                    b.HasOne("eDentalist.WebAPI.Database.City", "City")
                        .WithMany()
                        .HasForeignKey("CityID");

                    b.HasOne("eDentalist.WebAPI.Database.Gender", "Gender")
                        .WithMany()
                        .HasForeignKey("GenderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eDentalist.WebAPI.Database.UserRole", "UserRole")
                        .WithMany()
                        .HasForeignKey("UserRoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("Gender");

                    b.Navigation("UserRole");
                });

            modelBuilder.Entity("eDentalist.WebAPI.Database.UserWorkday", b =>
                {
                    b.HasOne("eDentalist.WebAPI.Database.Shift", "Shift")
                        .WithMany()
                        .HasForeignKey("ShiftID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eDentalist.WebAPI.Database.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eDentalist.WebAPI.Database.Workday", "Workday")
                        .WithMany()
                        .HasForeignKey("WorkdayID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Shift");

                    b.Navigation("User");

                    b.Navigation("Workday");
                });
#pragma warning restore 612, 618
        }
    }
}
