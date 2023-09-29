using System.ComponentModel.DataAnnotations;

namespace LINQ_Thompson_Lillian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game[] games = new Game[]
            {
                new Game ("Minecraft", 'e', "Action-Adventure"),
                new Game ("CS:GO", 'M', "FPS"),
                new Game ("Elen Ring", 'M', "Action-Adventure"),
                new Game ("Valorant", 'T', "FPS"),
                new Game ("Halo 3", 'M', "  Action FPS"),
                new Game ("ZombCube", 'E', "FPS survival"),
                new Game ("Magnet Destoryer", 'E', "Hyper-Casual"),
                new Game ("Paddle Balls", 'E', "Arcade Causal"),
                new Game ("Rocket League", 'E', "Action Racing"),
                new Game ("Fifa 22", 'E', "Sport"),

            };

            var shortGames = from game in games
                             where game.Title.Length < 9
                             select $"Game Title: {game.Title.ToUpper()}";

            foreach(var game in shortGames)
            {
                Console.WriteLine (game);
            }
            var mineCraft = games.Where(game => game.Title == "Minecraft");
                            .Select(games => $"Title: {Game.Title}, ESRB: {Game.Esrb}, Genre: {Game.Genre}");
                

            Console.WriteLine(mineCraft.FirstOrDefault());

            var tRated = from game in games
                         where game.Esrb == 'T'
                         select game.Title;
           
            Console.WriteLine("T Rated Game:");
            foreach(var game in tRated)
            {
                Console.WriteLine (game);
            }

            var eRatedAction = from game in games
                               where game.Esrb == 'E' && game.Genre.Contains("Action")
                               select game.Title;
           
            Console.WriteLine("T Rated Game:");
            foreach (var game in tRated)
            {
                Console.WriteLine(game);
            }

        }
    }
}