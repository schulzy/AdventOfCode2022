namespace Schulteisz.AdventOfCode2022.Day01
{
	internal class Group
	{
		List<Elf> elves = new List<Elf>();
		public Group(List<string> list)
		{
			Elf actualElf = new Elf();
            elves.Add(actualElf);
            foreach (var item in list)
			{
				if (string.IsNullOrWhiteSpace(item))
				{
					actualElf = new Elf();
					elves.Add(actualElf);
                    continue;
				}

				actualElf.AddCalories(int.Parse(item));
			}
		}

		public long BiggestBackpackSum()
		{
			return elves.Max(elf => elf.SumOfBackpack());
		}

        public long ThreeBiggestBackpackSum()
        {
			elves.Sort(new ElfComparer());
			return elves.TakeLast(3).Sum(elf => elf.SumOfBackpack());
        }
    }
}

