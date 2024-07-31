using ScreenSound;

// Exemplos de Album, Música e Artista
Console.WriteLine("******** Músicas ********\n");

Artista beyonce = new Artista("Beyonce");

Album albumDaBeyonce = new Album("Renaissance");

Musica musica1 = new Musica(beyonce, "I'M THAT GIRL");
musica1.Duracao = 328;

Musica musica2 = new Musica(beyonce, "COZY");
musica2.Duracao = 330;

Musica musica3 = new Musica(beyonce, "ALIEN SUPERSTAR");
musica3.Duracao = 339;

Musica musica4 = new Musica(beyonce, "CUFF IT");
musica4.Duracao = 348;

Musica musica5 = new Musica(beyonce, "ENERGY (feat. BEAM)");
musica5.Duracao = 317;

Musica musica6 = new Musica(beyonce, "BREAK MY SOUL");
musica6.Duracao = 437;

Musica musica7 = new Musica(beyonce, "CHURCH GIRL");
musica7.Duracao = 303;

Musica musica8 = new Musica(beyonce, "PLASTIC OFF THE SOFA");
musica8.Duracao = 318;

Musica musica9 = new Musica(beyonce, "VIRGO'S GROOVE");
musica9.Duracao = 307;

Musica musica10 = new Musica(beyonce, "MOVE (feat. Grace Jones & Tems)");
musica10.Duracao = 340;

Musica musica11 = new Musica(beyonce, "HEATED");
musica11.Duracao = 323;

Musica musica12 = new Musica(beyonce, "THIQUE");
musica12.Duracao = 248;

Musica musica13 = new Musica(beyonce, "ALL UP IN YOUR MIND");
musica13.Duracao = 249;

Musica musica14 = new Musica(beyonce, "AMERICA HAS A PROBLEM");
musica14.Duracao = 341;

Musica musica15 = new Musica(beyonce, "PURE/HONEY");
musica15.Duracao = 423;

Musica musica16 = new Musica(beyonce, "SUMMER RENAISSANCE");
musica16.Duracao = 454;

albumDaBeyonce.AdicionarMusica(musica1);
albumDaBeyonce.AdicionarMusica(musica2);
albumDaBeyonce.AdicionarMusica(musica3);
albumDaBeyonce.AdicionarMusica(musica4);
albumDaBeyonce.AdicionarMusica(musica5);
albumDaBeyonce.AdicionarMusica(musica6);
albumDaBeyonce.AdicionarMusica(musica7);
albumDaBeyonce.AdicionarMusica(musica8);
albumDaBeyonce.AdicionarMusica(musica9);
albumDaBeyonce.AdicionarMusica(musica10);
albumDaBeyonce.AdicionarMusica(musica11);
albumDaBeyonce.AdicionarMusica(musica12);
albumDaBeyonce.AdicionarMusica(musica13);
albumDaBeyonce.AdicionarMusica(musica14);
albumDaBeyonce.AdicionarMusica(musica15);
albumDaBeyonce.AdicionarMusica(musica16);

albumDaBeyonce.ExibirMusicasDoAlbum();
Console.WriteLine();

beyonce.AdicionarAlbum(albumDaBeyonce);
beyonce.ExibirDiscografia();
musica1.ExibirFichaTecnica();

// Exemplos de Podcast
Console.WriteLine("\n\n******** Podcasts ********");

Episodio ep1 = new(3, 45, "Técnicas de Facilitação");
ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("Marcelo");

Episodio ep2 = new(2, 67, "Tecnicas de aprendizado");
ep2.AdicionarConvidados("Rafael");
ep2.AdicionarConvidados("Pietra");
ep2.AdicionarConvidados("Ana");

Podcast podcast = new("Lana Silva", "EstudandoCast");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();


