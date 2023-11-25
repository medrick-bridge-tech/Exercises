using System;

namespace TreasureHunt
{
    public class Map
    {
        private int[,] _map;
        private int _mapX;
        private int _mapY;
        private int[] _treasurePosition = new int[2];
        private int[] _trapPosition = new int[2];

        public int[,] MapGrid => _map;
        public int MapX => _mapX;
        public int MapY => _mapY;
        public int TreasureX => _treasurePosition[0];
        public int TreasureY => _treasurePosition[1];
        public int TrapX => _trapPosition[0];
        public int TrapY => _trapPosition[1];

        public Map(int width, int height)
        {
            _mapX = width;
            _mapY = height;
            _map = new int[_mapX,_mapY];
            Initialize();
            FindTreasure();
            FindTrap();
        }

        private void Initialize()
        {
            var random = new Random();

            for (var i = 0; i < _mapX; i++)
            {
                for (var j = 0; j < _mapY; j++)
                {
                    _map[i, j] = random.Next(10);
                }
            }
        }

        private void FindTreasure()
        {
            _treasurePosition = FindMaxValueIndex();
        }

        private void FindTrap()
        {
            _trapPosition = FindMinValueIndex();
        }

        private int[] FindMaxValueIndex()
        {
            var maxValue = _map[0,0];
            var maxValueIndex = new int[2];
            for (var i = 0; i < _mapX; i++)
            {
                for (var j = 0; j < _mapY; j++)
                {
                    if (_map[i, j] > maxValue)
                    {
                        maxValue = _map[i, j];
                        maxValueIndex = new[] { i, j };
                    }
                }
            }

            return maxValueIndex;
        }

        private int[] FindMinValueIndex()
        {
            var minValue = _map[0, 0];
            var minValueIndex = new int[2];
            for (var i = 0; i < _mapX; i++)
            {
                for (var j = 0; j < _mapY; j++)
                {
                    if (_map[i, j] < minValue)
                    {
                        minValue = _map[i, j];
                        minValueIndex = new[] { i, j };
                    }
                }
            }

            return minValueIndex;
        }

        public void DisplayMap()
        {
            for (var i = 0; i < _mapX; i++)
            {
                for (var j = 0; j < _mapY; j++)
                {
                    Console.Write($"[{_map[i, j]}]");
                }
                Console.WriteLine();
            }
        }

        public void DisplayMapWithPlayer(Player player)
        {
            for (var i = 0; i < _mapX; i++)
            {
                for (var j = 0; j < _mapY; j++)
                {
                    if (player.PlayerX == i && player.PlayerY == j)
                    {
                        Console.Write("[P]");
                    }
                    else
                    {
                        Console.Write("[0]");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}