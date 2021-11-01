using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Protocols;
using RestAPI02.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI02.Data
{
    public class Context : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString:@"Server=(local)\SQLEXPRESS;Database=RestAPI02;Integrated Security = True;MultipleActiveResultSets=true");
        }
    }
}
