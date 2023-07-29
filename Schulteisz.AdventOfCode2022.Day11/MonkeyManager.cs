namespace Schulteisz.AdventOfCode2022.Day11
{
	public class MonkeyManager
	{
        private readonly List<string> _list;
        private List<Monkey> _monkeys = new List<Monkey>();

        public MonkeyManager(List<string> list)
		{
            _list = list;
		}

        internal void FindMonkeyBusiness(int rounds, Func<long,long,long> worryLevel, Func<List<Monkey>,long> funcModifier)
        {
            MonkeyFactory monkeyFactory = new MonkeyFactory(_list);
            _monkeys = monkeyFactory.CreateMonkeys();
            for (int i = 0; i < rounds; i++)
            {
                _monkeys.ForEach(monkey => monkey.InvestigateItems(worryLevel, funcModifier(_monkeys)));
            }
        }

        internal long MonkeyBusinessProduct()
        {
            var counters = _monkeys.Select(monkey => monkey.InspectorCounter).OrderByDescending(x => x).ToList();

            return counters[0] * counters[1];
        }

        internal List<long> InspectorCounters()
        {
            return _monkeys.Select(monkey => monkey.InspectorCounter).ToList();
        }
    }
}