
using Microsoft.EntityFrameworkCore;
using Prueba_Migraciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba_Migraciones.Persistens
{
    public class SystemDbContext : DbContext

    {
        public SystemDbContext(DbContextOptions<SystemDbContext>options): base(options)
        {

        }
        public DbSet<Persona> persona { get; set; }
        public DbSet<Solicitud> solicitud { get; set; }

    }
}
