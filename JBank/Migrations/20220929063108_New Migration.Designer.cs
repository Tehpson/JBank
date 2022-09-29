﻿// <auto-generated />
using System;
using JBank.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JBank.Migrations
{
    [DbContext(typeof(BankDBContext))]
    [Migration("20220929063108_New Migration")]
    partial class NewMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("JBank.Models.Account", b =>
                {
                    b.Property<string>("AccountNumber")
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<Guid?>("UserNumber")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AccountNumber");

                    b.HasIndex("UserNumber");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("JBank.Models.Loan", b =>
                {
                    b.Property<int>("LoanNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LoanNumber"), 1L, 1);

                    b.Property<double>("AmountLoaned")
                        .HasColumnType("float");

                    b.Property<double>("AmountPayedBack")
                        .HasColumnType("float");

                    b.Property<double>("LeftToPay")
                        .HasColumnType("float");

                    b.Property<double>("Rent")
                        .HasColumnType("float");

                    b.Property<Guid?>("UserNumber")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoanNumber");

                    b.HasIndex("UserNumber");

                    b.ToTable("Loans");
                });

            modelBuilder.Entity("JBank.Models.Transaction", b =>
                {
                    b.Property<int>("TransactionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransactionID"), 1L, 1);

                    b.Property<string>("AccountNumber")
                        .HasColumnType("nvarchar(14)");

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<int>("FromAccount")
                        .HasColumnType("int");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.Property<int>("ToAccount")
                        .HasColumnType("int");

                    b.HasKey("TransactionID");

                    b.HasIndex("AccountNumber");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("JBank.Models.User", b =>
                {
                    b.Property<Guid>("UserNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("AbleToTakeLoan")
                        .HasColumnType("bit");

                    b.Property<int>("AreaCode")
                        .HasColumnType("int");

                    b.HasKey("UserNumber");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("JBank.Models.Account", b =>
                {
                    b.HasOne("JBank.Models.User", null)
                        .WithMany("Accounts")
                        .HasForeignKey("UserNumber");
                });

            modelBuilder.Entity("JBank.Models.Loan", b =>
                {
                    b.HasOne("JBank.Models.User", null)
                        .WithMany("Loans")
                        .HasForeignKey("UserNumber");
                });

            modelBuilder.Entity("JBank.Models.Transaction", b =>
                {
                    b.HasOne("JBank.Models.Account", null)
                        .WithMany("Transactions")
                        .HasForeignKey("AccountNumber");
                });

            modelBuilder.Entity("JBank.Models.Account", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("JBank.Models.User", b =>
                {
                    b.Navigation("Accounts");

                    b.Navigation("Loans");
                });
#pragma warning restore 612, 618
        }
    }
}