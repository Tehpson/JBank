﻿// <auto-generated />
using System;
using JBank.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JBank.Migrations
{
    [DbContext(typeof(BankDBContext))]
    partial class BankDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("JBank.Models.Account", b =>
                {
                    b.Property<int>("AccountNumber")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(12)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountNumber"), 1L, 1);

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<int?>("UserNumber")
                        .HasColumnType("int");

                    b.HasKey("AccountNumber");

                    b.HasIndex("UserNumber");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("JBank.Models.Loan", b =>
                {
                    b.Property<long>("LoanNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("LoanNumber"), 1L, 1);

                    b.Property<double>("AmountLoaned")
                        .HasColumnType("float");

                    b.Property<double>("AmountPayedBack")
                        .HasColumnType("float");

                    b.Property<double>("LeftToPay")
                        .HasColumnType("float");

                    b.Property<double>("Rent")
                        .HasColumnType("float");

                    b.Property<int?>("UserNumber")
                        .HasColumnType("int");

                    b.HasKey("LoanNumber");

                    b.HasIndex("UserNumber");

                    b.ToTable("Loan");
                });

            modelBuilder.Entity("JBank.Models.Transaction", b =>
                {
                    b.Property<int>("TransactionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransactionID"), 1L, 1);

                    b.Property<int?>("AccountNumber")
                        .HasColumnType("int");

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

                    b.ToTable("Transaction");
                });

            modelBuilder.Entity("JBank.Models.User", b =>
                {
                    b.Property<int>("UserNumber")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserNumber"), 1L, 1);

                    b.Property<bool>("AbleToTakeLoan")
                        .HasColumnType("bit");

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
                        .WithMany("Loan")
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

                    b.Navigation("Loan");
                });
#pragma warning restore 612, 618
        }
    }
}
