namespace Schulteisz.AdventOfCode2022.Day11
{
	internal class Monkey : IMonkey
    {
		public Queue<long> Items { get; } = new Queue<long>();
		public int Id { get; }
		public Func<long, long> Operation { get; set; } 
		public Predicate<long> Condition { get; set; }
		public IMonkey TrueConditionMonkey { get; set; } = NullMonkey.Instance;
        public IMonkey FalseConditionMonkey { get; set; } = NullMonkey.Instance;

        public Monkey(int id, Func<long,long> operation, Predicate<long> condition, IEnumerable<long> items)
		{
			Id = id;
			Operation = operation;
			Condition = condition;
			foreach (var item in items)
				Items.Enqueue(item);
		}
	}

    internal class NullMonkey : IMonkey
	{
		private static IMonkey? _monkey = default;
		public static IMonkey Instance
		{
			get
			{
				if (_monkey is null)
					_monkey = new NullMonkey();

				return _monkey;
			}
		}	

		private NullMonkey()
		{
		}
	}

    internal interface IMonkey
    {
    }
}

