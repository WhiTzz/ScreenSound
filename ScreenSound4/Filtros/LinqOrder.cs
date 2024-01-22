
using ScreenSound4.Modelos;
using System.Linq;



namespace ScreenSound4.Filtros
{
    internal interface LinqOrder
    {

        public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
        {

            var ArtistasOrdenados = musicas.Select(musica => musica.Artista).Distinct().OrderBy(musica => musica).ToList();
            foreach (var Artista in ArtistasOrdenados)
            {


                Console.WriteLine($"--{Artista}");
            }
        }
            public static void ExibirListaDeMusicasOrdenadas(List<Musica> musicas)
            {

                var MusicasOrdenadas = musicas.Select(musica => musica.Nome).Distinct().OrderBy(musica => musica).ToList();
                foreach (var Musicas in MusicasOrdenadas)
                {


                    Console.WriteLine($"--{Musicas}");
                }

            }
    }
}

