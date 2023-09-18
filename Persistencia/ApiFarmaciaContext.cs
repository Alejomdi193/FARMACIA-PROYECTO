using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistencia;

    public class ApiFarmaciaContext : DbContext 
    {
    public ApiFarmaciaContext(DbContextOptions options) : base(options)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

    }
    
    public DbSet<Compra> Compras { get; set; }
    public DbSet<Venta> Ventas { get; set; }
    public DbSet<Medicamento> Medicamentos { get; set; }
    public DbSet<MedicamentoComprado> MedicamentoComprados { get; set; }
    public DbSet<MedicamentoVendido> MedicamentoVendidos { get; set; }
    public DbSet<Paciente> Pacientes { get; set; }
    public DbSet<Proveedor> Proveedores { get; set; }

    }
    
