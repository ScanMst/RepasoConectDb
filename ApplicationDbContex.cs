using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUD_Estudiantes.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Estudiantes
{
    public class ApplicationDbContex : DbContext
    {
         public ApplicationDbContex(DbContextOptions options) : base(options)
        {


        }

        public DbSet<Students> Students {get; set;}
        public DbSet<Specialist> Specialists { get; set; }

    }
}