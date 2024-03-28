﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PayrollManagement.Back.Infraestructure.Data;

#nullable disable

namespace PayrollManagement.Back.Infraestructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("PayrollManagement.Back.Business.Models.City", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Code3")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("CreatedById")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("RegionId")
                        .HasColumnType("bigint");

                    b.Property<long?>("UpdatedById")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("RegionId");

                    b.ToTable("City");
                });

            modelBuilder.Entity("PayrollManagement.Back.Business.Models.Company", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("CityId")
                        .HasColumnType("bigint");

                    b.Property<long>("CreatedById")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Document")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long?>("UpdatedById")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("PayrollManagement.Back.Business.Models.CostCenter", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("CompanyId")
                        .HasColumnType("bigint");

                    b.Property<string>("CostCenterCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("CreatedById")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<TimeSpan>("EntryHourCC")
                        .HasColumnType("interval");

                    b.Property<TimeSpan>("ExitHourCC")
                        .HasColumnType("interval");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("ParentId")
                        .HasColumnType("bigint");

                    b.Property<long?>("UpdatedById")
                        .HasColumnType("bigint");

                    b.Property<long?>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("CostCenter");
                });

            modelBuilder.Entity("PayrollManagement.Back.Business.Models.ParametrizationNovelty", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("CreatedById")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("FinalPosition")
                        .HasColumnType("integer");

                    b.Property<int>("InitialPosition")
                        .HasColumnType("integer");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<int>("Justification")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("NoveltyLength")
                        .HasColumnType("integer");

                    b.Property<string>("NoveltyName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long?>("UpdatedById")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("ParametrizationNovelty");
                });

            modelBuilder.Entity("PayrollManagement.Back.Business.Models.PayrollNovelty", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("CreatedById")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("DaysDurationNotWorking")
                        .HasColumnType("integer");

                    b.Property<int>("Duration")
                        .HasColumnType("integer");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("InitialDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("NoveltyDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("ProcessedInFile")
                        .HasColumnType("boolean");

                    b.Property<long>("SiesaConceptId")
                        .HasColumnType("bigint");

                    b.Property<long?>("UpdatedById")
                        .HasColumnType("bigint");

                    b.Property<long?>("UserActivityId")
                        .HasColumnType("bigint");

                    b.Property<long>("UserInfoId")
                        .HasColumnType("bigint");

                    b.Property<decimal>("ValueNovelty")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("SiesaConceptId");

                    b.HasIndex("UserActivityId");

                    b.HasIndex("UserInfoId");

                    b.ToTable("PayrollNovelty");
                });

            modelBuilder.Entity("PayrollManagement.Back.Business.Models.PayrollType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("CreatedById")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("DaysPayment")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Nomenclature")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TypePayroll")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long?>("UpdatedById")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("PayrollType");
                });

            modelBuilder.Entity("PayrollManagement.Back.Business.Models.PlainTextFile", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("CreatedById")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DateUpload")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Period")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long?>("UpdatedById")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("PlainTextFile");
                });

            modelBuilder.Entity("PayrollManagement.Back.Business.Models.PlainTextFileRecord", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("CreatedById")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("PlainTextFileId")
                        .HasColumnType("bigint");

                    b.Property<bool>("ProcessedRecord")
                        .HasColumnType("boolean");

                    b.Property<string>("Record")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long?>("UpdatedById")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("PlainTextFileId");

                    b.ToTable("PlainTextFileRecord");
                });

            modelBuilder.Entity("PayrollManagement.Back.Business.Models.Region", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Code3")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("CreatedById")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long?>("UpdatedById")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Region");
                });

            modelBuilder.Entity("PayrollManagement.Back.Business.Models.Role", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("CreatedById")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long?>("UpdatedById")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("PayrollManagement.Back.Business.Models.SiesaConcept", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Abbreviation")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ConceptCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("CreatedById")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("LiquidationMode")
                        .HasColumnType("integer");

                    b.Property<string>("LiquidationModeDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("TypeNovelty")
                        .HasColumnType("integer");

                    b.Property<long?>("UpdatedById")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("SiesaConcept");
                });

            modelBuilder.Entity("PayrollManagement.Back.Business.Models.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("CompanyId")
                        .HasColumnType("bigint");

                    b.Property<long?>("CostCenterId")
                        .HasColumnType("bigint");

                    b.Property<long>("CreatedById")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.Property<long?>("UpdatedById")
                        .HasColumnType("bigint");

                    b.Property<long?>("UserInfoId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("CostCenterId")
                        .IsUnique();

                    b.HasIndex("RoleId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("PayrollManagement.Back.Business.Models.UserActivity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("CreatedById")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DateActivity")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Observation")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("TypeActivity")
                        .HasColumnType("integer");

                    b.Property<long?>("UpdatedById")
                        .HasColumnType("bigint");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<long>("WorkerId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("WorkerId");

                    b.ToTable("UserActivity");
                });

            modelBuilder.Entity("PayrollManagement.Back.Business.Models.UserInfo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("CityId")
                        .HasColumnType("bigint");

                    b.Property<long>("CreatedById")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("EntryDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<TimeSpan>("EntryHour")
                        .HasColumnType("interval");

                    b.Property<TimeSpan>("ExitHour")
                        .HasColumnType("interval");

                    b.Property<int>("Genre")
                        .HasColumnType("integer");

                    b.Property<string>("IdentificationNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("IdentificationType")
                        .HasColumnType("integer");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long?>("PayrollTypeId")
                        .HasColumnType("bigint");

                    b.Property<long>("PhoneNumber")
                        .HasColumnType("bigint");

                    b.Property<decimal?>("Salary")
                        .HasColumnType("numeric");

                    b.Property<long?>("UpdatedById")
                        .HasColumnType("bigint");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long?>("UserId")
                        .HasColumnType("bigint");

                    b.Property<long?>("WorkerId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("PayrollTypeId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.HasIndex("WorkerId")
                        .IsUnique();

                    b.ToTable("UserInfo");
                });

            modelBuilder.Entity("PayrollManagement.Back.Business.Models.Worker", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("CompanyId")
                        .HasColumnType("bigint");

                    b.Property<long?>("CostCenterId")
                        .HasColumnType("bigint");

                    b.Property<long>("CreatedById")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("UpdatedById")
                        .HasColumnType("bigint");

                    b.Property<long?>("UserInfoId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("CostCenterId");

                    b.ToTable("Worker");
                });

            modelBuilder.Entity("PayrollManagement.Back.Business.Models.City", b =>
                {
                    b.HasOne("PayrollManagement.Back.Business.Models.Region", "Region")
                        .WithMany()
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Region");
                });

            modelBuilder.Entity("PayrollManagement.Back.Business.Models.Company", b =>
                {
                    b.HasOne("PayrollManagement.Back.Business.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("PayrollManagement.Back.Business.Models.CostCenter", b =>
                {
                    b.HasOne("PayrollManagement.Back.Business.Models.Company", "Company")
                        .WithMany("CostCenters")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("PayrollManagement.Back.Business.Models.PayrollNovelty", b =>
                {
                    b.HasOne("PayrollManagement.Back.Business.Models.SiesaConcept", "SiesaConcept")
                        .WithMany()
                        .HasForeignKey("SiesaConceptId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PayrollManagement.Back.Business.Models.UserActivity", "UserActivity")
                        .WithMany()
                        .HasForeignKey("UserActivityId");

                    b.HasOne("PayrollManagement.Back.Business.Models.UserInfo", "UserInfo")
                        .WithMany()
                        .HasForeignKey("UserInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SiesaConcept");

                    b.Navigation("UserActivity");

                    b.Navigation("UserInfo");
                });

            modelBuilder.Entity("PayrollManagement.Back.Business.Models.PlainTextFileRecord", b =>
                {
                    b.HasOne("PayrollManagement.Back.Business.Models.PlainTextFile", "PlainTextFile")
                        .WithMany("PlainTextFileRecords")
                        .HasForeignKey("PlainTextFileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PlainTextFile");
                });

            modelBuilder.Entity("PayrollManagement.Back.Business.Models.User", b =>
                {
                    b.HasOne("PayrollManagement.Back.Business.Models.Company", "Company")
                        .WithMany("Users")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PayrollManagement.Back.Business.Models.CostCenter", "CostCenter")
                        .WithOne("User")
                        .HasForeignKey("PayrollManagement.Back.Business.Models.User", "CostCenterId");

                    b.HasOne("PayrollManagement.Back.Business.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("CostCenter");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("PayrollManagement.Back.Business.Models.UserActivity", b =>
                {
                    b.HasOne("PayrollManagement.Back.Business.Models.User", "User")
                        .WithMany("UserActivities")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PayrollManagement.Back.Business.Models.Worker", "Worker")
                        .WithMany("UserActivities")
                        .HasForeignKey("WorkerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("Worker");
                });

            modelBuilder.Entity("PayrollManagement.Back.Business.Models.UserInfo", b =>
                {
                    b.HasOne("PayrollManagement.Back.Business.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PayrollManagement.Back.Business.Models.PayrollType", "PayrollType")
                        .WithMany()
                        .HasForeignKey("PayrollTypeId");

                    b.HasOne("PayrollManagement.Back.Business.Models.User", "User")
                        .WithOne("UserInfo")
                        .HasForeignKey("PayrollManagement.Back.Business.Models.UserInfo", "UserId");

                    b.HasOne("PayrollManagement.Back.Business.Models.Worker", "Worker")
                        .WithOne("UserInfo")
                        .HasForeignKey("PayrollManagement.Back.Business.Models.UserInfo", "WorkerId");

                    b.Navigation("City");

                    b.Navigation("PayrollType");

                    b.Navigation("User");

                    b.Navigation("Worker");
                });

            modelBuilder.Entity("PayrollManagement.Back.Business.Models.Worker", b =>
                {
                    b.HasOne("PayrollManagement.Back.Business.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PayrollManagement.Back.Business.Models.CostCenter", "CostCenter")
                        .WithMany("Workers")
                        .HasForeignKey("CostCenterId");

                    b.Navigation("Company");

                    b.Navigation("CostCenter");
                });

            modelBuilder.Entity("PayrollManagement.Back.Business.Models.Company", b =>
                {
                    b.Navigation("CostCenters");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("PayrollManagement.Back.Business.Models.CostCenter", b =>
                {
                    b.Navigation("User")
                        .IsRequired();

                    b.Navigation("Workers");
                });

            modelBuilder.Entity("PayrollManagement.Back.Business.Models.PlainTextFile", b =>
                {
                    b.Navigation("PlainTextFileRecords");
                });

            modelBuilder.Entity("PayrollManagement.Back.Business.Models.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("PayrollManagement.Back.Business.Models.User", b =>
                {
                    b.Navigation("UserActivities");

                    b.Navigation("UserInfo")
                        .IsRequired();
                });

            modelBuilder.Entity("PayrollManagement.Back.Business.Models.Worker", b =>
                {
                    b.Navigation("UserActivities");

                    b.Navigation("UserInfo")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
