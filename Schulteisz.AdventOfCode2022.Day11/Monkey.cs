using System.Numerics;

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
		public long InspectorCounter { get; private set; } = 0;
		public int DivisibleNumber { get; set; }

        public Monkey(int id)
		{
			Id = id;
		}

		public void InvestigateItems(Func<long, long, long> worryLevelFunc, long modifier)
		{
			if (TrueConditionMonkey is null)
				throw new ArgumentNullException(nameof(TrueConditionMonkey));
            if (FalseConditionMonkey is null)
                throw new ArgumentNullException(nameof(FalseConditionMonkey));

            while (Items.Count > 0)
			{
				InspectorCounter++;
				long worryLevel = Items.Dequeue();

                long newWorryLevel = worryLevelFunc(Operation(worryLevel), modifier);
			

                if (Condition(newWorryLevel))
					TrueConditionMonkey.Items.Enqueue(newWorryLevel);
				else
					FalseConditionMonkey.Items.Enqueue(newWorryLevel);
			}
		}
	}
}