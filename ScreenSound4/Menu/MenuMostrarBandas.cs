using ScreenSound4.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenSound4.Filtros;
namespace ScreenSound4.Menu;

internal class MenuMostrarBandas : MenuPai
{
    public override void ExibirMenu(List<Musica> musicas, List<string> MusicasFavoritas)
    {
        base.ExibirMenu(musicas, MusicasFavoritas);
        Console.WriteLine("Aperte enter para ver todas as bandas");
        Console.ReadLine();
       LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        Console.WriteLine("\n Estas são todas as bandas no nosso banco de dados, aperte enter para voltar ao menu principal :)");
        Console.ReadLine();

    }
}