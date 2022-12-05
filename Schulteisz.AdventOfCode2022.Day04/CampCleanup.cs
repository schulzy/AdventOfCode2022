using Schulteisz.AdventOfCode2022.Interfaces;

namespace Schulteisz.AdventOfCode2022.Day04
{
	public class CampCleanup : IDailyTask<long>
    {
        private readonly IContentParser _contentParser;

        public CampCleanup(IContentParser contentParser)
		{
            _contentParser = contentParser;
        }

        public string Name => "Camp Cleanup";

        public long Run()
        {
            Camp camp = new Camp(_contentParser.GetLines("Task.txt"));
            return camp.NumberOfOverlappingElements();
        }
    }
}

