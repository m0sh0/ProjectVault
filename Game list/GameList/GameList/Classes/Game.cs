namespace GameList.Classes
{
    public class Game
    {
        public int id { get; set; }
        public string title { get; set; }
        public string genre { get; set; }
        public string platform { get; set; }
        public DateTime releasedate { get; set; }
        public bool completed { get; set; }
        public int rating { get; set; }
    }
}