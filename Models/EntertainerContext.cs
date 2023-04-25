using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace final_rtj34.Models
{
    public class EntertainerContext : DbContext
    {
        public EntertainerContext()
        {
        }

        public EntertainerContext(DbContextOptions<EntertainerContext> options)
            : base(options)
        {
        }

        public DbSet<Entertainer> Entertainers{ get; set; }

    }
}
