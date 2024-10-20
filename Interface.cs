// interface que define métodos para os livros que podem ser emprestados
public interface IEmprestavel
{
    void Emprestar(Usuario usuario); // Método para emprestar um livro
    void Devolver(); // Método para devolver um livro
}

// interface que define métodos para pesquisa de livros
public interface IPesquisavel
{
    List<Livro> PesquisarPorTitulo(string titulo); // Pesquisa por título
    List<Livro> PesquisarPorAutor(string autor); // Pesquisa por autor
    List<Livro> PesquisarPorGenero(string genero); // Pesquisa por gênero
}
