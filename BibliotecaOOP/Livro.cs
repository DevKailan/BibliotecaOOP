
public class Livro : ItemBiblioteca
{
    public string Autor { get; set; }
    public string Isbn { get; set; }
    public string Genero { get; set; }
    public int QuantidadeEmEstoque { get; set; }

    public Livro(string autor, string isbn, string genero, int quantidadeEmEstoque, string titulo, string codigo) 
        : base(titulo, codigo)
    {
        Autor = autor;
        Isbn = isbn;
        Genero = genero;
        QuantidadeEmEstoque = quantidadeEmEstoque;
    }

    // Implementa o método Emprestar
    public override void Emprestar(Usuario usuario)
    {
        if (QuantidadeEmEstoque > 0)
        {
            QuantidadeEmEstoque--;
            usuario.AdicionarEmprestimo(Titulo);
            Console.WriteLine($"Livro '{Titulo}' emprestado para {usuario.Nome}. Estoque restante: {QuantidadeEmEstoque}");
        }
        else
        {
            Console.WriteLine($"Não há exemplares disponíveis do livro '{Titulo}'.");
        }
    }

    // Implementa o metodo Devolver
    public override void Devolver()
    {
        QuantidadeEmEstoque++;
        Console.WriteLine($"Livro '{Titulo}' devolvido. Estoque atual: {QuantidadeEmEstoque}");
    }
}
