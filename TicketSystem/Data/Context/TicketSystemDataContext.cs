using System;
using System.Reflection;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace TicketSystem.Data.Context
{
    public class TicketSystemDataContext : DbContext
    {
        public TicketSystemDataContext(
            DbContextOptions<TicketSystemDataContext> options
        ) :
            base(options)
        {
        }

        public DbSet<Rezervation> Rezervation { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder
                .ApplyConfigurationsFromAssembly(Assembly
                    .GetExecutingAssembly());
            
            builder.Entity<Rezervation>().Property(x => x.Isim).HasColumnType("varchar(200)");
            builder.Entity<Rezervation>().Property(x => x.SoyIsim).HasColumnType("varchar(200)");
            builder.Entity<Rezervation>().Property(x => x.PnrNo).HasColumnType("varchar(50)");
            builder.Entity<Rezervation>().Property(x => x.KoltukNo).HasColumnType("varchar(10)");
            builder.Entity<Rezervation>().Property(x => x.Guzergah).HasColumnType("varchar(500)");
            
                    
        }
    }
}
