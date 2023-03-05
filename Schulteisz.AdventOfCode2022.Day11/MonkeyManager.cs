using System;
namespace Schulteisz.AdventOfCode2022.Day11
{
	public class MonkeyManager
	{
        private List<string> _list;

        public MonkeyManager(List<string> list)
		{
            _list = list;
		}

        internal void FindMonkeyBusiness(int rounds)
        {
            MonkeyFactory monkeyFactory = new MonkeyFactory(_list);
            var monkeys = monkeyFactory.CreateMonkeys();
        }
    }
}

