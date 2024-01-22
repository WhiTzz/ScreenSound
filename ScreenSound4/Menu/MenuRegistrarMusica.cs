using ScreenSound4.Filtros;
using ScreenSound4.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound4.Menu;

internal class MenuRegistrarMusica:MenuPai
{

    public override void ExibirMenu(List<Musica> musicas, List<string> MusicasFavoritas)
    {
        base.ExibirMenu(musicas, MusicasFavoritas);
        Console.WriteLine("Digite o nome da musica que voce quer adicionar a sua lista de musicas favoritas");
        string musicaFavorita = Console.ReadLine()!;
     
            var NomeDasMusicas = musicas.Where(Musica => Musica.Nome.Equals(musicaFavorita)).Distinct().ToList();
        
            if (NomeDasMusicas.Count == 0 || NomeDasMusicas[NomeDasMusicas.Count - 1].Nome != musicaFavorita)
            {
            MusicaNaoEncontrada(musicas);
            }
            else
        {
           
                Console.WriteLine($"Musica {musicaFavorita} registrada com sucesso!");
                Console.WriteLine("Musicas Favoritadas ate agora:");
                MusicasFavoritas.Add(musicaFavorita);
            foreach (var musica in MusicasFavoritas)
                {
               
                    Console.WriteLine(musica);
                }
                Console.WriteLine("Digite 1 para Regitrar outra musica ou pressione qualquer outra tecla para voltar ao menu principal!");
                string resp = Console.ReadLine()!;
                if (resp == "1")
                {
                    ExibirMenu(musicas, MusicasFavoritas);
                }
                else
                {
                Console.Clear();    
                }

            

            }
    }
    private void MusicaNaoEncontrada(List<Musica> musicas)
    {
        Console.Clear();
        Console.WriteLine("Nao encontramos sua musica :( tente achar outra :)");
        Console.ReadLine();

    }
    
}
