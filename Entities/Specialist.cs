using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Estudiantes.Entities
{
    public class Specialist
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string Major { get; set; }

        //public List<Patient> Patients { get; set;}
    }
}