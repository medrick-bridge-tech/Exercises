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
        }
    }
}