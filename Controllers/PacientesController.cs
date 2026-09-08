using Microsoft.AspNetCore.Mvc;
using ProjetoAgendamento.Data;
using ProjetoAgendamento.Models;

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

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(
        [Bind("Nome,Cpf,Telefone,Endereco,DataNascimento")] Paciente paciente)
    {
        if (!ModelState.IsValid)
        {
            return View(paciente);
        }

        _context.Pacientes.Add(paciente);
        _context.SaveChanges();

        return RedirectToAction(nameof(Index));
    }
}
