using Microsoft.AspNetCore.Mvc;
using ProjetoAgendamento.Data;

namespace ProjetoAgendamento.Controllers;

public class PacientesController : Controller
{
    private readonly AppDbContext _context;

    public PacientesController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var pacientes = _context.Pacientes.ToList();
        return View(pacientes);
    }
}
