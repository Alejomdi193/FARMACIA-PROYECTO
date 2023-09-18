using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities;
    public class Venta : BaseEntity
    {
        public DateTime FechaVenta { get; set; }
        public int PacienteId { get; set; }
        public Paciente Paciente{ get; set; }
        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }
        public ICollection<MedicamentoVendido> MedicamentoVendidos { get; set; }

    }
