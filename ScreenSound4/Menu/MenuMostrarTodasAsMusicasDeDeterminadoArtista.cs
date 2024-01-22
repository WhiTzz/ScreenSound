using ScreenSound4.Filtros;
using ScreenSound4.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound4.Menu;

internal class MenuMostrarTodasAsMusicasDeDeterminadoArtista:MenuPai
{
    public override void ExibirMenu(List<Musica> musicas, List<string>MusicasFavoritas)
    {
        base.ExibirMenu(musicas,MusicasFavoritas);
        Console.WriteLine("Digite o nome do artista");
        string Artista = Console.ReadLine()!;
        LinqFilter.FiltrarMusicasPorArtistas(musicas, Artista);
        Console.WriteLine($"\n Estas são todas as musicas de {Artista} no nosso banco de dados, aperte enter para voltar ao menu principal :)");
        Console.ReadLine();

    }
}
