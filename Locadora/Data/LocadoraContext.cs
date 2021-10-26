using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Locadora.Model;

namespace Locadora.Data
{
    public class LocadoraContext : DbContext
    {
        public LocadoraContext (DbContextOptions<LocadoraContext> options)
            : base(options)
        {
        }

        public DbSet<Locadora.Model.Movie> Movie { get; set; }
    }
}
