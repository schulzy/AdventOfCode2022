using Schulteisz.AdventOfCode2022.Interfaces;

namespace Schulteisz.AdventOfCode2022.Day11
{
	public class MonkeyInTheMiddle : IDailyTask<long>
    {
        private IContentParser _contentParser;

        public MonkeyInTheMiddle(IContentParser contentParser)
        {
            _contentParser = contentParser;
        }

        public string Name => "Monkey in the Middle";

        public long Run()
        {
            MonkeyManager manager = new MonkeyManager(_contentParser.GetLines("Task.txt"));
            Func<long, long,long> worryLevelFunc = (worryLevel, modifier) => worryLevel / modifier;
            Func<List<Monkey>, long> modifier = (monkeys) => 3;
            manager.FindMonkeyBusiness(20, worryLevelFunc, modifier);
            return manager.MonkeyBusinessProduct();
        }
    }
}