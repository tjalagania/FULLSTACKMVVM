using Microsoft.EntityFrameworkCore;
using SimpleTrader.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTracer.EntityFramework
{
    public class SimpleTracerDbContext:DbContext
    {
        public SimpleTracerDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User>? Users { get; set; }
        public DbSet<Account>? Accounts { get; set; }
        public DbSet<AssetTransaction>? AssetTransactions { get; set; }
        public DbSet<Stock>? Stocks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AssetTransaction>().OwnsOne(e => e.Stock);
            base.OnModelCreating(modelBuilder);
        }
       
    }
}
