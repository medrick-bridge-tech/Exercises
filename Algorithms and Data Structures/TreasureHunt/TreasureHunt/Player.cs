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

        public Player(int x, int y, int movesLeft)
        {
            _playerPosition = new[] { x, y };
            _playerMoves = movesLeft;
        }
    }
}