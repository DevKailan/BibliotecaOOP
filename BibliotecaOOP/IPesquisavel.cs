
public interface IPesquisavel
{
    List<ItemBiblioteca> PesquisarPorTitulo(string titulo);
    List<ItemBiblioteca> PesquisarPorAutor(string autor);
    List<ItemBiblioteca> PesquisarPorGenero(string genero);
    List<Usuario> PesquisarPorNome(string nome);
}
