public class Biblioteca
{
    private List<Livro> Livros { get; set; } = new List<Livro>();
    private List<Usuario> Usuarios { get; set; } = new List<Usuario>();

    // Cadastrar um novo livro
    public void CadastrarLivro(Livro livro)
    {
        Livros.Add(livro);
        Console.WriteLine($"Livro '{livro.Titulo}' cadastrado com sucesso.");
    }

    // Cadastrar um novo usuário
    public void CadastrarUsuario(Usuario usuario)
    {
        Usuarios.Add(usuario);
        Console.WriteLine($"Usuário '{usuario.Nome}' cadastrado com sucesso.");
    }

    // Listar todos os livros cadastrados
    public void ListarLivros()
    {
        foreach (var livro in Livros)
        {
            Console.WriteLine(livro.Titulo);
        }
    }

    // Listar todos os usuários cadastrados
    public void ListarUsuarios()
    {
        foreach (var usuario in Usuarios)
        {
            Console.WriteLine(usuario.Nome);
        }
    }

    // Pesquisar livros por título
    public List<Livro> PesquisarLivrosPorTitulo(string titulo)
    {
        return Livros.Where(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    // Pesquisar livros por autor
    public List<Livro> PesquisarLivrosPorAutor(string autor)
    {
        return Livros.Where(l => l.Autor.Equals(autor, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    // Pesquisar livros por gênero
    public List<Livro> PesquisarLivrosPorGenero(string genero)
    {
        return Livros.Where(l => l.Genero.Equals(genero, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    // Pesquisar usuários por nome
    public List<Usuario> PesquisarUsuariosPorNome(string nome)
    {
        return Usuarios.Where(u => u.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    // Empréstimo de livro
    public void EmprestarLivro(string codigoLivro, string numeroUsuario)
    {
        var livro = Livros.FirstOrDefault(l => l.Codigo.Equals(codigoLivro, StringComparison.OrdinalIgnoreCase));
        var usuario = Usuarios.FirstOrDefault(u => u.NumeroIdentificacao.Equals(numeroUsuario, StringComparison.OrdinalIgnoreCase));

        if (livro == null)
        {
            Console.WriteLine("Livro não encontrado.");
            return;
        }

        if (usuario == null)
        {
            Console.WriteLine("Usuário não encontrado.");
            return;
        }

        livro.Emprestar(usuario);
    }

    // Devolução de livro
    public void DevolverLivro(string codigoLivro)
    {
        var livro = Livros.FirstOrDefault(l => l.Codigo.Equals(codigoLivro, StringComparison.OrdinalIgnoreCase));

        if (livro == null)
        {
            Console.WriteLine("Livro não encontrado.");
            return;
        }

        livro.Devolver();
    }
}
