namespace DesafioProjetoHospedagem.Models;

public class Pessoa
{
    public Pessoa()
    {
        Nome = string.Empty; // Initialize Nome to avoid nullability issues
        Sobrenome = string.Empty; // Initialize Sobrenome to avoid nullability issues
    }

    public Pessoa(string nome)
    {
        Nome = nome;
        Sobrenome = string.Empty; // Initialize Sobrenome to avoid nullability issues
    }

    public Pessoa(string nome, string sobrenome)
    {
        Nome = nome;
        Sobrenome = sobrenome;
    }

    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
}
