using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class EmpleadoConfiguration : IEntityTypeConfiguration<Empleado>
    {
        public void Configure(EntityTypeBuilder<Empleado> builder)
        {
            builder.ToTable("Empleado");

            builder.Property(p => p.Nombre)
            .HasColumnName("Nombre")
            .HasColumnType("varchar")
            .IsRequired()
            .HasMaxLength(150);

            builder.Property(p => p.Cargo)
            .HasColumnName("Cargo")
            .HasColumnType("varchar")
            .IsRequired()
            .HasMaxLength(150);

            builder.Property(p => p.FechaContratacion)
            .HasColumnName("Fecha Contratacion")
            .HasColumnType("DateTime")
            .IsRequired()
            .HasMaxLength(150);

        }
    }
}