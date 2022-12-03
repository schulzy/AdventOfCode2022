namespace Schulteisz.AdventOfCode2022.Day01
{
	public class ElfComparer : IComparer<Elf>
	{
		public ElfComparer()
		{
		}

        int IComparer<Elf>.Compare(Elf? x, Elf? y)
        {
            if (x is null || y is null)
                throw new NullReferenceException("Elf must no be null");

            return  (int)(x.SumOfBackpack() - y.SumOfBackpack());
        }
    }
}

