using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TripcallC.Models;

namespace TripcallC.Data
{
    public class TripcallCContext : DbContext
    {
        public TripcallCContext (DbContextOptions<TripcallCContext> options)
            : base(options)
        {
        }

        public DbSet<TripcallC.Models.UsuarioModel> UsuarioModel { get; set; } = default!;
    }
}
