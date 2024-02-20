//Projeto com orientação a objetos em C# - Tema: Música

// nome
// artista
// duração
// disponível

Musica musica1 = new Musica();
musica1.Nome = "Formation";
musica1.Artista = "Beyoncé";
musica1.Duracao = 326;
musica1.Disponivel = true;
//musica1.EscreveDisponivel(true);
//Console.WriteLine(musica1.LerDisponivel());

Musica musica2 = new Musica();
musica2.Nome = "Paparazzi";
musica2.Artista = "Lady Gaga";
musica2.Duracao = 328;
musica2.Disponivel = false;
//musica2.EscreveDisponivel(false);
//Console.WriteLine(musica2.LerDisponivel());

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();