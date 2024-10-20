// classe Livro herda de ItemBiblioteca e usa as interfaces IEmprestavel e IPesquisavel
public class Livro : ItemBiblioteca, IEmprestavel, IPesquisavel
{
    // Propriedades específicas da classe Livro com encapsulamento
    public string Autor { get; private set; }
    public string ISBN { get; private set; }
    public string Genero { get; private set; }
    public int QuantidadeEmEstoque { get; private set; }

    // Construtor que chama o construtor da classe ItemBiblioteca
    public Livro(string titulo, string codigo, string autor, string isbn, string genero, int quantidadeEmEstoque)
        : base(titulo, codigo)
    {
        Autor = autor;
        ISBN = isbn;
        Genero = genero;
        QuantidadeEmEstoque = quantidadeEmEstoque;
    }

    // implementação do método Emprestar da classe ItemBiblioteca
    public override void Emprestar(Usuario usuario)
    {
        if (QuantidadeEmEstoque > 0)
        {
            QuantidadeEmEstoque--; 
            Console.WriteLine($"Livro '{Titulo}' emprestado para {usuario.Nome}.");
        }
        else
        {
            Console.WriteLine($"Não há exemplares disponíveis do livro '{Titulo}'.");
        }
    }

    // implementação do método Devolver da classe ItemBiblioteca
    public override void Devolver()
    {
        QuantidadeEmEstoque++; // Incrementa a quantidade em estoque
        Console.WriteLine($"Livro '{Titulo}' devolvido.");
    }

    // polimorfismo sobrescrevendo o método ExibirInformacoes da classe ItemBiblioteca
    public override void ExibirInformacoes()
    {
        // chamando o método da classe ItemBiblioteca
        base.ExibirInformacoes();
        // exibe informações específicas do livro
        Console.WriteLine($"Autor: {Autor}");
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine($"Gênero: {Genero}");
        Console.WriteLine($"Quantidade em Estoque: {QuantidadeEmEstoque}");
    }

    // Implementando a interface IPesquisavel
    public List<Livro> PesquisarPorTitulo(string titulo) =>
        Titulo.Equals(titulo) ? new List<Livro> { this } : new List<Livro>();

    public List<Livro> PesquisarPorAutor(string autor) =>
        Autor.Equals(autor) ? new List<Livro> { this } : new List<Livro>();

    public List<Livro> PesquisarPorGenero(string genero) =>
        Genero.Equals(genero) ? new List<Livro> { this } : new List<Livro>();
}
