namespace Schulteisz.AdventOfCode2022.Day09
{
    internal class RopeMap
    {
        private readonly HashSet<Point> _tail = new HashSet<Point>();
        private readonly List<Point> _rope;
        private readonly int _length;

        public HashSet<Point> Tail => _tail;

        public RopeMap(int length)
        {
            _length = length;
            var startPoint = new Point(0, 0);
            _rope = new List<Point>(length);
            for (int i = 0; i < length; i++)
                _rope.Add(startPoint);

            _tail.Add(startPoint);
        }

        public void AddStep(Direction direction, int value)
        {
            for (int i = 0; i < value; i++)
            {
                switch (direction)
                {
                    case Direction.Left:
                        _rope[0] = new Point(_rope[0].X - 1, _rope[0].Y);
                        SetRope();
                        break;
                    case Direction.Right:
                        _rope[0] = new Point(_rope[0].X + 1, _rope[0].Y);
                        SetRope();
                        break;
                    case Direction.Down:
                        _rope[0] = new Point(_rope[0].X, _rope[0].Y + 1);
                        SetRope();
                        break;
                    case Direction.Up:
                        _rope[0] = new Point(_rope[0].X, _rope[0].Y - 1);
                        SetRope();
                        break;
                    default:
                        break;
                }
            }
        }

        private void SetRope()
        {
            for (int i = 1; i < _length; i++)
            {
                Point diff = _rope[i - 1] - _rope[i];
                if(!IsNeighbours(diff))
                {
                    _rope[i] += CreateRealDiff(diff);
                }
            }

            _tail.Add(_rope.Last());
        }

        private Point CreateRealDiff(Point diff)
        {
            Func<int, int> setValue = (value) =>
            {
                if (Math.Abs(value) > 1)
                {
                    if (value > 0)
                        value -= 1;
                    else
                        value += 1;
                }

                return value;
            };

            return new Point(setValue(diff.X), setValue(diff.Y));
        }


        public bool IsNeighbours(Point diff)
        {
            if (Math.Abs(diff.X) > 1 || Math.Abs(diff.Y) > 1)
                return false;

            return true;
        }

        internal struct Point
        {
            public Point(int x, int y) => (X, Y) = (x, y);
            
            public readonly int X { get; init; }
            public readonly int Y { get; init; }

            public static Point operator +(Point p1, Point p2)
                => new Point(p1.X + p2.X, p1.Y + p2.Y);

            public static Point operator -(Point p1, Point p2)
                => new Point(p1.X - p2.X, p1.Y - p2.Y);
        }
    }
}