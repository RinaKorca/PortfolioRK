using Microsoft.EntityFrameworkCore;
using PortfolioRK.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioRK.Database
{
    public class PortfolioRKContext : DbContext
    {
        public PortfolioRKContext(DbContextOptions<PortfolioRKContext> options) : base(options)
        {

        }


        public DbSet<Repository> Repositories { get; set; }
    }
}
