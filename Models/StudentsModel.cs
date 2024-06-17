using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Estudiantes.Models
{
    public class StudentsModel 
    {
        public StudentsModel()
        {
        }
        public string? Nombre {get; set;}
        public Guid Id {get; set;}
        public string? Apellido {get; set;}
        public int Tetra  {get ; set ;}
        public decimal Cuota {get; set;}
    }
}