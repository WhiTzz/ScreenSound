using System.Text.Json;
using ScreenSound4.Modelos;
using ScreenSound4.Filtros;
using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
  
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta);

        //MusicasPreferidas MusicasPreferidasGuilherme = new("Guilherme");
        //MusicasPreferidasGuilherme.AdicionarMusicasFavoritas(musicas[10]);
        //MusicasPreferidasGuilherme.AdicionarMusicasFavoritas(musicas[15]);
        //MusicasPreferidasGuilherme.AdicionarMusicasFavoritas(musicas[14]);
        //MusicasPreferidasGuilherme.AdicionarMusicasFavoritas(musicas[12]);
        //MusicasPreferidasGuilherme.AdicionarMusicasFavoritas(musicas[732]);
        //MusicasPreferidasGuilherme.ExibirMusicasFavoritas();

        MusicasPreferidas MusicasPreferidasAlice = new("ALice");
        MusicasPreferidasAlice.AdicionarMusicasFavoritas(musicas[547]);
        MusicasPreferidasAlice.AdicionarMusicasFavoritas(musicas[557]);
        MusicasPreferidasAlice.AdicionarMusicasFavoritas(musicas[537]);
        MusicasPreferidasAlice.AdicionarMusicasFavoritas(musicas[517]);
        MusicasPreferidasAlice.AdicionarMusicasFavoritas(musicas[597]);
        MusicasPreferidasAlice.ExibirMusicasFavoritas();

        MusicasPreferidasAlice.GerarArquivoJson();
        LinqFilter.FiltrarMusicaPorKey(musicas);
        //LinqFilter.FiltrarMusicasPorArtistas(musicas, "Lana Del Rey");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}


