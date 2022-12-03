namespace Schulteisz.AdventOfCode2022.Day03
{
	internal class CharValueCalculator
	{
        public static long Calculate(char item)
        {
            if (char.IsUpper(item))
                return item - 64 + 26;

            return item - 96;
        }
    }
}