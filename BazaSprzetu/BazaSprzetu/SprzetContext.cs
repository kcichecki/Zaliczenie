using BazaSprzetu.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BazaSprzetu
{
    public class SprzetContext:DbContext
    {
        public DbSet<SprzetModel> Sprzet { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptions)
        {

            var cs = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BazaSprzetu;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            dbContextOptions.UseSqlServer(cs);
        }
    }
}
