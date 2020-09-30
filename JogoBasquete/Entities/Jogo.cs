namespace JogoBasquete
{
    public class Jogo 
    {
        public Jogo(int id, int placar)
        {
            Id = id;
            Placar = placar;
        }

        public int Id { get; set; }
        public int Placar { get; set; }
    }
}
