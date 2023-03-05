namespace Schulteisz.AdventOfCode2022.Day11
{
	internal class Monkey 
    {
		public Queue<long> Items { get; } = new Queue<long>();
		public int Id { get; }
		public Func<long, long> Operation { get; set; } = x => throw new NotImplementedException();
		public Predicate<long> Condition { get; set; } = x => throw new NotImplementedException();
		public Monkey? TrueConditionMonkey { get; set; } 
		public Monkey? FalseConditionMonkey { get; set; }

        public Monkey(int id)
		{
			Id = id;
		}
	}
}

