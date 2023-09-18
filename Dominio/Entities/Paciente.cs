using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities;
    public class Paciente : BaseEntity
    {
        public string Nombre { get; set; }
        public string Telefono {get; set;}
        public string Direccion {get; set;}
        public ICollection<Venta> Ventas { get; set; }
    }
