using System.Security.Cryptography;

namespace LHPet.Models;


public class Cliente
{
    public int Id { get; set; }
    public String? Nome { get; set; }
    public String? Cpf { get; set; }
    public String? Email { get; set; }
    public String? Paciente { get; set; }

    public Cliente(int id, string nome, string cpf, string email, string paciente)
    {
        this.Id = id;
        this.Nome = nome;
        this.Cpf = cpf;
        this.Email = email;
        this.Paciente = paciente;

    }

}