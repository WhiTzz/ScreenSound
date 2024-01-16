using System.Text.Json;
namespace ScreenSound4.Modelos;

internal class MusicasPreferidas
{
  
    public string? Nome { get; set; }
    public List<Musica> ListaDeMusicasFavoritas { get; }
    public  MusicasPreferidas(string nome)
    {
        Nome = nome;
        ListaDeMusicasFavoritas = new List<Musica>();
    }
    public void AdicionarMusicasFavoritas(Musica musica)
    {
        ListaDeMusicasFavoritas.Add(musica); 
    }
    public void ExibirMusicasFavoritas() 
    {
        Console.WriteLine($"Essas sao as musicas favortias de {Nome}");
        foreach(var musica  in ListaDeMusicasFavoritas)
        {
            Console.WriteLine($"{musica.Nome} de {musica.Artista}");
        }
        Console.WriteLine(" ");
    }
   public void GerarArquivoJson() 
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaDeMusicasFavoritas
        }); 
        string NomedoAquirvo = $"musicas-favoritas-{Nome}.json";
        File.WriteAllText(NomedoAquirvo, json);
        Console.WriteLine($"O arquivo Json foi gerado com sucesso :) {Path.GetFullPath(NomedoAquirvo)}");
    }
}
