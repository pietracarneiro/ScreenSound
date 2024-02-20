class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescriçãoResumida => 
        $"A música {Nome} pertence à {Artista}";
    // Fornecendo o valor do get
    //{

    //    get
    //    {
    //        return $"A música {Nome} pertence à {Artista}";
    //    }

    //}

    //// Set manualmente
    //public void EscreveDisponivel(bool value)
    //{
    //    disponivel = value;
    //}

    //// Get manualmente
    //public bool LerDisponivel()
    //{
    //    return disponivel;
    //}

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        Console.WriteLine($"Descrição Resumida: {DescriçãoResumida}");

        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano");
        } else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }
}
