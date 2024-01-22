using ScreenSound4.Filtros;
using ScreenSound4.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound4.Menu
{
    internal class MenuMostrarTodasAsMusica: MenuPai
    {
        public override void ExibirMenu(List<Musica> musicas, List<string> MusicasFavoritas)
        {
            base.ExibirMenu(musicas, MusicasFavoritas);
            Console.WriteLine("Aperte enter para ver todas as Musicas");
            Console.ReadLine();
            LinqOrder.ExibirListaDeMusicasOrdenadas(musicas);
            Console.WriteLine("\n Estas são todas as Musicas no nosso banco de dados, aperte enter para voltar ao menu principal :)");
            Console.ReadLine();

        }
    }
}
