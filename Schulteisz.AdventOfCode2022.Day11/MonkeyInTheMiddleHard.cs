using Schulteisz.AdventOfCode2022.Interfaces;

namespace Schulteisz.AdventOfCode2022.Day11
{
	public class MonkeyInTheMiddleHard : IDailyTask<long>
	{
        private IContentParser _contentParser;
        private int _count;

        public MonkeyInTheMiddleHard(IContentParser contentParser, int count)
        {
            _contentParser = contentParser;
            _count = count;
        }

        public string Name => "Monkey in the Middle Hard";

        public long Run()
        {
            MonkeyManager manager = new MonkeyManager(_contentParser.GetLines("Task.txt"));
            Func<long, long, long> worryLevelFunc = (worryLevel, modifier) => worryLevel % modifier;
            Func<List<Monkey>, long> modifier = (monkeys) =>
            {
                long product = 1;
                foreach (var monkey in monkeys)
                {
                    product *= monkey.DivisibleNumber;
                }

                return product;
            };
            manager.FindMonkeyBusiness(_count, worryLevelFunc, modifier);
            return manager.MonkeyBusinessProduct();
        }

        public List<long> GetPartResults()
        {
            MonkeyManager manager = new MonkeyManager(_contentParser.GetLines("Task.txt"));
            Func<long, long, long> worryLevelFunc = (worryLevel, modifier) => worryLevel % modifier;
            Func<List<Monkey>, long> modifier = (monkeys) =>
            {
                long product = 1;
                foreach (var monkey in monkeys)
                {
                    product *= monkey.DivisibleNumber;
                }

                return product;
            };
            manager.FindMonkeyBusiness(_count, worryLevelFunc, modifier);

            return manager.InspectorCounters();
        }
    }
}