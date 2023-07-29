using Schulteisz.AdventOfCode2022.Interfaces;

namespace Schulteisz.AdventOfCode2022.Day12
{
	public class HillClimbingAlgorithmHard : IDailyTask<long>
	{
        private readonly IContentParser _contentParser;

        public HillClimbingAlgorithmHard(IContentParser contentParser)
        {
            _contentParser = contentParser;
        }

        public string Name => "Hill Climbing Algorithm Hard";

        public long Run()
        {
            HillManager hillManager = new HillManager(_contentParser.GetLines("Task.txt"));
            hillManager.CreateHill();
            return hillManager.AllTheShortestPath();
        }
    }
}

