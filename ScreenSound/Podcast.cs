class Podcast
{
    public List<Episodio> Episodios = new();

    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    public string Host { get; }
    public string Nome { get; }
    public int TotalEpisodios => Episodios.Count;

    public void AdicionarEpisodio(Episodio episodio)
    {
        Episodios.Add(episodio);
    } 

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast {Nome} apresentado por {Host}");
        foreach (Episodio episodio in Episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"\n\nTotal de episódios: {TotalEpisodios}");
    }
}
