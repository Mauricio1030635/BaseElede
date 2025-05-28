using EledeRepaso.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EledeRepaso.Data
{
    public class EledeDBContext : DbContext
    {       

        public EledeDBContext(DbContextOptions<EledeDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Producto> Producto { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EledeDBContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }



    }
}
