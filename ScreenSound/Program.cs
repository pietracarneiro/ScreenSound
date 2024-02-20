//Projeto com orientação a objetos em C# - Tema: Música

// nome
// artista
// duração
// disponível

Musica musica1 = new Musica();
musica1.nome = "Formation";
musica1.artista = "Beyoncé";
musica1.duracao = 326;
musica1.disponivel = true;

Musica musica2 = new Musica();
musica2.nome = "Paparazzi";
musica2.artista = "Lady Gaga";
musica2.duracao = 328;
musica2.disponivel = false;

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();