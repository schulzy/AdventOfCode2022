namespace Schulteisz.AdventOfCode2022.Day09
{
    internal class RopeMap
    {
        private List<Point> _head = new List<Point>();
        private List<Point> _tail = new List<Point>();
        private Point _headActual;
        private Point _tailActual;

        public List<Point> Tail => _tail;

        public RopeMap()
        {
            var startPoint = new Point(0, 0);
            _head.Add(startPoint);
            _headActual = startPoint;
            _tail.Add(startPoint);
            _tailActual = startPoint;
        }

        public void AddStep(Direction direction, int value)
        {
            for (int i = 0; i < value; i++)
            {
                switch (direction)
                {
                    case Direction.Left:
                        GoLeft();
                        break;
                    case Direction.Right:
                        GoRight();
                        break;
                    case Direction.Down:
                        GoDown();
                        break;
                    case Direction.Up:
                        GoUp();
                        break;
                    default:
                        break;
                }
            }
        }

        private void GoUp()
        {
            _headActual = new Point(_headActual.X, _headActual.Y - 1);
            _head.Add(_headActual);
            if (!IsNextTo(_headActual, _tailActual))
            {
                _tailActual = new Point(_headActual.X, _headActual.Y + 1);
                _tail.Add(_tailActual);
            }
        }

        private void GoDown()
        {
            _headActual = new Point(_headActual.X, _headActual.Y + 1);
            _head.Add(_headActual);
            if (!IsNextTo(_headActual, _tailActual))
            {
                _tailActual = new Point(_headActual.X, _headActual.Y - 1);
                _tail.Add(_tailActual);
            }
        }

        private void GoRight()
        {
            _headActual = new Point(_headActual.X + 1, _headActual.Y);
            _head.Add(_headActual);
            if (!IsNextTo(_headActual, _tailActual))
            {
                _tailActual = new Point(_headActual.X - 1, _headActual.Y);
                _tail.Add(_tailActual);
            }
        }

        private void GoLeft()
        {
            _headActual = new Point(_headActual.X - 1, _headActual.Y);
            _head.Add(_headActual);
            if (!IsNextTo(_headActual, _tailActual))
            {
                _tailActual = new Point(_headActual.X + 1, _headActual.Y);
                _tail.Add(_tailActual);
            }
        }

        private bool IsNextTo(Point point, Point possibleNeighbours)
        {
            //On the point
            if (point.X == possibleNeighbours.X && point.Y == possibleNeighbours.Y)
                return true;
            //Up left
            if (point.X - 1 == possibleNeighbours.X && point.Y - 1 == possibleNeighbours.Y)
                return true;
            //Up
            if (point.X == possibleNeighbours.X && point.Y - 1 == possibleNeighbours.Y)
                return true;
            //Up right
            if (point.X + 1 == possibleNeighbours.X && point.Y - 1 == possibleNeighbours.Y)
                return true;
            //Left
            if (point.X - 1 == possibleNeighbours.X && point.Y == possibleNeighbours.Y)
                return true;
            //Right
            if (point.X + 1 == possibleNeighbours.X && point.Y == possibleNeighbours.Y)
                return true;
            //Down left
            if (point.X - 1 == possibleNeighbours.X && point.Y + 1 == possibleNeighbours.Y)
                return true;
            //Down
            if (point.X == possibleNeighbours.X && point.Y + 1 == possibleNeighbours.Y)
                return true;
            //Down right
            if (point.X + 1 == possibleNeighbours.X && point.Y + 1 == possibleNeighbours.Y)
                return true;

            return false;
        }

        internal struct Point
        {
            public Point(int x, int y) => (X, Y) = (x, y);
            

            public readonly int X { get; init; }
            public readonly int Y { get; init; }
        }
    }
}