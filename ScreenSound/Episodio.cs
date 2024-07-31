class Episodio
{
    public List<string> Convidados = new();
    public Episodio(int ordem, int duracao, string titulo)
    {
        Ordem = ordem;
        Duracao = duracao;
        Titulo = titulo;
    }

    public int Ordem { get; }
    public int Duracao { get; }
    public string Titulo { get; }
    public string Resumo => $"{Ordem}. {Titulo} ({Duracao} min) - {string.Join(", ", Convidados)}";

    public void AdicionarConvidados(string convidado) 
    { 
        Convidados.Add(convidado);
    }
}