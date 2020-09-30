using JogoBasquete.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace JogoBasquete.Test.Services
{
    public class JogoServiceTests
    {
        [Fact]
        public void deve_calcular_jogos() 
        {
            var jogoA = new Jogo(1, 12);
            var jogoB = new Jogo(2, 24);
            var jogoC = new Jogo(3, 10);
            var jogoD = new Jogo(4, 25);

            var jogosCalculados = JogoService.CalcularJogos(new[] { jogoA, jogoB, jogoC, jogoD });

            Assert.Equal(1, jogosCalculados[0].Id);
            Assert.Equal(12, jogosCalculados[0].Placar);
            Assert.Equal(12, jogosCalculados[0].MenorPlacar);
            Assert.Equal(12, jogosCalculados[0].MaiorPlacar);
            Assert.Equal(0, jogosCalculados[0].QuebraRecordeMin);
            Assert.Equal(0, jogosCalculados[0].QuebraRecordeMax);

            Assert.Equal(2, jogosCalculados[1].Id);
            Assert.Equal(24, jogosCalculados[1].Placar);
            Assert.Equal(12, jogosCalculados[1].MenorPlacar);
            Assert.Equal(24, jogosCalculados[1].MaiorPlacar);
            Assert.Equal(0, jogosCalculados[1].QuebraRecordeMin);
            Assert.Equal(1, jogosCalculados[1].QuebraRecordeMax);

            Assert.Equal(3, jogosCalculados[2].Id);
            Assert.Equal(10, jogosCalculados[2].Placar);
            Assert.Equal(10, jogosCalculados[2].MenorPlacar);
            Assert.Equal(24, jogosCalculados[2].MaiorPlacar);
            Assert.Equal(1, jogosCalculados[2].QuebraRecordeMin);
            Assert.Equal(1, jogosCalculados[2].QuebraRecordeMax);

            Assert.Equal(4, jogosCalculados[3].Id);
            Assert.Equal(25, jogosCalculados[3].Placar);
            Assert.Equal(10, jogosCalculados[3].MenorPlacar);
            Assert.Equal(25, jogosCalculados[3].MaiorPlacar);
            Assert.Equal(1, jogosCalculados[3].QuebraRecordeMin);
            Assert.Equal(2, jogosCalculados[3].QuebraRecordeMax);
        }
    }
}
