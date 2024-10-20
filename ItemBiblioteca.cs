public abstract class ItemBiblioteca
{
    
    private string titulo;
    private string codigo;

    
    public string Titulo 
    {
        get => titulo; 
        set => titulo = value; 
    }

    public string Codigo 
    {
        get => codigo; 
        set => codigo = value; 
    }

    public abstract void Emprestar(Usuario usuario);
    public abstract void Devolver();
}
