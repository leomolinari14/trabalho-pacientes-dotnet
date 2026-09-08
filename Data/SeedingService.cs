using ProjetoAgendamento.Models;

namespace ProjetoAgendamento.Data;

public class SeedingService
{
    private readonly AppDbContext _context;

    public SeedingService(AppDbContext context)
    {
        _context = context;
    }

    public void Popula()
    {
        if (_context.Pacientes.Any())
        {
            return;
        }

        var paciente1 = new Paciente
        {
            Nome = "Ana Souza",
            Cpf = "111.111.111-11",
            Telefone = "(11) 99999-1111",
            Endereco = "Rua das Flores, 100",
            DataNascimento = new DateTime(1990, 5, 15)
        };

        var paciente2 = new Paciente
        {
            Nome = "Carlos Lima",
            Cpf = "222.222.222-22",
            Telefone = "(11) 98888-2222",
            Endereco = "Avenida Central, 250",
            DataNascimento = new DateTime(1985, 10, 20)
        };

        _context.Pacientes.AddRange(paciente1, paciente2);
        _context.SaveChanges();
    }
}
