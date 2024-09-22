namespace LHPet.Models;

public class Fornecedor
{

    public int Id { get; set; }
    public String? Nome { get; set; }
    public String? Cnpj { get; set; }
    public String? Email { get; set; }

    public Fornecedor(int id, string nome, string cnpj, string email)
    {
        this.Id = id;
        this.Nome = nome;
        this.Cnpj = cnpj;
        this.Email = email;


    }

}
