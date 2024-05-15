using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AppEventos;

    public class DBContext : DbContext
    {
        public DBContext (DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public DbSet<AppEventos.Evento> Eventos { get; set; } = default!;
        public DbSet<AppEventos.Asistente> Asistentes { get; set; } = default!;
    }
