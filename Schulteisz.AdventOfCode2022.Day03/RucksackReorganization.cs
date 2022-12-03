using Schulteisz.AdventOfCode2022.Interfaces;

namespace Schulteisz.AdventOfCode2022.Day03
{
	public class RucksackReorganization : IDailyTask
    {
        private IContentParser _contentParser;

        public RucksackReorganization(IContentParser contentParser)
        {
            _contentParser = contentParser;
        }

        public string Name => "Rucksack Reorganization";

        public long Run()
        {
            Reorganizer reorganizer = new Reorganizer(_contentParser.GetLines("Task.txt"));
            return reorganizer.CalculateValue();
        }
    }
}

