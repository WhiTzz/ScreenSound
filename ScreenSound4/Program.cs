using System.Text.Json;
using ScreenSound4.Modelos;
using ScreenSound4.Filtros;
using System.Collections.Generic;
using ScreenSound4.Menu;
using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta);

        List<string> MusicasFavoritas = new List<string>();
        Dictionary<int, MenuPai> Menus = new();
        Menus[1] = new MenuRegistrarMusica();
        Menus[2] = new MenuMostrarBandas();
        Menus[3] = new MenuMostrarTodasAsMusica();
        Menus[4] = new MenuMostrarBandasDeDeterminadoGenero();
        Menus[5] = new MenuMostrarTodasAsMusicasDeDeterminadoArtista();
        Menus[6] = new MenuMostrarMusicasFavoritas();
        Menus[7] = new MenuGerarArquivoJson();
        ExibirMenuPrincipal(musicas, Menus,MusicasFavoritas);

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }

}
 void ExibirMenuPrincipal(List<Musica> musicas, Dictionary<int,MenuPai> Menus, List<string> MusicasFavoritas)
{
    MenuPai Menupai = new MenuPai();
    Menupai.ExibirMenu(musicas, MusicasFavoritas);
    Console.WriteLine("Bem vindo ao Screen Sound");
    Console.WriteLine("Digite 1 para Registrar uma musica favorita");
    Console.WriteLine("Digite 2 para mostrar todas as bandas do nosso banco de dados");
    Console.WriteLine("Digite 3 para mostrar todas as musicas do nosso banco de dados");
    Console.WriteLine("Digite 4 para mostrar todas as bandas de determinado genero");
    Console.WriteLine("Digite 5 para mostrar todas musicas de determinado artista");
    Console.WriteLine("Digite 6 para exibir suas musicas favoritas");
    Console.WriteLine("Digite 7 para converter suas musicas para um arquivo .JSON");
    Console.WriteLine("Digite -1 para sair");






    
    string Text = Console.ReadLine()!;
    int OpcaoNumerica = int.Parse(Text);
    if (OpcaoNumerica != -1)
    {


        if (Menus.ContainsKey(OpcaoNumerica))
        {
            Menus[OpcaoNumerica].ExibirMenu(musicas, MusicasFavoritas);
        }
        else
        {
            Console.WriteLine($"{OpcaoNumerica} nao e uma opcao valida, tente novamente");
            Console.ReadLine();
        }
        ExibirMenuPrincipal(musicas, Menus, MusicasFavoritas);
    }
    else
    {
        Console.WriteLine("Tchau, Tchau :)");
        Console.ReadLine();
    }
}
 void AdiconarMusicaPreferida(string musica, List<string>MusicasFavoritas)
{
    MusicasFavoritas.Add(musica);
}

