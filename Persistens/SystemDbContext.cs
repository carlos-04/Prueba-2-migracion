using Microsoft.EntityFrameworkCore;
using Models;
using System;

namespace Persistens
{
    public class SystemDbContext : IdentityDbContext


    {

        public SystemDbContext(DbContextOptions<SystemDbContext> options) : base(options)
        {

        }

        public DbSet<Persona> persona { get; set; }
        public DbSet<Solicitud> solicitud { get; set; }

    }
}
