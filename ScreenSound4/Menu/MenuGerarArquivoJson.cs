using ScreenSound4.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ScreenSound4.Menu;

internal class MenuGerarArquivoJson:MenuPai
{
    public override void ExibirMenu(List<Musica> musicas, List<string> MusicasFavoritas)
    {
        base.ExibirMenu(musicas, MusicasFavoritas);
        Console.WriteLine("Qual o seu nome?");
        string NomeDoUsuario = Console.ReadLine()!;
        string json = JsonSerializer.Serialize(new
            {
                nome = NomeDoUsuario,
                musicas = MusicasFavoritas
            });
            string NomedoAquirvo = $"musicas-favoritas-{Nome}.json";
            File.WriteAllText(NomedoAquirvo, json);
            Console.WriteLine($"O arquivo Json foi gerado com sucesso :) {Path.GetFullPath(NomedoAquirvo)}");
        Console.WriteLine("Aperte enter para voltar ao menu");
        Console.ReadLine();
    }
}
