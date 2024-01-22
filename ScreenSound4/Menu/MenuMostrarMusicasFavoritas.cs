using ScreenSound4.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound4.Menu;

internal class MenuMostrarMusicasFavoritas:MenuPai
{
    public override void ExibirMenu(List<Musica> musicas, List<string> MusicasFavoritas)
    {
        base.ExibirMenu(musicas, MusicasFavoritas);
        Console.WriteLine("Musicas Favoritadas ate agora:");
        foreach (var musica in MusicasFavoritas)
        {

            Console.WriteLine(musica);
        }
        Console.WriteLine("Aperte enter para voltar ao menu");
        Console.ReadLine();

    }
}
