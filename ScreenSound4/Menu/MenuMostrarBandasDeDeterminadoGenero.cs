using ScreenSound4.Filtros;
using ScreenSound4.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound4.Menu;

internal class MenuMostrarBandasDeDeterminadoGenero:MenuPai
{
    public override void ExibirMenu(List<Musica> musicas, List<string> MusicasFavoritas)
    {
        base.ExibirMenu(musicas, MusicasFavoritas);
        Console.WriteLine("Aperte enter para ver todos os generos musicais Contidos no nosso banco de dados: ");
        LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        Console.WriteLine("Digite o genero Musical que vc deseja ver a lsita de artitas");
        string genero = Console.ReadLine()!;
        LinqFilter.FiltrarArtistaPorGeneroMusical(musicas, genero.ToLower());
        Console.WriteLine($"\n Estas são todas as bandas do genero {genero}no nosso banco de dados, aperte enter para voltar ao menu principal :)");
        Console.ReadLine();

    }
}
