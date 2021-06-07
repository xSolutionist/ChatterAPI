using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ChatterAPI.Models;

namespace ChatterAPI.Data
{
    public class ChatterAPIContext : DbContext
    {
        public ChatterAPIContext (DbContextOptions<ChatterAPIContext> options)
            : base(options)
        {
        }

        public DbSet<ChatterAPI.Models.Post> Post { get; set; }
    }
}
