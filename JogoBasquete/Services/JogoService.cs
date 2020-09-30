using System.Collections.Generic;
using System.Linq;

namespace JogoBasquete.Services
{
     public static class JogoService
     {
        public static IList<JogoViewModel> CalcularJogos(IList<Jogo> jogos) 
        {
            var contador = 0;
            var recordeMinimo = 0;
            var recordeMaximo = 0;
            IList<JogoViewModel> jogosViewModels = new List<JogoViewModel>();
            foreach (var jogo in jogos)
            {
                var jogosAteAqui = jogos.Take(jogo.Id);
                var minimoTemporada = jogosAteAqui.Select(d => d.Placar).Min();
                var maximoTemporada = jogosAteAqui.Select(d => d.Placar).Max();
                if (contador != 0)
                {
                    if (!jogosAteAqui.Where(d => d.Id != jogo.Id).Any(d => d.Placar <= jogo.Placar))
                    {
                        recordeMinimo++;
                    }
                    if (!jogosAteAqui.Where(d => d.Id != jogo.Id).Any(d => d.Placar >= jogo.Placar))
                    {
                        recordeMaximo++;
                    }
                }
                jogosViewModels.Add(new JogoViewModel(jogo.Id, jogo.Placar, minimoTemporada, maximoTemporada, recordeMinimo, recordeMaximo));
                contador++;
            }
            return jogosViewModels;
        }
    }
}
