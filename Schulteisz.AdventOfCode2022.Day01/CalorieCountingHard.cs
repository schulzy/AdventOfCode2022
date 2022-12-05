using Schulteisz.AdventOfCode2022.Interfaces;

namespace Schulteisz.AdventOfCode2022.Day01
{
	public class CalorieCountingHard : IDailyTask<long>
    {
        private IContentParser _contentParser;

        public CalorieCountingHard(IContentParser contentParser)
		{
            _contentParser = contentParser;
        }

        public string Name => "Calorie Counting Hard";

        public long Run()
        {
            Group elfGroup = new Group(_contentParser.GetLines("Task.txt"));
            return elfGroup.ThreeBiggestBackpackSum();
        }
    }
}

