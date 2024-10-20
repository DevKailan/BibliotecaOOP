// classe abstrata que serve como base para itens da biblioteca
public abstract class ItemBiblioteca
{
    // propriedades com encapsulamento, controlando o acesso aos dados
    public string Titulo { get; private set; }
    public string Codigo { get; private set; }

    // construtor que inicializa as propriedades
    public ItemBiblioteca(string titulo, string codigo)
    {
        Titulo = titulo;
        Codigo = codigo;
    }

    // métodos abstratos que devem ser implementados nas classes derivadas
    public abstract void Emprestar(Usuario usuario);
    public abstract void Devolver();
    public abstract void ExibirInformacoes();
}
