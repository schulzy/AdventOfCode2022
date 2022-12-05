using Schulteisz.AdventOfCode2022.Interfaces;

namespace Schulteisz.AdventOfCode2022.Day03
{
	public class RucksackReorganizationHard : IDailyTask<long>
    {
        private IContentParser _contentParser;

        public RucksackReorganizationHard(IContentParser contentParser)
        {
            _contentParser = contentParser;
        }

        public string Name => "Rucksack Reorganization Hard";

        public long Run()
        {
            Reorganizer reorganizer = new Reorganizer(_contentParser.GetLines("Task.txt"));
            return reorganizer.CalculateGroupValue();
        }
    }
}

