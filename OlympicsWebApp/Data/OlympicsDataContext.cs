using Microsoft.EntityFrameworkCore;
using OlympicsWebApp.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlympicsWebApp.Data
{
    public class OlympicsDataContext : DbContext
    {
        public OlympicsDataContext(DbContextOptions<OlympicsDataContext> options)
            : base(options)
        {
        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<Coach> Coaches { get; set; }
        public DbSet<Medal> Medals { get; set; }
    }
}
