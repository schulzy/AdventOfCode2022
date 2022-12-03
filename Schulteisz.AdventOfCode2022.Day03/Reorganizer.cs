namespace Schulteisz.AdventOfCode2022.Day03
{
	internal class Reorganizer
	{
		private List<Rucksack> _rucksacks = new List<Rucksack>();
		private List<(Rucksack, Rucksack, Rucksack)> _rucksackGroups = new List<(Rucksack, Rucksack, Rucksack)>();
		public Reorganizer(List<string> list)
		{
			foreach (var bagData in list)
			{
				_rucksacks.Add(new Rucksack(bagData));
			}

			for (int i = 0; i < list.Count; i += 3)
			{
				var group = _rucksacks.Take(new Range(i, i + 3)).ToList();
				if (group.Count() != 3)
					throw new ArgumentOutOfRangeException("It must be 3 element long");

				_rucksackGroups.Add((group[0], group[1], group[2]));
			}
		}

		public long CalculateGroupValue()
		{
			long sum = 0;
			foreach (var rucksackGroup in _rucksackGroups)
			{
				var items = rucksackGroup.Item1.FullRucksack.Intersect(rucksackGroup.Item2.FullRucksack).Intersect(rucksackGroup.Item3.FullRucksack);
				sum += items.Sum(CharValueCalculator.Calculate);
            }

			return sum;
		}

		public long CalculateValue()
		{
			long sum = 0;
			foreach (var rucksack in _rucksacks)
			{
				sum += rucksack.CommonItemValue();
			}

			return sum;
		}
	}
}