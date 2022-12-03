namespace Schulteisz.AdventOfCode2022.Day01
{
	internal class Elf
	{
        private readonly List<int> _backPack = new List<int>();

        public Elf()
		{
		}

        internal void AddCalories(int calories)
        {
            _backPack.Add(calories);
        }

        internal long SumOfBackpack()
        {
            return _backPack.Sum();
        }
    }
}

