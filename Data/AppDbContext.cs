using Microsoft.EntityFrameworkCore;
using ProjetoAgendamento.Models;

namespace ProjetoAgendamento.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Paciente> Pacientes { get; set; }
}
