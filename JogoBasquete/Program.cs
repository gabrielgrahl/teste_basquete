using JogoBasquete.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JogoBasquete
{
    class Program
    {
        private 
        static void Main(string[] args)
        {
            IList<Jogo> jogos = new List<Jogo>();
            Console.WriteLine("Insira um placar ou digite 'sair'");
            var opcao = Console.ReadLine();
            var placar = 0;
            while (opcao != "sair" && int.TryParse(opcao, out placar)) 
            {
                jogos.Add(new Jogo((jogos.Count + 1), placar));
                Console.WriteLine("Insira um placar ou digite 'sair'");
                opcao = Console.ReadLine();
            }

            Console.WriteLine("| Jogo | Placar | Minimo | Maximo | Quebra recorde min | Quebra recorde Max |");
            var viewModels = JogoService.CalcularJogos(jogos);
            foreach (var viewModel in viewModels) 
            {
                Console.WriteLine("| " + viewModel.Id + " | " + viewModel.Placar + " | " + viewModel.MenorPlacar + " | " + viewModel.MaiorPlacar + " | " + viewModel.QuebraRecordeMin + " | " + viewModel.QuebraRecordeMax + " | ");
            }
        }
    }
}
