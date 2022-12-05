using Schulteisz.AdventOfCode2022.Interfaces;

namespace Schulteisz.AdventOfCode2022.Day04
{
	public class CampCleanupHard : IDailyTask
	{
        private readonly IContentParser _contentParser;

        public CampCleanupHard(IContentParser contentParser)
		{
            _contentParser = contentParser;
        }

        public string Name => "Camp Cleanup Hard";

        public long Run()
        {
            Camp camp = new Camp(_contentParser.GetLines("Task.txt"));
            return camp.NumberOfSimpleOverlappingElements();
        }
    }
}

