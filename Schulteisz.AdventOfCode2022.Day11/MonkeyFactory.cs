namespace Schulteisz.AdventOfCode2022.Day11
{
	internal class MonkeyFactory
	{
        private readonly IList<string> _monkeyLines;
        public MonkeyFactory(IList<string> monkeyLines)
		{
            _monkeyLines = monkeyLines;
		}

		public List<Monkey> CreateMonkeys()
		{
            List<string> monkeyCommands = new List<string>();
            List<Monkey> monkeys = new List<Monkey>();
            for (int i = 0; i < (_monkeyLines.Count + 1) / 7; i++)
            {
                monkeys.Add(new Monkey(i));
            }

            foreach (var line in _monkeyLines)
            {
                monkeyCommands.Add(line);
                if (string.IsNullOrWhiteSpace(line))
                {
                    CreateMonkey(monkeyCommands, monkeys);
                    monkeyCommands.Clear();
                }
            }
            CreateMonkey(monkeyCommands, monkeys);
            return monkeys;
        }

        private void CreateMonkey(List<string> monkeyCommands, List<Monkey> monkeys)
        {
            int id = int.Parse(monkeyCommands[0].Replace("Monkey", string.Empty)[..^1]);
            var monkey = monkeys.Find(monkey => monkey.Id == id);
            if (monkey is null)
                throw new ArgumentNullException(nameof(monkey));

            // Set items
            List<int> items = monkeyCommands[1].Split(":")[1].Split(",").ToList().ConvertAll(x => int.Parse(x));
            items.ForEach(x => monkey.Items.Enqueue(x));

            // Set operation
            // E.g.: Operation: new = old * 19
            string operation = monkeyCommands[2].Split(":")[1].Split("=")[1];
            monkey.Operation = CreateOperation(operation);

            // Set test conditon
            var condition = new string(monkeyCommands[3].TakeLast(2).ToArray());
            if(condition is null)
                throw new ArgumentNullException(nameof(condition));
            monkey.DivisibleNumber = int.Parse(condition);
            monkey.Condition = x => x % monkey.DivisibleNumber == 0;

            // Set monkey conditions
            var trueCondition = new string(monkeyCommands[4].TakeLast(2).ToArray());
            if(trueCondition is null)
                throw new ArgumentNullException(nameof(trueCondition));
            monkey.TrueConditionMonkey = monkeys.Find(monkey => monkey.Id == long.Parse(trueCondition));

            var falseCondition = new string(monkeyCommands[5].TakeLast(2).ToArray());
            if (falseCondition is null)
                throw new ArgumentNullException(nameof(falseCondition));
            monkey.FalseConditionMonkey = monkeys.Find(monkey => monkey.Id == long.Parse(falseCondition));
        }

        private Func<long, long> CreateOperation(string operation)
        {
            
            switch (operation)
            {
                case { } s when s.Contains("+"):
                    return CreateAdd(s.Split("+"));
                case { } s when s.Contains("-"):
                    return CreateSub(s.Split("-"));
                case { } s when s.Contains("*"):
                    return CreateMulti(s.Split("*"));
                case { } s when s.Contains("/"):
                    return CreateDiv(s.Split("/"));
                default:
                    throw new ArgumentOutOfRangeException(nameof(operation));
            }
        }

        private Func<long, long> CreateDiv(string[] sides)
        {
            if (sides[1].Contains("old"))
                return x => x / x;

            return x => x / int.Parse(sides[1]);
        }

        private Func<long, long> CreateMulti(string[] sides)
        {
            if (sides[1].Contains("old"))
                return x => x * x;

            return x => x * int.Parse(sides[1]);
        }

        private Func<long, long> CreateSub(string[] sides)
        {
            if (sides[1].Contains("old"))
                return x => x - x;

            return x => x - int.Parse(sides[1]);
        }

        private Func<long, long> CreateAdd(string[] sides)
        {
            if (sides[1].Contains("old"))
                return x => x + x;

            return x => x + int.Parse(sides[1]);
        }
    }
}