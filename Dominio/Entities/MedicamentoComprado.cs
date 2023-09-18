using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities;
    public class MedicamentoComprado: BaseEntity
    {
        public int CompraId { get; set; }
        public Compra Compra { get; set; }
        public int  MedicamentoId { get; set; }
        public Medicamento Medicamento { get; set; }
        public int CantidadComprada { get; set; }
        public double PrecioCompra { get; set; }
    }
