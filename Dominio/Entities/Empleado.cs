using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities
{
    public class Empleado : BaseEntity
    {
        public string Nombre{get; set;}
        public string Cargo{get; set;}
        public DateTime FechaContratacion {get; set;}
        public ICollection<Venta> Ventas { get; set; }
    }
}