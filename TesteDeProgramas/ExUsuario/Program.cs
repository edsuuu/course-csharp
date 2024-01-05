using System;

public class Usuario
{
    // Atributos públicos
    public string Nome { get; set; }
    public int Idade { get; set; }

    // Atributos privados
    private string Email;
    private string Senha;

    // Construtor para inicializar atributos privados
    public Usuario(string email, string senha)
    {
        Email = email;
        Senha = senha;
    }

    // Método público que acessa atributos privados
    public void ExibirDetalhesPrivados()
    {
        Console.WriteLine($"Email: {Email}, Senha: {Senha}");
    }
}

class Program
{
    static void Main()
    {
        // Criando um usuário
        Usuario usuario1 = new Usuario("usuario@email.com", "senha123");

        // Atribuindo valores a atributos públicos
        usuario1.Nome = "João";
        usuario1.Idade = 25;

        // Exibindo detalhes públicos e privados
        Console.WriteLine($"Nome: {usuario1.Nome}, Idade: {usuario1.Idade}");
        usuario1.ExibirDetalhesPrivados();
    }
}
