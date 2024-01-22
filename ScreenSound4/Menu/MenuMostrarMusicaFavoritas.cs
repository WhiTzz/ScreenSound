using ScreenSound4.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound4.Menu;

internal class MenuMostrarMusicaFavoritas:MenuPai
{
    public override void ExibirMenu(List<Musica> musicas, List<string> MusicasFavoritas)
    {
        base.ExibirMenu(musicas, MusicasFavoritas);
        Console.WriteLine("Essas sao suas Musicas Favoritas:");
        foreach(var musica in MusicasFavoritas)
        {
            Console.WriteLine(musica);
        }
        Console.WriteLine("Digite Enter Para voltar ao menu principal");
        Console.ReadLine();

    }
}
