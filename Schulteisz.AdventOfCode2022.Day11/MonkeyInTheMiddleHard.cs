using Schulteisz.AdventOfCode2022.Interfaces;

namespace Schulteisz.AdventOfCode2022.Day11
{
	public class MonkeyInTheMiddleHard : IDailyTask<long>
	{
        private IContentParser _contentParser;

        public MonkeyInTheMiddleHard(IContentParser contentParser)
        {
            _contentParser = contentParser;
        }

        public string Name => "Monkey in the Middle Hard";

        public long Run()
        {
            throw new NotImplementedException();
        }
    }
}

