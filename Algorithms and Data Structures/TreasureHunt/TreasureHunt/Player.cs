using System;

namespace TreasureHunt
{
    public class Player
    {
        private int[] _playerPosition = new int[2];
        private int _playerMoves;

        public int PlayerX => _playerPosition[0];
        public int PlayerY => PlayerPosition[1];

        public int[] PlayerPosition
        {
            get => _playerPosition;
            set => _playerPosition = value;
        }

        public int PlayerMoves => _playerMoves;

        public Player(Map map, int movesLeft)
        {
            _playerMoves = movesLeft;
            SetRandomPosition(map);
        }

        private void SetRandomPosition(Map map)
        {
            var random = new Random();
            int x, y;
            do
            {
                x = random.Next(map.MapX);
                y = random.Next(map.MapY);
            } while (x != map.TreasureX && y != map.TreasureY && x != map.TrapX && y != map.TrapY);

            _playerPosition = new[] { x, y };
        }
    }
}