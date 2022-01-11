using Hassan_257.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hassan_257.Data
{
    public class SContext: DbContext
    {
        public SContext(DbContextOptions<SContext> options) : base(options)
        {
        }
        public DbSet<Omodel> OModels { get; set; }

    }
}
