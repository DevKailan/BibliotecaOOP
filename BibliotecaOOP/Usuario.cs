
public class Usuario
{
    public string Nome { get; set; }
    public string NumeroIdentificacao { get; set; }
    public string Endereco { get; set; }
    public string Contato { get; set; }

    private List<string> HistoricoEmprestimos { get; set; }

    public Usuario(string nome, string numeroIdentificacao, string endereco, string contato)
    {
        Nome = nome;
        NumeroIdentificacao = numeroIdentificacao;
        Endereco = endereco;
        Contato = contato;
        HistoricoEmprestimos = new List<string>();
    }

    // Exibi as informações do usuário
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}\nNúmero de Identificação: {NumeroIdentificacao}\nEndereço: {Endereco}\nContato: {Contato}");
    }

    // Exibi o histórico de empréstimos
    public void ExibirHistorico()
    {
        if (HistoricoEmprestimos.Count > 0)
        {
            Console.WriteLine("Histórico de Empréstimos:");
            foreach (var emprestimo in HistoricoEmprestimos)
            {
                Console.WriteLine($"- {emprestimo}");
            }
        }
        else
        {
            Console.WriteLine("Nenhum empréstimo encontrado no histórico.");
        }
    }

    // Adiciona o empréstimo ao histórico
    public void AdicionarEmprestimo(string tituloLivro)
    {
        HistoricoEmprestimos.Add(tituloLivro);
    }
}
