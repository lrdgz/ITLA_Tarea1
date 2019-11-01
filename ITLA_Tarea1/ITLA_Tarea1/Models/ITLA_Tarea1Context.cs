using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ITLA_Tarea1.Models
{
    public class ITLA_Tarea1Context : DbContext
    {
        public ITLA_Tarea1Context() : base("DefaultConnection"){}
        public DbSet<Division> Divisions { get; set; }
        public DbSet<Equipo> Equipos { get; set; }

    }
}