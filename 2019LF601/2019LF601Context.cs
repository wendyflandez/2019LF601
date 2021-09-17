using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2019LF601.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;



namespace _2019LF601
{
    public class _2019LF601Context : DbContext
    {
        public _2019LF601Context (DbContextOptions<_2019LF601Context> options) : base(options)
        {
        }

        public DbSet<equipos> equipos { get; set; }
        public DbSet<estados_equipo> Estados_equipo { get; set; }
        public DbSet<marcas> marcas { get; set; }
        public DbSet<tipoEquipo> tipo_equipo { get; set; }
    }
}
