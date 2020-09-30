namespace JogoBasquete
{
    public class JogoViewModel 
    {
        public JogoViewModel(int id, 
            int placar, 
            int menorPlacar, 
            int maiorPlacar, 
            int quebraRecordeMin, 
            int quebraRecordeMax)
        {
            Id = id;
            Placar = placar;
            MenorPlacar = menorPlacar;
            MaiorPlacar = maiorPlacar;
            QuebraRecordeMin = quebraRecordeMin;
            QuebraRecordeMax = quebraRecordeMax;
        }

        public int Id { get; set; }
        public int Placar { get; set; }
        public int MenorPlacar { get; set; }
        public int MaiorPlacar { get; set; }
        public int QuebraRecordeMin { get; set; }
        public int QuebraRecordeMax { get; set; }
    }
}
