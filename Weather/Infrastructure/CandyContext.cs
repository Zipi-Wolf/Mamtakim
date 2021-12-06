using MamtakNetApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MamtakNetApp.Infrastructure
{
    public class CandyContext : DbContext
    {
        public CandyContext(DbContextOptions<CandyContext> options) : base(options)
        {
        }

        public DbSet<Candy> candies { get; set; }
        //public DbSet<Invitation> invitation { get; set; }
        //public DbSet<ItemOfInvitation> items { get; set; }

    }

}
