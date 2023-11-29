using System;

namespace TreasureHunt
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Map map = new Map(5, 5);
            Player player = new Player(map, 10);
            StartGame(player,map);
        }

        public static void StartGame(Player player, Map map)
        {
            var playerMoves = player.PlayerMoves;
            while (playerMoves > 0)
            {
                Console.Clear();
                Console.WriteLine($"{map.TreasureX}:{map.TreasureY}");
                map.DisplayMapWithPlayer(player);

                Console.WriteLine($"Moves left: {playerMoves}");
                Console.WriteLine("Enter direction (W/A/S/D) or 'Q' to quit:");

                char input = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (input == 'Q' || input == 'q')
                {
                    Console.WriteLine("Game over. Thanks for playing!");
                    break;
                }
                
                switch (char.ToUpper(input))
                {
                    case 'W':
                        if (player.PlayerX > 0)
                            player.PlayerPosition[0]--;
                        break;
                    case 'A':
                        if (player.PlayerY > 0)
                            player.PlayerPosition[1]--;
                        break;
                    case 'S':
                        if (player.PlayerX < map.MapX - 1)
                            player.PlayerPosition[0]++;
                        break;
                    case 'D':
                        if (player.PlayerY < map.MapY - 1)
                            player.PlayerPosition[1]++;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Use W/A/S/D to move or Q to quit.");
                        continue;
                }
                
                if (player.PlayerX == map.TreasureX && player.PlayerY == map.TreasureY)
                {
                    Console.WriteLine("Congratulations! You found the treasure!");
                    break;
                }

                if (player.PlayerX == map.TrapX && player.PlayerY == map.TrapY)
                {
                    Console.WriteLine("Oops! You fell into a trap. Game over!");
                    break;
                }
                
                playerMoves--;
            }
            map.DisplayMap();
            Console.ReadLine();
            
        }
    }
}