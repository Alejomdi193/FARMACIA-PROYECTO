using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities;
    public class Proveedor : BaseEntity
    {
        public string Nombre{get; set;}
        public double Contacto {get; set;}
        public string Direccion {get; set;}
        public ICollection<Compra> Compras {get; set;}
        public ICollection<Medicamento> Medicamentos {get; set;}
    }
