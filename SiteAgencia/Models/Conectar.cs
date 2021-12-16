using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiteAgencia.Models
{
    public class Conectar: DbContext
    {
        public Conectar(DbContextOptions<Conectar> options) : base(options)
        {

        }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Destinos> Destino { get; set; }
        public DbSet<Compras> Compra { get; set; }
        public DbSet<Contato> Contato { get; set; }

    }
}
