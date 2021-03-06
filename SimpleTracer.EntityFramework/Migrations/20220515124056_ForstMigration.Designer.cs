// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SimpleTracer.EntityFramework;

#nullable disable

namespace SimpleTracer.EntityFramework.Migrations
{
    [DbContext(typeof(SimpleTracerDbContext))]
    [Migration("20220515124056_ForstMigration")]
    partial class ForstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.5");

            modelBuilder.Entity("SimpleTrader.Domain.Models.Account", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AccountholderID")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Balance")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("AccountholderID");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("SimpleTrader.Domain.Models.AssetTransaction", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccountID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateProcessed")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsPurchase")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Share")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("AccountID");

                    b.ToTable("AssetTransactions");
                });

            modelBuilder.Entity("SimpleTrader.Domain.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateJoined")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SimpleTrader.Domain.Models.Account", b =>
                {
                    b.HasOne("SimpleTrader.Domain.Models.User", "Accountholder")
                        .WithMany()
                        .HasForeignKey("AccountholderID");

                    b.Navigation("Accountholder");
                });

            modelBuilder.Entity("SimpleTrader.Domain.Models.AssetTransaction", b =>
                {
                    b.HasOne("SimpleTrader.Domain.Models.Account", "Account")
                        .WithMany("AssetTransactions")
                        .HasForeignKey("AccountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("SimpleTrader.Domain.Models.Stock", "Stock", b1 =>
                        {
                            b1.Property<int>("AssetTransactionID")
                                .HasColumnType("INTEGER");

                            b1.Property<decimal>("PricePerShare")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Symbol")
                                .HasColumnType("TEXT");

                            b1.HasKey("AssetTransactionID");

                            b1.ToTable("Stocks");

                            b1.WithOwner()
                                .HasForeignKey("AssetTransactionID");
                        });

                    b.Navigation("Account");

                    b.Navigation("Stock")
                        .IsRequired();
                });

            modelBuilder.Entity("SimpleTrader.Domain.Models.Account", b =>
                {
                    b.Navigation("AssetTransactions");
                });
#pragma warning restore 612, 618
        }
    }
}
