using ScreenSound4.Modelos;
using System.Linq;


namespace ScreenSound4.Filtros
{
    internal class LinqFilter
    {
        public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
        {
            var TodosOsGenerosMusicais = musicas.Select(genero => genero.Genero).Distinct().ToList();
            foreach (var genero in TodosOsGenerosMusicais)
            {
                Console.WriteLine(genero);
            }
        }
        public static void FiltrarArtistaPorGeneroMusical(List<Musica> musicas, string genero)
        {
            var ArtistasPorGeneroMusical = musicas.Where(musica => musica.Genero.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
            Console.WriteLine($"Artistas do genero musical {genero}:");
            foreach (var artist in ArtistasPorGeneroMusical)
            {
                Console.WriteLine(artist);
            }
            Console.WriteLine($"{ArtistasPorGeneroMusical.Count} Artistas tocam {genero}");
        }
        public static void FiltrarMusicasPorArtistas(List<Musica> musicas, string artista)
        {
            var MusicasDoArtista = musicas.Where(musicas => musicas.Artista!.Equals(artista)).ToList();
            Console.WriteLine($"Musicas de {artista}:");
            foreach (var musica in MusicasDoArtista)
            {
                Console.WriteLine(musica.Nome);
            }
            Console.WriteLine($"Existe {MusicasDoArtista.Count} musicas de {artista} no nosso banco de dados!");
        }
        public static void FiltrarMusicaPorKey(List<Musica> musicas)
        {

            var MusicasFiltradasPorkey = musicas.Where(musicas => musicas.Tonalidade.Equals("C#")).Select(musicas => musicas.Nome).Distinct().ToList();

            foreach (var Musica in MusicasFiltradasPorkey)
            {
                Console.WriteLine($"{Musica} Tonalidade: C#");
            }
        }

    }
}
