namespace Schulteisz.AdventOfCode2022.Day12;

public class HillManager
{
    private readonly IList<string> _lines;
    private readonly Dictionary<(int, int), Point> _hill = new Dictionary<(int, int), Point>();

    public HillManager(IList<string> lines)
    {
        _lines = lines;
    }

    public void CreateHill()
    {
        for (int i = 0; i < _lines.Count; i++)
        {
            for (int j = 0; j < _lines[i].Length; j++)
            {
                _hill.Add((j,i), new Point(j,i,_lines[i][j],_hill));
            }
        }
    }

    public int ShortestPath()
    {
        var startPoint = InitialiseValues(out var neighbours);

        while (neighbours.TryDequeue(out IPoint? point))
        {
            point.FindNextStepNeighbours().ForEach(item => neighbours.Enqueue(item));
            if (point == startPoint)
                return point.DistanceFromTarget;
        }

        throw new Exception("Start point has not been found");
    }
    
    public int AllTheShortestPath()
    {
        InitialiseValues(out var neighbours);

        while (neighbours.TryDequeue(out IPoint? point))
        {
            point.FindNextStepNeighbours().ForEach(item => neighbours.Enqueue(item));
        }

        return _hill.Min(item => item.Value.High == 0 ? item.Value.DistanceFromTarget : int.MaxValue);
    }

    private Point InitialiseValues(out Queue<IPoint> neighbours)
    {
        var finishPoint = _hill.First(item => item.Value.Type == PointEnum.FinishPoint).Value;
        var startPoint = _hill.First(item => item.Value.Type == PointEnum.StartPoint).Value;
        neighbours = new Queue<IPoint>();
        var queue = neighbours;
        finishPoint.FindNextStepNeighbours().ForEach(item => queue.Enqueue(item));
        return startPoint;
    }
}