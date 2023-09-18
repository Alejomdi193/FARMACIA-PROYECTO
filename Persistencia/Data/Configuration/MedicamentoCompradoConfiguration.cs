using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class MedicamentoCompradoConfiguration : IEntityTypeConfiguration<MedicamentoComprado>
    {
        public void Configure(EntityTypeBuilder<MedicamentoComprado> builder)
        {
            builder.ToTable("Medicamento Comprado");

            builder.Property(p => p.)

        }
    }
}