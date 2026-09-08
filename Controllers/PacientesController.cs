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

    public IActionResult Edit(int id)
    {
        var paciente = _context.Pacientes.Find(id);

        if (paciente is null)
        {
            return NotFound();
        }

        return View(paciente);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(
        int id,
        [Bind("Id,Nome,Cpf,Telefone,Endereco,DataNascimento")] Paciente paciente)
    {
        if (id != paciente.Id)
        {
            return NotFound();
        }

        if (!ModelState.IsValid)
        {
            return View(paciente);
        }

        var pacienteExistente = _context.Pacientes.Find(id);

        if (pacienteExistente is null)
        {
            return NotFound();
        }

        pacienteExistente.Nome = paciente.Nome;
        pacienteExistente.Cpf = paciente.Cpf;
        pacienteExistente.Telefone = paciente.Telefone;
        pacienteExistente.Endereco = paciente.Endereco;
        pacienteExistente.DataNascimento = paciente.DataNascimento;

        _context.SaveChanges();

        return RedirectToAction(nameof(Index));
    }
}
