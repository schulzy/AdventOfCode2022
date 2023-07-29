using Schulteisz.AdventOfCode2022.Interfaces;

namespace Schulteisz.AdventOfCode2022.Day12
{
	public class HillClimbingAlgorithm : IDailyTask<long>
    {
        private readonly IContentParser _contentParser;

        public HillClimbingAlgorithm(IContentParser contentParser)
        {
            _contentParser = contentParser;
        }

        public string Name => "Hill Climbing Algorithm";

        public long Run()
        {
            HillManager hillManager = new HillManager(_contentParser.GetLines("Task.txt"));
            hillManager.CreateHill();
            return hillManager.ShortestPath();
        }
    }
}

