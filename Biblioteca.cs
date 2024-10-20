// classe que representa a biblioteca e gerencia livros e os usuários
public class Biblioteca
{
    // listas para armazenar livros e usuários
    private List<Livro> Livros { get; set; } = new List<Livro>();
    private List<Usuario> Usuarios { get; set; } = new List<Usuario>();

    // método que cadastra um novo livro
    public void CadastrarLivro(Livro livro)
    {
        Livros.Add(livro);
        Console.WriteLine($"Livro '{livro.Titulo}' cadastrado com sucesso.");
    }

    //  método para cadastrar um novo usuário
    public void CadastrarUsuario(Usuario usuario)
    {
        Usuarios.Add(usuario);
        Console.WriteLine($"Usuário '{usuario.Nome}' cadastrado com sucesso.");
    }

    // método para listar todos os livros
    public void ListarLivros()
    {
        Console.WriteLine("Livros cadastrados:");
        foreach (var livro in Livros)
        {
            livro.ExibirInformacoes();
            Console.WriteLine();
        }
    }

    // método para listar os usuários
    public void ListarUsuarios()
    {
        Console.WriteLine("Usuários cadastrados:");
        foreach (var usuario in Usuarios)
        {
            usuario.ExibirInformacoes();
            Console.WriteLine();
        }
    }

    // método para gerenciar empréstimo dos livros
    public void EmprestarLivro(string codigoLivro, string numeroUsuario)
    {
        var livro = Livros.Find(l => l.Codigo.Equals(codigoLivro));
        var usuario = Usuarios.Find(u => u.NumeroIdentificacao.Equals(numeroUsuario));

        if (livro != null && usuario != null)
        {
            livro.Emprestar(usuario);
        }
        else
        {
            Console.WriteLine("Livro ou usuário não encontrado.");
        }
    }

    // método para gerenciar devolução dos livros
    public void DevolverLivro(string codigoLivro)
    {
        var livro = Livros.Find(l => l.Codigo.Equals(codigoLivro));

        if (livro != null)
        {
            livro.Devolver();
        }
        else
        {
            Console.WriteLine("Livro não encontrado.");
        }
    }
}
