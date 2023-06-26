
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
namespace TocoYVoy 
{
    internal class ClaseIntermedia : DbContext
    {

        public DbSet<Jugador> Jugadores { get; set; }
        public DbSet<Partido> Partidos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder
       optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=DESKTOP-9Q8T18R\SQLEXPRESS01;Database=SchoolDBCF
;Trusted_Connection=True;");
        }

        //    DESKTOP-9Q8T18R\SQLEXPRESS01
    }
}