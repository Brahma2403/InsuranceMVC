﻿// <auto-generated />
using System;
using InsuranceMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InsuranceMVC.Migrations
{
    [DbContext(typeof(InsuranceDbContext))]
    [Migration("20250320123213_Insurance")]
    partial class Insurance
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("InsuranceMVC.Models.Claim", b =>
                {
                    b.Property<int>("ClaimId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClaimId"));

                    b.Property<double>("ClaimAmount")
                        .HasColumnType("float");

                    b.Property<string>("ClaimStatus")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("PolicyId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("SettlementDate")
                        .HasColumnType("date");

                    b.Property<DateOnly>("SubmissionDate")
                        .HasColumnType("date");

                    b.HasKey("ClaimId");

                    b.HasIndex("PolicyId");

                    b.ToTable("Claims");
                });

            modelBuilder.Entity("InsuranceMVC.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("CustomerId1")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("CustomerId");

                    b.HasIndex("CustomerId1");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("InsuranceMVC.Models.Policy", b =>
                {
                    b.Property<int>("PolicyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PolicyId"));

                    b.Property<double>("CoverageAmount")
                        .HasColumnType("float");

                    b.Property<int?>("PolicyId1")
                        .HasColumnType("int");

                    b.Property<string>("PolicyType")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("PremiumAmount")
                        .HasColumnType("float");

                    b.Property<DateOnly>("ValidityEndDate")
                        .HasColumnType("date");

                    b.Property<DateOnly>("ValidityStartDate")
                        .HasColumnType("date");

                    b.HasKey("PolicyId");

                    b.HasIndex("PolicyId1");

                    b.ToTable("Policies");
                });

            modelBuilder.Entity("InsuranceMVC.Models.PremiumCalculation", b =>
                {
                    b.Property<int>("CalculationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CalculationId"));

                    b.Property<double>("AdjustedPremium")
                        .HasColumnType("float");

                    b.Property<double>("BasePremium")
                        .HasColumnType("float");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("PolicyId")
                        .HasColumnType("int");

                    b.HasKey("CalculationId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("PolicyId");

                    b.ToTable("PremiumCalculations");
                });

            modelBuilder.Entity("InsuranceMVC.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("InsuranceMVC.Models.Claim", b =>
                {
                    b.HasOne("InsuranceMVC.Models.Policy", "Policy")
                        .WithMany()
                        .HasForeignKey("PolicyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Policy");
                });

            modelBuilder.Entity("InsuranceMVC.Models.Customer", b =>
                {
                    b.HasOne("InsuranceMVC.Models.Customer", null)
                        .WithMany("Customers")
                        .HasForeignKey("CustomerId1");
                });

            modelBuilder.Entity("InsuranceMVC.Models.Policy", b =>
                {
                    b.HasOne("InsuranceMVC.Models.Policy", null)
                        .WithMany("Policies")
                        .HasForeignKey("PolicyId1");
                });

            modelBuilder.Entity("InsuranceMVC.Models.PremiumCalculation", b =>
                {
                    b.HasOne("InsuranceMVC.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InsuranceMVC.Models.Policy", "Policy")
                        .WithMany()
                        .HasForeignKey("PolicyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Policy");
                });

            modelBuilder.Entity("InsuranceMVC.Models.Customer", b =>
                {
                    b.Navigation("Customers");
                });

            modelBuilder.Entity("InsuranceMVC.Models.Policy", b =>
                {
                    b.Navigation("Policies");
                });
#pragma warning restore 612, 618
        }
    }
}
