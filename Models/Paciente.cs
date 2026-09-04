using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoAgendamento.Models;

[Table("Pacientes")]
public class Paciente
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome é obrigatório.")]
    [StringLength(100, MinimumLength = 3,
        ErrorMessage = "O nome deve ter entre 3 e 100 caracteres.")]
    public string Nome { get; set; } = string.Empty;

    [Required(ErrorMessage = "O CPF é obrigatório.")]
    [StringLength(14, MinimumLength = 11,
        ErrorMessage = "O CPF deve ter entre 11 e 14 caracteres.")]
    public string Cpf { get; set; } = string.Empty;

    [Required(ErrorMessage = "O telefone é obrigatório.")]
    [StringLength(15, MinimumLength = 10,
        ErrorMessage = "O telefone deve ter entre 10 e 15 caracteres.")]
    public string Telefone { get; set; } = string.Empty;

    [Required(ErrorMessage = "O endereço é obrigatório.")]
    [StringLength(200, MinimumLength = 5,
        ErrorMessage = "O endereço deve ter entre 5 e 200 caracteres.")]
    public string Endereco { get; set; } = string.Empty;

    [Required(ErrorMessage = "A data de nascimento é obrigatória.")]
    [DataType(DataType.Date)]
    [Column(TypeName = "date")]
    public DateTime? DataNascimento { get; set; }
}
