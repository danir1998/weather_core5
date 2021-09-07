using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FetchConsole.Data
{
    class WeatherContext : DbContext
    {
        //public WeatherContext(DbContextOptions<WeatherContext> options) : base(options)
        //{
        //    Database.EnsureCreated();
        //}

        public WeatherContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=WeatherState;Trusted_Connection=True;");
        }

        public DbSet<Weather> Weathers { get; set; }
    }
}
