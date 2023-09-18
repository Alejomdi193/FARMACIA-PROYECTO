using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using iText.IO.Source;

namespace Dominio.Entities;
    public class Compra : BaseEntity
    {
        public DateTime FechaCompra { get; set; }
        public int ProveedorId { get; set; }
        public Proveedor Proveedor { get; set; }
        public ICollection<MedicamentoComprado> MedicamentoComprados{ get; set; }

    }
