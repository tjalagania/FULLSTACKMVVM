using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTracer.EntityFramework
{
    public class DesignDbContextFactory : IDesignTimeDbContextFactory<SimpleTracerDbContext>
    {
        public SimpleTracerDbContext CreateDbContext(string[] args = null)
        {
            var options = new DbContextOptionsBuilder<SimpleTracerDbContext>();
            options.UseSqlite("Data source = mydb.db");
            return new SimpleTracerDbContext(options.Options);

        }
    }
}
