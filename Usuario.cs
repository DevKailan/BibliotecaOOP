public class Usuario
{
    public string Nome { get; set; } 
    public int NumeroDeIdentificacao { get; set; }

    public string Endereco { get; set; }
    
    public int Contato { get; set; }

    public List<string> HistoricoEmprestimos { get; set; } = new List<string>();

    public void ExibirInformacoes()

    {
        Console.WriteLine($"Nome: {Nome}");
    }



}