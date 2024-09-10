using SEGURA_ASSETMENTS.Models;
using Microsoft.EntityFrameworkCore;

namespace SEGURA_ASSETMENTS.Data
{
    public class SEGURA_ASSETMENTSContext : DbContext
    {
        public SEGURA_ASSETMENTSContext(DbContextOptions<SEGURA_ASSETMENTSContext> options) : base(options)
        {

        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Habitacion> Habitaciones { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Sede> Sedes { get; set; }
        public DbSet<Tarifa> Tarifas { get; set; }

    }
}