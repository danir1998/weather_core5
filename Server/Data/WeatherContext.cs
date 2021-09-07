using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorClient.Shared;

namespace BlazorClient.Server.Data
{
    public class WeatherContext : DbContext
    {
        public WeatherContext(DbContextOptions<WeatherContext> options) : base (options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Weather> Weathers { get; set; }
    }
}
