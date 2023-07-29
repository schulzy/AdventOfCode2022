namespace Schulteisz.AdventOfCode2022.Day12;

public class Point : IPoint
{
    private bool _neighboursInitialized;
    private readonly Dictionary<(int, int), Point> _hill;
    private int X { get; }
    private int Y { get; }
    private char Label { get; }

    public int DistanceFromTarget { get; set; } = int.MaxValue;
    public PointEnum Type { get; private set; }

    public int High
    {
        get
        {
            return Label switch
            {
                'S' => 0,
                'E' => 25,
                _ => Label - 97
            };
        }
    }

    private IPoint UpperNeighbour { get; set; } = NullPoint.Instance;
    private IPoint LeftNeighbour { get; set; } = NullPoint.Instance;
    private IPoint RightNeighbour { get; set; } = NullPoint.Instance;
    private IPoint LowerNeighbour { get; set; } = NullPoint.Instance;

    public Point(int x, int y, char label, Dictionary<(int, int), Point> hill)
    {
        Label = label;
        _hill = hill;
        X = x;
        Y = y;
        Type = label switch
        {
            'S' => PointEnum.StartPoint,
            'E' => PointEnum.FinishPoint,
            _ => PointEnum.MiddlePoint
        };
        if (label == 'E')
            DistanceFromTarget = 0;
    }

    public List<IPoint> FindNextStepNeighbours()
    {
        SetNeighbours();
        List<IPoint> possibleNeighbours = new List<IPoint>();

        void NeighboursSetter(IPoint point)
        {
            if (point is not INullObject && (Math.Abs( High - point.High) <= 1 || point.High > High)  && point.DistanceFromTarget > DistanceFromTarget + 1)
            {
                point.DistanceFromTarget = DistanceFromTarget + 1;
                possibleNeighbours.Add(point);
            }
        }

        NeighboursSetter(UpperNeighbour);
        NeighboursSetter(RightNeighbour);
        NeighboursSetter(LeftNeighbour);
        NeighboursSetter(LowerNeighbour);

        return possibleNeighbours;
    }
    
    private void SetNeighbours()
    {
        if(_neighboursInitialized)
            return;
        
        if (_hill.TryGetValue((X, Y - 1), out Point? upperNeighbour))
            UpperNeighbour = upperNeighbour;
        if (_hill.TryGetValue((X, Y + 1), out Point? lowerNeighbour))
            LowerNeighbour = lowerNeighbour;
        if (_hill.TryGetValue((X - 1, Y), out Point? leftNeighbour))
            LeftNeighbour = leftNeighbour;
        if (_hill.TryGetValue((X + 1, Y), out Point? rightNeighbour))
            RightNeighbour = rightNeighbour;

        _neighboursInitialized = true;
    }
}

public class NullPoint : IPoint, INullObject
{
    private static NullPoint? _instance = null;

    public static NullPoint Instance => _instance ??= new NullPoint();

    private NullPoint()
    {
    }

    public int DistanceFromTarget { get; set; }
    public int High { get; } = 0;
    public List<IPoint> FindNextStepNeighbours()
    {
        return new List<IPoint>();
    }
}

public interface INullObject
{
}

public interface IPoint
{
    int DistanceFromTarget { get; set; }
    int High { get; }
    List<IPoint> FindNextStepNeighbours();
}

public enum PointEnum
{
    StartPoint,
    MiddlePoint,
    FinishPoint
}