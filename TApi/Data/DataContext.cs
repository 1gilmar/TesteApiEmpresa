using System;
using Microsoft.EntityFrameworkCore;
using TApi.Models;

namespace TApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Patrimonio> Patrimonios { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

    }
}
